using System.Linq;
using System.Collections.Generic;
using System;
using System.Xml;

namespace NOtherHtml.Impl
{
    internal partial class ElementImpl : IHtml, IHead, IMeta, ITitle, IBase, ILink, IBody, IForm, IIns, IDel, 
        INoScript, IObject, IParam, IPre, IScript, IStyle, IBr, IA, IH1, IH2, IH3, IH4, IH5, IH6, IHr,
        ISpan, IBdo, IMap, IArea, IImg, IBlockQuote, IAddress, IP, IDiv, IFieldSet, ILegend, ITable,
        ICaption, ICol, IColGroup, ITHead, ITFoot, ITBody, ITr, ITd, ITh, IInput, ISelect, IOptGroup,
        IOption, ITextArea, ILabel, IButton, IUl, IOl, ILi, IDl, IDt, IDd, ITt, II, IB, IBig, ISmall,
        IEm, IStrong, IDfn, ICode, ISamp, IKbd, IVar, ICite, IAbbr, IAcronym, IQ, ISup, ISub
    {
        private readonly NodeBuilder _nb;

        public ElementImpl(XmlDocument doc, XmlNode parent, string name)
        {
            _nb = new NodeBuilder(doc, parent, name);
        }

        public void Content(string content)
        {
            _nb.AddContent(content);
        }

        void IMeta.Content(string content)
        {
            _nb.SetAttribute("content", content);
        }

        public void CData(string content)
        {
            _nb.AddCDataContent(content);
        }        

        public void Br()
        {
            _nb.AddEmptyNode("br");
        }

        public void Hr()
        {
            _nb.AddEmptyNode("hr");
        }
    }
}
