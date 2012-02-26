using System.Linq;
using System.Collections.Generic;
using System;
using NOtherHtml.Impl;

namespace NOtherHtml
{
    public interface IHtml : IHaveId, IHaveI18n
    {
        void Head(Action<IHead> action);
        void Body(Action<IBody> action);
    }

    public interface IHead : IHaveHeadMiscElements, IHaveId, IHaveI18n
    {
        void Title(Action<ITitle> action);
        void Profile(string profile);
        void Base(Action<IBase> action);
    }

    public interface ITitle : IHaveInnerContent, IHaveI18n, IHaveId {}

    public interface IBase : IHaveId
    {
        void Href(string href);
    }

    public interface IMeta : IHaveId, IHaveI18n
    {
        void Name(string name);
        void Content(string content);
        void HttpEquiv(string httpEquiv);
        void Scheme(string scheme);
    }

    public interface IScript : IHaveId, IHaveInnerContent
    {
        void CData(string content);
        void Charset(string charset);
        void Type(string type);
        void Src(string uri);
        void Defer(bool defer);
    }

    public interface IStyle : IHaveId, IHaveI18n, IHaveInnerContent
    {
        void CData(string content);
        void Type(string type);
        void Media(string media);
        void Title(string title);
    }

    public interface ILink : IHaveCommonAttrs
    {
        void Charset(string charset);
        void Href(string href);
        void HrefLang(string hrefLang);
        void Type(string type);
        void Rel(string rel);
        void Rev(string rev);
        void Media(string media);
    }

    public interface IBody : IBlockComplexType, IHaveCommonAttrs
    {
        void OnLoad(string onLoad);
        void OnUnload(string onUnload);
    }

    public interface IObject : IHaveInnerContent, IHaveBlockElements, IHaveInlineElements, IHaveMiscElements, IHaveCommonAttrs
    {
        void Param(Action<IParam> action);
        void Form(Action<IForm> action);
        void Declare(bool declare);
        void ClassId(string classid);
        void Codebase(string codebase);
        void Data(string data);
        void Type(string type);
        void CodeType(string codeType);
        void Archive(string archive);
        void StandBy(string standBy);
        void Height(string height);
        void Width(string width);
        void UseMap(string useMap);
        void Name(string name);
        void TabIndex(int tabIndex);
    }

    public interface IParam : IHaveId
    {
        void Name(string name);
        void Value(string value);
        void ValueType(ValueType valueType);
        void Type(string type);
    }

    public interface IIns : IInsDel {}
    public interface IDel : IInsDel {}

    public interface IForm : IHaveInnerContent, IFormContentComplexType, IHaveCommonAttrs
    {
        void Action(string action);
        void Method(FormMethod method);
        void EncType(string enctype);
        void OnSubmit(string onSubmit);
        void OnReset(string onReset);
        void Accept(string accept);
        void AcceptCharset(string acceptCharset);
    }

    public interface IA : IAContentComplexType, IHaveCommonAttrs, IHaveFocus
    {
        void Charset(string charset);
        void Type(string type);
        void Name(string name);
        void Href(string href);
        void HrefLang(string hrefLang);
        void Rel(string rel);
        void Rev(string rev);
        void Shape(Shape shape);
        void Coords(string coords);
    }

    public interface INoScript : IHaveCommonAttrs, IBlockComplexType {}
    public interface IPre : IPreContentComplexType, IHaveCommonAttrs {}
    public interface IBr : IHaveCoreAttrs {}
    public interface IH1 : IInlineComplexType, IHaveCommonAttrs {}
    public interface IH2 : IInlineComplexType, IHaveCommonAttrs {}
    public interface IH3 : IInlineComplexType, IHaveCommonAttrs {}
    public interface IH4 : IInlineComplexType, IHaveCommonAttrs {}
    public interface IH5 : IInlineComplexType, IHaveCommonAttrs {}
    public interface IH6 : IInlineComplexType, IHaveCommonAttrs {}
    public interface IHr : IHaveCommonAttrs {}
    public interface ISpan : IInlineComplexType, IHaveCommonAttrs {}
    public interface IBdo : IInlineComplexType, IHaveCommonAttrs {}
    public interface IAddress : IInlineComplexType, IHaveCommonAttrs {}

    public interface IMap : IHaveBlockElements, IHaveMiscElements, IHaveCommonAttrs
    {
        void Form(Action<IForm> action);
        void Area(Action<IArea> action);
        void Name(string name);
    }

    public interface IArea : IHaveCommonAttrs, IHaveFocus
    {
        void Shape(Shape shape);
        void Coords(string coords);
        void Href(string href);
        void NoHref(bool noHref);
        void Alt(string alt);
    }

    public interface IImg : IHaveCommonAttrs
    {
        void Src(string src);
        void Alt(string alt);
        void LongDesc(string longDesc);
        void Height(string height);
        void Width(string width);
        void UseMap(string map);
        void IsMap(bool isMap);
    }

    public interface IBlockQuote : IBlockComplexType, IHaveCommonAttrs
    {
        void Cite(string cite);
    }

    public interface IP : IInlineComplexType, IHaveCommonAttrs {}
    public interface IDiv : IFlowComplexType, IHaveCommonAttrs {}

    public interface IFieldSet : IHaveInnerContent, IHaveBlockElements, IHaveInlineElements, IHaveMiscElements, IHaveCommonAttrs
    {
        void Legend(Action<ILegend> action);
        void Form(Action<IForm> action);
    }

    public interface ILegend : IInlineComplexType, IHaveCommonAttrs
    {
        void AccessKey(char accessKey);
    }

    public interface ITable : IHaveCommonAttrs
    {
        void Caption(Action<ICaption> action);
        void Col(Action<ICol> action);
        void ColGroup(Action<IColGroup> action);
        void THead(Action<ITHead> action);
        void TFoot(Action<ITFoot> action);
        void TBody(Action<ITBody> action);
        void Tr(Action<ITr> action);
        void Summary(string summary);
        void Width(string width);
        void Border(int border);
        void Frame(TableFrame frame);
        void Rules(TableRules rules);
        void CellSpacing(string cellSpacing);
        void CellPadding(string cellPadding);
    }

    public interface ICaption : IInlineComplexType, IHaveCommonAttrs {}
    public interface ICol : IColColGroup {}

    public interface IColGroup : IColColGroup
    {
        void Col(Action<ICol> action);
    }  
    
    public interface ITHead : ITHeadBodyFoot {}
    public interface ITFoot : ITHeadBodyFoot {}
    public interface ITBody : ITHeadBodyFoot {}

    public interface ITr : IHaveCommonAttrs, IHaveCellHAlignAttrs, IHaveCellVAlignAttrs
    {
        void Th(Action<ITh> action);
        void Td(Action<ITd> action);
    }

    public interface ITh : ITdTh {}
    public interface ITd : ITdTh {}

    public interface IInput : IInputTextArea
    {
        void Type(InputType type);
        void Value(string value);
        void Checked(bool @checked);
        void Size(string size);
        void MaxLength(int maxLength);
        void Src(string src);
        void Alt(string alt);
        void UseMap(string useMap);
        void Accept(string accept);
    }

    public interface ITextArea : IHaveInnerContent, IInputTextArea
    {
        void Rows(int rows);
        void Cols(int cols);
    }

    public interface ISelect : IHaveCommonAttrs
    {
        void OptGroup(Action<IOptGroup> action);
        void Option(Action<IOption> action);
        void Name(string name);
        void Size(int size);
        void Multiple(bool multiple);
        void Disabled(bool disabled);
        void TabIndex(int tabIndex);
        void OnFocus(string onFocus);
        void OnBlur(string onBlur);
        void OnChange(string onChange);
    }

    public interface IOptGroup : IOptionOptGroup
    {
        void Option(Action<IOption> action);
    }

    public interface IOption : IHaveInnerContent, IOptionOptGroup
    {
        void Selected(bool selected);
        void Value(string value);
    }

    public interface ILabel : IHaveInnerContent, IHaveCommonAttrs
    {
        void For(string @for);
        void AccessKey(char accessKey);
        void OnFocus(string onFocus);
        void OnBlur(string onBlur);
    }

    public interface IButton : IButtonContentComplexType, IHaveCommonAttrs, IHaveFocus
    {
        void Name(string name);
        void Value(string value);
        void Type(ButtonType type);
        void Disabled(bool disabled);
    }

    public interface IUl : IUlOl {}
    public interface IOl : IUlOl {}
    public interface ILi : IFlowComplexType, IHaveCommonAttrs {}

    public interface IDl : IHaveCommonAttrs
    {
        void Dt(Action<IDt> action);
        void Dd(Action<IDd> action);
    }

    public interface IDt : IInlineComplexType, IHaveCommonAttrs {}
    public interface IDd : IFlowComplexType, IHaveCommonAttrs {}
    public interface ITt : IInlineComplexType, IHaveCommonAttrs {}
    public interface II : IInlineComplexType, IHaveCommonAttrs {}
    public interface IB : IInlineComplexType, IHaveCommonAttrs {}
    public interface IBig : IInlineComplexType, IHaveCommonAttrs {}
    public interface ISmall : IInlineComplexType, IHaveCommonAttrs {}
    public interface IEm : IInlineComplexType, IHaveCommonAttrs {}
    public interface IStrong : IInlineComplexType, IHaveCommonAttrs {}
    public interface IDfn : IInlineComplexType, IHaveCommonAttrs {}
    public interface ICode : IInlineComplexType, IHaveCommonAttrs {}
    public interface ISamp : IInlineComplexType, IHaveCommonAttrs {}
    public interface IKbd : IInlineComplexType, IHaveCommonAttrs {}
    public interface IVar : IInlineComplexType, IHaveCommonAttrs {}
    public interface ICite : IInlineComplexType, IHaveCommonAttrs {}
    public interface IAbbr : IInlineComplexType, IHaveCommonAttrs {}
    public interface IAcronym : IInlineComplexType, IHaveCommonAttrs {}
    public interface ISub : IInlineComplexType, IHaveCommonAttrs {}
    public interface ISup : IInlineComplexType, IHaveCommonAttrs {}

    public interface IQ : IInlineComplexType, IHaveCommonAttrs
    {
        void Cite(string cite);
    }
}