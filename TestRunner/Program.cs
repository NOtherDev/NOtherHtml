using System;
using System.Collections.Generic;
using System.Linq;
using NOtherHtml;
using NOtherHtml.Impl;
using ValueType = NOtherHtml.ValueType;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = Html.For<IHtml>(x =>
            {
                x.Head(h =>
                {
                    h.Title(t => t.Content("test"));
                    h.Base(b => b.Href("href"));
                    h.Meta(m =>
                    {
                        m.HttpEquiv("content-type");
                        m.Content("text/html; charset=iso-8859-2");
                    });
                    h.Meta(m =>
                    {
                        m.Name("keywords");
                        m.Content("some keywords");
                        m.Dir(Direction.Rtl);
                    });
                    h.Object(o =>
                    {
                        o.OnKeyUp("onkeyup");
                        o.Param(p => p.Value("abc"));
                        o.Param(p => p.ValueType(ValueType.Ref));
                        o.Ins(n =>
                        {
                            n.DateTime(DateTime.Now);
                            n.Br();
                        });
                    });
                    h.Link(l =>
                    {
                        l.Rel("stylesheet");
                        l.Href("asdf");
                    });
                });
                x.Id("theid");
                x.Body(b =>
                {
                    b.OnLoad("onload");
                    b.P(p =>
                    {
                        p.Content("test");
                        p.A(a => a.Href("test"));
                        p.Content("test2");
                    });
                });
            });

            Console.WriteLine(html);
            Console.ReadKey();
        }
    }
}
