﻿// Copyright (c) 2020 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Reactive.Linq;
using ReactiveUI.Fody.Helpers;

namespace ReactiveUI.Fody.Tests
{
    public class Issue11TestModel : ReactiveObject
    {
        public Issue11TestModel(string myProperty) => MyProperty = Observable.Return(myProperty).ToFodyProperty();

        public extern string MyProperty
        {
            get; private set;
        }
    }
}