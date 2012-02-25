using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml;
using NOtherHtml.Impl;

namespace NOtherHtml
{
    public static class ElementFactory
    {
        internal static T For<T>(XmlDocument doc, XmlNode node)
            where T : class
        {
            var elementName = GetElementName<T>();
            var impl = new ElementImpl(doc, node, elementName) as T;

            if (impl == null)
                throw new NotSupportedException(String.Format("Element of type '{0}' is not supported.", elementName));

            return impl;
        }

        public static T For<T>(XmlDocument doc)
            where T : class
        {
            return For<T>(doc, doc);
        }

        private static string GetElementName<T>()
        {
            return typeof(T).Name.Substring(1).ToLowerInvariant();
        }
    }
}