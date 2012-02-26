using System;
using System.Collections.Generic;
using System.Linq;
using NOtherHtml;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = Html.For(x =>
            {
                x.Lang("en");
                x.Head(head =>
                {
                    head.Meta(meta =>
                    {
                        meta.HttpEquiv("Content-Type");
                        meta.Content("text/html; charset=UTF-8");
                    });
                    head.Title(t => t.Content("XHTML 1.0 Strict Example"));
                    head.Script(script =>
                    {
                        script.Type("text/javascript");
                        script.CData(@"function loadpdf() {
                            document.getElementById(""pdf-object"").src=""http://www.w3.org/TR/xhtml1/xhtml1.pdf"";
                        }");
                    });
                });
                x.Body(body =>
                {
                    body.OnLoad("loadpdf()");
                    body.P(p =>
                    {
                        p.Content("This is an example of an");
                        p.Abbr(abbr =>
                        {
                            abbr.Title("Extensible HyperText Markup Language");
                            abbr.Content("XHTML");
                        });
                        p.Content("1.0 Strict document.");
                        p.Br();
                        p.Img(img =>
                        {
                            img.Id("validation-icon");
                            img.Src("http://www.w3.org/Icons/valid-xhtml10");
                            img.Alt("Valid XHTML 1.0 Strict");
                        });
                        p.Br();
                        p.Object(obj =>
                        {
                            obj.Id("pdf-object");
                            obj.Name("pdf-object");
                            obj.Type("application/pdf");
                            obj.Data("http://www.w3.org/TR/xhtml1/xhtml1.pdf");
                            obj.Width("100%");
                            obj.Height("500");
                        });
                    });
                });
            });

            Console.WriteLine(html);
            Console.ReadKey();
        }
    }
}
