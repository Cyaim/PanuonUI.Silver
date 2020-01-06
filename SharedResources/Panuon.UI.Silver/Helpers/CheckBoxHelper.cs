﻿using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class CheckBoxHelper
    {
        #region Properties

        #region CheckBoxStyle
        public static CheckBoxStyle GetCheckBoxStyle(DependencyObject obj)
        {
            return (CheckBoxStyle)obj.GetValue(CheckBoxStyleProperty);
        }

        public static void SetCheckBoxStyle(DependencyObject obj, CheckBoxStyle value)
        {
            obj.SetValue(CheckBoxStyleProperty, value);
        }

        public static readonly DependencyProperty CheckBoxStyleProperty =
            DependencyProperty.RegisterAttached("CheckBoxStyle", typeof(CheckBoxStyle), typeof(CheckBoxHelper));
        #endregion

        #region CheckedBackground
        public static Brush GetCheckedBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(CheckedBackgroundProperty);
        }

        public static void SetCheckedBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(CheckedBackgroundProperty, value);
        }

        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("CheckedBackground", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region GlyphBrush
        public static Brush GetGlyphBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(GlyphBrushProperty);
        }

        public static void SetGlyphBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(GlyphBrushProperty, value);
        }

        public static readonly DependencyProperty GlyphBrushProperty =
            DependencyProperty.RegisterAttached("GlyphBrush", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region CheckedGlyphBrush
        public static Brush GetCheckedGlyphBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(CheckedGlyphBrushProperty);
        }

        public static void SetCheckedGlyphBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(CheckedGlyphBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedGlyphBrushProperty =
            DependencyProperty.RegisterAttached("CheckedGlyphBrush", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region CheckedBorderBrush
        public static Brush GetCheckedBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(CheckedBorderBrushProperty);
        }

        public static void SetCheckedBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(CheckedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CheckedBorderBrush", typeof(Brush), typeof(CheckBoxHelper));
        #endregion

        #region BoxHeight
        public static double GetBoxHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(BoxHeightProperty);
        }

        public static void SetBoxHeight(DependencyObject obj, double value)
        {
            obj.SetValue(BoxHeightProperty, value);
        }

        public static readonly DependencyProperty BoxHeightProperty =
            DependencyProperty.RegisterAttached("BoxHeight", typeof(double), typeof(CheckBoxHelper));
        #endregion

        #region BoxWidth
        public static double GetBoxWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(BoxWidthProperty);
        }

        public static void SetBoxWidth(DependencyObject obj, double value)
        {
            obj.SetValue(BoxWidthProperty, value);
        }

        public static readonly DependencyProperty BoxWidthProperty =
            DependencyProperty.RegisterAttached("BoxWidth", typeof(double), typeof(CheckBoxHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(CheckBoxHelper));
        #endregion

        #region CheckedContent
        public static object GetCheckedContent(DependencyObject obj)
        {
            return (object)obj.GetValue(CheckedContentProperty);
        }

        public static void SetCheckedContent(DependencyObject obj, object value)
        {
            obj.SetValue(CheckedContentProperty, value);
        }

        public static readonly DependencyProperty CheckedContentProperty =
            DependencyProperty.RegisterAttached("CheckedContent", typeof(object), typeof(CheckBoxHelper));
        #endregion

        #endregion
    }
}