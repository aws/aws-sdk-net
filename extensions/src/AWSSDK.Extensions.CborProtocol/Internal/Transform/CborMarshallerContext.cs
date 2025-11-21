/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.IO;

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    public class CborMarshallerContext : MarshallerContext
    {
        public CborWriter Writer { get; private set; }

        public CborMarshallerContext(IRequest request, CborWriter writer)
            : base(request)
        {
            Writer = writer;
        }
    }
}
