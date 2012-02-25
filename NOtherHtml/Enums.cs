using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NOtherHtml
{
    public enum Direction
    {
        Ltr,
        Rtl
    }

    public enum ValueType
    {
        Data,
        Ref,
        Object
    }

    public enum Shape
    {
        Default,
        Rect,
        Circle,
        Poly
    }

    public enum FormMethod
    {
        Get,
        Post
    }

    public enum InputType
    {
        Text,
        Password,
        Checkbox,
        Radio,
        Submit,
        Reset,
        File,
        Hidden,
        Image,
        Button
    }

    public enum ButtonType
    {
        Button,
        Submit,
        Reset
    }

    public enum TableFrame
    {
        Void,
        Above,
        Below,
        HSides,
        Lhs,
        Rhs,
        VSides,
        Box,
        Border
    }

    public enum TableRules
    {
        None,
        Groups,
        Rows,
        Cols,
        All
    }

    public enum TableAlign
    {
        Left,
        Center,
        Right
    }

    public enum CellHAlign
    {
        Left,
        Center,
        Right,
        Justify,
        Char
    }

    public enum CellVAlign
    {
        Top,
        Middle,
        Bottom,
        Baseline
    }

    public enum CaptionAlign
    {
        Top,
        Bottom,
        Left,
        Right
    }

    public enum CellScope
    {
        Row,
        Col,
        RowGroup,
        CellGroup
    }
}
