﻿// Copyright (c) 2002-2017 "Neo Technology,"
// Network Engine for Objects in Lund AB [http://neotechnology.com]
// 
// This file is part of Neo4j.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using Neo4j.Driver.V1;

namespace Neo4j.Driver.Internal
{
    internal class ConnectionSettings
    {
        internal const string DefaultUserAgent = "neo4j-dotnet/1.2";

        public Uri InitialServerUri { get; }
        public IAuthToken AuthToken { get; }
        public TimeSpan ConnectionTimeout { get; }
        public string UserAgent { get; }
        public EncryptionManager EncryptionManager;

        public ConnectionSettings(Uri initialServerUri, IAuthToken authToken, EncryptionManager encryptionManager, TimeSpan connectionTimeout, string userAgent = null)
        {
            Throw.ArgumentNullException.IfNull(initialServerUri, nameof(initialServerUri));
            Throw.ArgumentNullException.IfNull(authToken, nameof(authToken));
            Throw.ArgumentNullException.IfNull(encryptionManager, nameof(encryptionManager));

            InitialServerUri = initialServerUri;
            AuthToken = authToken;
            EncryptionManager = encryptionManager;
            ConnectionTimeout = connectionTimeout;
            UserAgent = userAgent ?? DefaultUserAgent;
        }
    }
}