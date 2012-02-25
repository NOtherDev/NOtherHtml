using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace NOtherHtml
{
    public static class Html
    {
        public static string For(Action<IHtml> action)
        {
            return For<IHtml>(action);
        }

        public static string For<T>(Action<T> action)
            where T : class
        {
            using (var stringWriter = new StringWriter())
            {
                XmlDoc(action).WriteTo(new XmlTextWriter(stringWriter));
                return stringWriter.ToString();
            }
        }        
        
        public static XmlDocument XmlDoc(Action<IHtml> action)
        {
            return XmlDoc<IHtml>(action);
        }

        public static XmlDocument XmlDoc<T>(Action<T> action)
            where T : class
        {
            var doc = new XmlDocument();
            action(ElementFactory.For<T>(doc));
            return doc;
        }
    }
}
