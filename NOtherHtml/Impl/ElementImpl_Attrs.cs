using System.Linq;
using System.Collections.Generic;
using System;

namespace NOtherHtml.Impl
{
    internal partial class ElementImpl
    {
        public void Href(string href)
        {
            _nb.SetAttribute("href", href);
        }

        public void NoHref(bool noHref)
        {
            _nb.SetAttribute("nohref", noHref);
        }

        public void Alt(string alt)
        {
            _nb.SetAttribute("alt", alt);
        }

        public void LongDesc(string longDesc)
        {
            _nb.SetAttribute("longdesc", longDesc);
        }

        public void HrefLang(string hrefLang)
        {
            _nb.SetAttribute("hreflang", hrefLang);
        }

        public void Charset(string charset)
        {
            _nb.SetAttribute("charset", charset);
        }

        public void Rev(string rev)
        {
            _nb.SetAttribute("rev", rev);
        }

        public void Shape(Shape shape)
        {
            _nb.SetAttribute("shape", shape);
        }

        public void Coords(string coords)
        {
            _nb.SetAttribute("coords", coords);
        }

        public void Media(string media)
        {
            _nb.SetAttribute("media", media);
        }

        public void HttpEquiv(string httpEquiv)
        {
            _nb.SetAttribute("http-equiv", httpEquiv);
        }

        public void Scheme(string scheme)
        {
            _nb.SetAttribute("scheme", scheme);
        }

        public void MaxLength(int maxLength)
        {
            _nb.SetAttribute("maxlength", maxLength);
        }

        public void Src(string uri)
        {
            _nb.SetAttribute("src", uri);
        }

        public void Defer(bool defer)
        {
            _nb.SetAttribute("defer", defer);
        }

        public void Id(string id)
        {
            _nb.SetAttribute("id", id);
        }

        public void Label(string label)
        {
            _nb.SetAttribute("label", label);
        }

        public void Value(string value)
        {
            _nb.SetAttribute("value", value);
        }

        public void Type(ButtonType type)
        {
            _nb.SetAttribute("type", type);
        }

        public void Checked(bool @checked)
        {
            _nb.SetAttribute("checked", @checked);
        }

        public void Multiple(bool multiple)
        {
            _nb.SetAttribute("multiple", multiple);
        }

        public void Selected(bool selected)
        {
            _nb.SetAttribute("selected", selected);
        }

        public void Disabled(bool disabled)
        {
            _nb.SetAttribute("disabled", disabled);
        }

        public void ReadOnly(bool readOnly)
        {
            _nb.SetAttribute("readonly", readOnly);
        }

        public void Size(string size)
        {
            _nb.SetAttribute("size", size);
        }

        public void ValueType(ValueType valueType)
        {
            _nb.SetAttribute("valuetype", valueType);
        }

        public void Declare(bool declare)
        {
            _nb.SetAttribute("declare", declare);
        }

        public void ClassId(string classid)
        {
            _nb.SetAttribute("classid", classid);
        }

        public void Codebase(string codebase)
        {
            _nb.SetAttribute("codebase", codebase);
        }

        public void Data(string data)
        {
            _nb.SetAttribute("data", data);
        }

        public void Type(string type)
        {
            _nb.SetAttribute("type", type);
        }

        public void Rel(string rel)
        {
            _nb.SetAttribute("rel", rel);
        }

        public void CodeType(string codeType)
        {
            _nb.SetAttribute("codetype", codeType);
        }

        public void Archive(string archive)
        {
            _nb.SetAttribute("archive", archive);
        }

        public void StandBy(string standBy)
        {
            _nb.SetAttribute("standby", standBy);
        }

        public void Height(string height)
        {
            _nb.SetAttribute("height", height);
        }

        public void Summary(string summary)
        {
            _nb.SetAttribute("summary", summary);
        }

        public void Span(int span)
        {
            _nb.SetAttribute("span", span);
        }

        public void Width(string width)
        {
            _nb.SetAttribute("width", width);
        }

        public void Border(int border)
        {
            _nb.SetAttribute("border", border);
        }

        public void Frame(TableFrame frame)
        {
            _nb.SetAttribute("frame", frame);
        }

        public void Rules(TableRules rules)
        {
            _nb.SetAttribute("rules", rules);
        }

        public void CellSpacing(string cellSpacing)
        {
            _nb.SetAttribute("cellspacing", cellSpacing);
        }

        public void CellPadding(string cellPadding)
        {
            _nb.SetAttribute("cellpadding", cellPadding);
        }

        public void UseMap(string useMap)
        {
            _nb.SetAttribute("usemap", useMap);
        }

        public void OnSelect(string onSelect)
        {
            _nb.SetAttribute("onselect", onSelect);
        }

        public void OnChange(string onChange)
        {
            _nb.SetAttribute("onchange", onChange);
        }

        public void IsMap(bool isMap)
        {
            _nb.SetAttribute("ismap", isMap);
        }

        public void Type(InputType type)
        {
            _nb.SetAttribute("type", type);
        }

        public void Name(string name)
        {
            _nb.SetAttribute("name", name);
        }

        public void Size(int size)
        {
            _nb.SetAttribute("size", size);
        }

        public void For(string @for)
        {
            _nb.SetAttribute("for", @for);
        }

        public void AccessKey(char accessKey)
        {
            _nb.SetAttribute("accesskey", accessKey);
        }

        public void TabIndex(int tabIndex)
        {
            _nb.SetAttribute("tabindex", tabIndex);
        }

        public void OnFocus(string onFocus)
        {
            _nb.SetAttribute("onfocus", onFocus);
        }

        public void OnBlur(string onBlur)
        {
            _nb.SetAttribute("onblur", onBlur);
        }

        public void Cite(string cite)
        {
            _nb.SetAttribute("cite", cite);
        }

        public void DateTime(DateTime dateTime)
        {
            _nb.SetAttribute("datetime", dateTime);
        }

        public void Action(string action)
        {
            _nb.SetAttribute("action", action);
        }

        public void Method(FormMethod method)
        {
            _nb.SetAttribute("method", method);
        }

        public void EncType(string enctype)
        {
            _nb.SetAttribute("enctype", enctype);
        }

        public void OnSubmit(string onSubmit)
        {
            _nb.SetAttribute("onsubmit", onSubmit);
        }

        public void OnReset(string onReset)
        {
            _nb.SetAttribute("onreset", onReset);
        }

        public void Accept(string accept)
        {
            _nb.SetAttribute("accept", accept);
        }

        public void AcceptCharset(string acceptCharset)
        {
            _nb.SetAttribute("accept-charset", acceptCharset);
        }
        
        public void OnLoad(string onLoad)
        {
            _nb.SetAttribute("onload", onLoad);
        }

        public void OnUnload(string onUnload)
        {
            _nb.SetAttribute("onunload", onUnload);
        }

        public void Lang(string lang)
        {
            _nb.SetAttribute("lang", lang);
            _nb.SetAttribute("xml:lang", lang);
        }

        public void Dir(Direction dir)
        {
            _nb.SetAttribute("dir", dir);
        }

        public void Profile(string profile)
        {
            _nb.SetAttribute("profile", profile);
        }

        public void Class(string @class)
        {
            _nb.SetAttribute("class", @class);
        }

        public void Style(string style)
        {
            _nb.SetAttribute("style", style);
        }

        public void Title(string title)
        {
            _nb.SetAttribute("title", title);
        }

        public void OnClick(string onClick)
        {
            _nb.SetAttribute("onclick", onClick);
        }

        public void OnDblClick(string onDblClick)
        {
            _nb.SetAttribute("ondblclick", onDblClick);
        }

        public void OnMouseDown(string onMouseDown)
        {
            _nb.SetAttribute("onmousedown", onMouseDown);
        }

        public void OnMouseUp(string onMouseUp)
        {
            _nb.SetAttribute("onmouseup", onMouseUp);
        }

        public void OnMouseOver(string onMouseOver)
        {
            _nb.SetAttribute("onmouseover", onMouseOver);
        }

        public void OnMouseMove(string onMouseMove)
        {
            _nb.SetAttribute("onmousemove", onMouseMove);
        }

        public void OnMouseOut(string onMouseOut)
        {
            _nb.SetAttribute("onmouseout", onMouseOut);
        }

        public void OnKeyPress(string onKeyPress)
        {
            _nb.SetAttribute("onkeypress", onKeyPress);
        }

        public void OnKeyDown(string onKeyDown)
        {
            _nb.SetAttribute("onkeydown", onKeyDown);
        }

        public void OnKeyUp(string onKeyUp)
        {
            _nb.SetAttribute("onkeyup", onKeyUp);
        }

        public void Align(CellHAlign align)
        {
            _nb.SetAttribute("align", align);
        }

        public void Char(char @char)
        {
            _nb.SetAttribute("char", @char);
        }

        public void CharOff(string charOff)
        {
            _nb.SetAttribute("charoff", charOff);
        }

        public void VAlign(CellVAlign vAlign)
        {
            _nb.SetAttribute("valign", vAlign);
        }

        public void Abbr(string abbr)
        {
            _nb.SetAttribute("abbr", abbr);
        }

        public void Axis(string axis)
        {
            _nb.SetAttribute("axis", axis);
        }

        public void Headers(string headers)
        {
            _nb.SetAttribute("headers", headers);
        }

        public void Scope(CellScope scope)
        {
            _nb.SetAttribute("scope", scope);
        }

        public void RowSpan(int rowSpan)
        {
            _nb.SetAttribute("rowspan", rowSpan);
        }

        public void ColSpan(int colSpan)
        {
            _nb.SetAttribute("colspan", colSpan);
        }

        public void Rows(int rows)
        {
            _nb.SetAttribute("rows", rows);
        }

        public void Cols(int cols)
        {
            _nb.SetAttribute("cols", cols);
        }
    }
}
