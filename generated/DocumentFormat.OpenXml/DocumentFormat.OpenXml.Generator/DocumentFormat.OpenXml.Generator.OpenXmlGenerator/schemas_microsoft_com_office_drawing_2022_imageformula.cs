﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.Drawing.Y2022.ImageFormula
{
    /// <summary>
    /// <para>Defines the ImageFormula Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is aif:imageFormula.</para>
    /// </summary>
    public partial class ImageFormula : TypedOpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageFormula class.
        /// </summary>
        public ImageFormula() : base()
        {
        }

        /// <summary>
        /// <para>formula, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: formula</para>
        /// </summary>
        public StringValue? Formula
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("aif:imageFormula");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<ImageFormula>()
                .AddAttribute("formula", a => a.Formula);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageFormula>(deep);
    }
}