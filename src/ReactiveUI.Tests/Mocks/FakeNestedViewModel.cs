﻿// Copyright (c) 2020 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI.Tests
{
    public class FakeNestedViewModel : ReactiveObject
    {
        public FakeNestedViewModel() => NestedCommand = ReactiveCommand.Create(() => { });

        public ReactiveCommand<Unit, Unit> NestedCommand { get; protected set; }
    }
}
