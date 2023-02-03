﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

namespace DocumentFormat.OpenXml.Packaging;

internal partial class PackageFeatureCollection
{
    private global::DocumentFormat.OpenXml.Features.IPartUriFeature? _CreatePartUri;
    private global::DocumentFormat.OpenXml.Features.AnnotationsFeature? _AnnotationsFeature;
    private global::DocumentFormat.OpenXml.Features.IPartExtensionFeature? _PartExtensionProvider;

    private partial T? GetInternal<T>()
    {
        if (typeof(T) == typeof(global::DocumentFormat.OpenXml.Features.IPartUriFeature))
        {
            if (_CreatePartUri is null)
            {
                _CreatePartUri = CreatePartUri();
            }

            return (T)_CreatePartUri;
        }

        if (typeof(T) == typeof(global::DocumentFormat.OpenXml.Features.AnnotationsFeature))
        {
            if (_AnnotationsFeature is null)
            {
                _AnnotationsFeature = new global::DocumentFormat.OpenXml.Features.AnnotationsFeature();
            }

            return (T)(object)_AnnotationsFeature;
        }

        if (typeof(T) == typeof(global::DocumentFormat.OpenXml.Features.IPartExtensionFeature))
        {
            if (_PartExtensionProvider is null)
            {
                _PartExtensionProvider = new global::DocumentFormat.OpenXml.Packaging.PartExtensionProvider();
            }

            return (T)_PartExtensionProvider;
        }

        return default;
    }
}
