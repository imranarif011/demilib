﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2017/01/12 11:53
// License Copyright (c) Daniele Giardini

using System;

namespace DG.DeInspektor.Attributes
{
    /// <summary>
    /// <code>Method attribute</code><para/>
    /// Draws a button which will call the given method.<para/>
    /// Extra properties which can be set directly:<para/>
    /// - mode<para/>
    /// - textShade<para/>
    /// - bgShade<para/>
    /// - layout
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class DeMethodButtonAttribute : Attribute
    {
        /// <summary>Display mode</summary>
        public DeButtonMode mode = DeButtonMode.Default;
        /// <summary>Text shade</summary>
        public string textShade;
        /// <summary>Background shade</summary>
        public string bgShade;
        /// <summary>Layout changes (default: None)</summary>
        public DeLayout layout = DeLayout.None;

        internal string text;
        internal int order;
        internal object[] parameters;

        /// <summary>
        /// Draws a button which will call the method below.
        /// You can add as many DeMethodButton you want to the same method, then use the order parameter to order them correctly
        /// (note that the order will count only towards attributes on the same method, not overall).
        /// </summary>
        /// <param name="buttonText">Button text (if NULL uses a prettified version of the method name)</param>
        /// <param name="order">Order in which attributes for the same method will be displayed</param>
        /// <param name="parameters">Eventual parameters to pass to the method (higher means lower vertical position)</param>
        public DeMethodButtonAttribute(string buttonText = null, int order = 0, params object[] parameters)
        {
            this.text = buttonText;
            this.order = order;
            this.parameters = parameters;
        }
    }
}