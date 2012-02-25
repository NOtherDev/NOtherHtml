using System;

namespace NOtherHtml.Impl
{
    public interface IHaveId
    {
        void Id(string id);
    }

    public interface IHaveInnerContent
    {
        void Content(string content);
    }

    public interface IHaveCoreAttrs : IHaveId
    {
        void Class(string @class);
        void Style(string style);
        void Title(string title);
    }

    public interface IHaveI18n
    {
        void Lang(string lang);
        void Dir(Direction dir);
    }

    public interface IHaveEvents
    {
        void OnClick(string onClick);
        void OnDblClick(string onDblClick);
        void OnMouseDown(string onMouseDown);
        void OnMouseUp(string onMouseUp);
        void OnMouseOver(string onMouseOver);
        void OnMouseMove(string onMouseMove);
        void OnMouseOut(string onMouseOut);
        void OnKeyPress(string onKeyPress);
        void OnKeyDown(string onKeyDown);
        void OnKeyUp(string onKeyUp);
    }

    public interface IHaveFocus
    {
        void AccessKey(char accessKey);
        void TabIndex(int tabIndex);
        void OnFocus(string onFocus);
        void OnBlur(string onBlur);
    }

    public interface IHaveCommonAttrs : IHaveI18n, IHaveCoreAttrs, IHaveEvents {}

    public interface IHaveSpecialPreElements
    {
        void Br();
        void Br(Action<IBr> action);
        void Span(Action<ISpan> action);
        void Bdo(Action<IBdo> action);
        void Map(Action<IMap> action);
    }

    public interface IHaveSpecialElements : IHaveSpecialPreElements
    {
        void Object(Action<IObject> action);
        void Img(Action<IImg> action);
    }

    public interface IHaveFontStyleElements
    {
        void Tt(Action<ITt> action);
        void I(Action<II> action);
        void B(Action<IB> action);
        void Big(Action<IBig> action);
        void Small(Action<ISmall> action);
    }

    public interface IHavePhraseElements
    {
        void Em(Action<IEm> action);
        void Strong(Action<IStrong> action);
        void Dfn(Action<IDfn> action);
        void Code(Action<ICode> action);
        void Q(Action<IQ> action);
        void Samp(Action<ISamp> action);
        void Kbd(Action<IKbd> action);
        void Var(Action<IVar> action);
        void Cite(Action<ICite> action);
        void Abbr(Action<IAbbr> action);
        void Acronym(Action<IAcronym> action);
        void Sub(Action<ISub> action);
        void Sup(Action<ISup> action);
    }

    public interface IHaveInlineFormsElements
    {
        void Input(Action<IInput> action);
        void Select(Action<ISelect> action);
        void TextArea(Action<ITextArea> action);
        void Label(Action<ILabel> action);
        void Button(Action<IButton> action);
    }

    public interface IHaveMiscInlineElements
    {
        void Ins(Action<IIns> action);
        void Del(Action<IDel> action);
        void Script(Action<IScript> action);
    }

    public interface IHaveMiscElements : IHaveMiscInlineElements
    {
        void NoScript(Action<INoScript> action);
    }

    public interface IHaveInlineElements : IHaveSpecialElements, IHaveFontStyleElements, IHavePhraseElements, IHaveInlineFormsElements
    {
        void A(Action<IA> action);
    }

    public interface IInlineComplexType : IHaveInnerContent, IHaveInlineElements, IHaveMiscInlineElements {}

    public interface IHaveHeadingElements
    {
        void H1(Action<IH1> action);
        void H2(Action<IH2> action);
        void H3(Action<IH3> action);
        void H4(Action<IH4> action);
        void H5(Action<IH5> action);
        void H6(Action<IH6> action);
    }

    public interface IHaveListsElements
    {
        void Ul(Action<IUl> action);
        void Ol(Action<IOl> action);
        void Dl(Action<IDl> action);
    }

    public interface IHaveBlockTextElements
    {
        void Pre(Action<IPre> action);
        void Hr();
        void Hr(Action<IHr> action);
        void BlockQuote(Action<IBlockQuote> action);
        void Address(Action<IAddress> action);
    }

    public interface IHaveBlockElements : IHaveHeadingElements, IHaveListsElements, IHaveBlockTextElements
    {
        void P(Action<IP> action);
        void Div(Action<IDiv> action);
        void FieldSet(Action<IFieldSet> action);
        void Table(Action<ITable> action);
    }

    public interface IBlockComplexType : IHaveBlockElements, IHaveMiscElements
    {
        void Form(Action<IForm> action);
    }

    public interface IFlowComplexType : IHaveInnerContent, IHaveBlockElements, IHaveInlineElements, IHaveMiscElements
    {
        void Form(Action<IForm> action);
    }

    public interface IAContentComplexType : IHaveInnerContent, IHaveSpecialElements, IHaveFontStyleElements, IHavePhraseElements, IHaveInlineFormsElements, IHaveMiscInlineElements {}
    public interface IFormContentComplexType : IHaveBlockElements, IHaveMiscElements {}

    public interface IPreContentComplexType : IHaveInnerContent, IHaveFontStyleElements, IHavePhraseElements, IHaveSpecialPreElements, IHaveMiscInlineElements, IHaveInlineFormsElements
    {
        void A(Action<IA> action);
    }

    public interface IButtonContentComplexType : IHaveInnerContent, IHaveHeadingElements, IHaveListsElements, IHaveBlockTextElements, IHaveSpecialElements, IHaveFontStyleElements, IHavePhraseElements, IHaveMiscElements
    {
        void P(Action<IP> action);
        void Div(Action<IDiv> action);
        void Table(Action<ITable> action);
    }

    public interface IHaveHeadMiscElements
    {
        void Script(Action<IScript> action);
        void Style(Action<IStyle> action);
        void Meta(Action<IMeta> action);
        void Link(Action<ILink> action);
        void Object(Action<IObject> action);
    }

    public interface IHaveCellHAlignAttrs
    {
        void Align(CellHAlign align);
        void Char(char @char);
        void CharOff(string charOff);
    }

    public interface IHaveCellVAlignAttrs
    {
        void VAlign(CellVAlign vAlign);
    }

    public interface IInsDel : IFlowComplexType, IHaveCommonAttrs
    {
        void Cite(string cite);
        void DateTime(DateTime dateTime);
    }

    public interface IColColGroup : IHaveCommonAttrs, IHaveCellHAlignAttrs, IHaveCellVAlignAttrs
    {
        void Span(int span);
        void Width(string width);
    }

    public interface ITHeadBodyFoot : IHaveCommonAttrs, IHaveCellHAlignAttrs, IHaveCellVAlignAttrs
    {
        void Tr(Action<ITr> action);
    }  

    public interface ITdTh : IFlowComplexType, IHaveCommonAttrs, IHaveCellHAlignAttrs, IHaveCellVAlignAttrs
    {
        void Abbr(string abbr);
        void Axis(string axis);
        void Headers(string headers);
        void Scope(CellScope scope);
        void RowSpan(int rowSpan);
        void ColSpan(int colSpan);
    }

    public interface IOptionOptGroup : IHaveCommonAttrs
    {
        void Disabled(bool disabled);
        void Label(string label);
    }

    public interface IInputTextArea : IHaveCommonAttrs, IHaveFocus
    {
        void Name(string name);
        void Disabled(bool disabled);
        void ReadOnly(bool readOnly);
        void OnSelect(string onSelect);
        void OnChange(string onChange);
    }

    public interface IUlOl : IHaveCommonAttrs
    {
        void Li(Action<ILi> action);
    }
}