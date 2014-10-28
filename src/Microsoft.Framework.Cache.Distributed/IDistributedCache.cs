// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Framework.Runtime;

namespace Microsoft.Framework.Cache.Distributed
{
    [AssemblyNeutral]
    public interface IDistributedCache
    {
        void Connect();

        Stream Set(string key, object state, Action<ICacheContext> create);

        Task<Stream> SetAsync(string key, object state, Func<ICacheContext, Task> create);

        bool TryGetValue(string key, out Stream value);

        void Refresh(string key);

        void Remove(string key);
    }
}