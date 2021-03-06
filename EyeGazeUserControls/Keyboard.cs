﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Primitives;

namespace EyeGazeUserControls
{
    public enum KeyType
    {
        Normal,
        Toggle,
        Layout
    }

    public class Keyboard : DependencyObject
    {
        public static readonly DependencyProperty KeyTypeProperty =
            DependencyProperty.RegisterAttached("KeyType", typeof(KeyType), typeof(Keyboard), new PropertyMetadata(0));

        public static KeyType GetKeyType(DependencyObject obj)
        {
            return (KeyType)obj.GetValue(KeyTypeProperty);
        }

        public static void SetKeyType(DependencyObject obj, KeyType value)
        {
            obj.SetValue(KeyTypeProperty, value);
        }

        public static readonly DependencyProperty VKProperty =
            DependencyProperty.RegisterAttached("VK", typeof(int), typeof(Keyboard), new PropertyMetadata(0));

        public static int GetVK(DependencyObject obj)
        {
            return (int)obj.GetValue(VKProperty);
        }

        public static void SetVK(DependencyObject obj, int value)
        {
            obj.SetValue(VKProperty, value);
        }

        public static readonly DependencyProperty UnicodeProperty =
            DependencyProperty.RegisterAttached("Unicode", typeof(string), typeof(Keyboard), new PropertyMetadata(0));

        public static string GetUnicode(DependencyObject obj)
        {
            return obj.GetValue(UnicodeProperty) as string;
        }

        public static void SetUnicode(DependencyObject obj, string value)
        {
            obj.SetValue(UnicodeProperty, value);
        }

        public static readonly DependencyProperty VKListProperty =
            DependencyProperty.RegisterAttached("VKList", typeof(List<int>), typeof(Keyboard), new PropertyMetadata(0));

        public static List<int> GetVKList(DependencyObject obj)
        {
            var value = obj.GetValue(VKListProperty);
            var list = value as List<int>;
            if (list == null)
            {
                list = new List<int>();
                SetVKList(obj, list);
            }
            return list;
        }

        public static void SetVKList(DependencyObject obj, List<int> value)
        {
            obj.SetValue(VKListProperty, value);
        }

        public static readonly DependencyProperty PageListProperty =
            DependencyProperty.RegisterAttached("PageList", typeof(List<string>), typeof(Keyboard), new PropertyMetadata(0));

        public static List<string> GetPageList(DependencyObject obj)
        {
            var value = obj.GetValue(PageListProperty);
            var list = value as List<string>;
            if (list == null)
            {
                list = new List<string>();
                SetPageList(obj, list);
            }
            return list;
        }

        public static void SetPageList(DependencyObject obj, List<string> value)
        {
            obj.SetValue(PageListProperty, value);
        }


        public static readonly DependencyProperty PageContainerProperty =
            DependencyProperty.RegisterAttached("PageContainer", typeof(string), typeof(Keyboard), new PropertyMetadata(0));

        public static string GetPageContainer(DependencyObject obj)
        {
            return obj.GetValue(PageContainerProperty) as string;
        }

        public static void SetPageContainer(DependencyObject obj, string value)
        {
            obj.SetValue(PageContainerProperty, value);
        }


        public static readonly DependencyProperty TemporaryPageProperty =
            DependencyProperty.RegisterAttached("TemporaryPage", typeof(string), typeof(Keyboard), new PropertyMetadata(0));

        public static string GetTemporaryPage(DependencyObject obj)
        {
            return obj.GetValue(TemporaryPageProperty) as string;
        }

        public static void SetTemporaryPage(DependencyObject obj, string value)
        {
            obj.SetValue(TemporaryPageProperty, value);
        }

        public static readonly DependencyProperty NewPageProperty =
            DependencyProperty.RegisterAttached("NewPage", typeof(string), typeof(Keyboard), new PropertyMetadata(0));

        public static string GetNewPage(DependencyObject obj)
        {
            return obj.GetValue(NewPageProperty) as string;
        }

        public static void SetNewPage(DependencyObject obj, string value)
        {
            obj.SetValue(NewPageProperty, value);
        }
    }
}
