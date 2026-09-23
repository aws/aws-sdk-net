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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkSecurityManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkSecurityManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OutOfSyncReasonsView Object
    /// </summary>  
    public class OutOfSyncReasonsViewUnmarshaller : IJsonUnmarshaller<OutOfSyncReasonsView, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public OutOfSyncReasonsView Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            OutOfSyncReasonsView unmarshalledObject = new OutOfSyncReasonsView();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("notVisible", targetDepth, ref reader))
                {
                    var unmarshaller = NotVisibleMarkerUnmarshaller.Instance;
                    unmarshalledObject.NotVisible = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("reasons", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, FirewallSyncReason, StringUnmarshaller, FirewallSyncReasonUnmarshaller>(StringUnmarshaller.Instance, FirewallSyncReasonUnmarshaller.Instance);
                    unmarshalledObject.Reasons = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OutOfSyncReasonsViewUnmarshaller _instance = new OutOfSyncReasonsViewUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OutOfSyncReasonsViewUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}