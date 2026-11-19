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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.RpcV2CBORCorpusProtocolTests.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.RpcV2CBORCorpusProtocolTests.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BlobPayloadEvent Object
    /// </summary>
    public partial class BlobPayloadEventUnmarshaller : ICborUnmarshaller<BlobPayloadEvent, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public BlobPayloadEvent Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new BlobPayloadEvent();
            if (context.IsEmptyResponse) return null;

            unmarshalledObject.Data = context.Stream as MemoryStream;
            if (context.ResponseData.IsEventHeaderPresent("contentType"))
            {
                unmarshalledObject.ContentType = context.ResponseData.GetEventStreamHeader("contentType").AsString();
            }
            return unmarshalledObject;
        }

        private static BlobPayloadEventUnmarshaller _instance = new BlobPayloadEventUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static BlobPayloadEventUnmarshaller Instance => _instance;
    }
}
