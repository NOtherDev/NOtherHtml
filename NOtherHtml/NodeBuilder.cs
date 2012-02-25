using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml;

namespace NOtherHtml
{
    internal class NodeBuilder
    {
        private readonly XmlDocument _doc;
        private readonly XmlNode _node;

        public NodeBuilder(XmlDocument doc, XmlNode parent, string name)
        {
            _doc = doc;
            _node = doc.CreateElement(name);
            parent.AppendChild(_node);
        }

        public void SetAttribute(string name, string value)
        {
            var attribute = _doc.CreateAttribute(name);
            attribute.Value = value;
            _node.Attributes.Append(attribute);
        }

        public void SetAttribute(string name, DateTime value)
        {
            SetAttribute(name, value.ToString("s", CultureInfo.InvariantCulture));
        }

        public void SetAttribute(string name, bool condition)
        {
            if (condition)
                SetAttribute(name, name);
        }

        public void SetAttribute(string name, object value)
        {
            SetAttribute(name, value.ToString().ToLowerInvariant());
        }

        public void AddNode<T>(Action<T> action)
            where T : class
        {
            action(ElementFactory.For<T>(_doc, _node));
        }        
        
        public void AddEmptyNode(string name)
        {
            _node.AppendChild(_doc.CreateElement(name));
        }

        public void AddContent(string content)
        {
            _node.AppendChild(_doc.CreateTextNode(content));
        }
    }
}