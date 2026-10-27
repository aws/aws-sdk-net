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

using Amazon.WAFV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManagedProductDescriptor Object
    /// </summary>
    public partial class ManagedProductDescriptorUnmarshaller : IJsonUnmarshaller<ManagedProductDescriptor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ManagedProductDescriptor Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ManagedProductDescriptor();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("IsAdvancedManagedRuleSet", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsAdvancedManagedRuleSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("IsVersioningSupported", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsVersioningSupported = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ManagedRuleSetName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManagedRuleSetName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProductDescription", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProductId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProductLink", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductLink = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProductTitle", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductTitle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnsTopicArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnsTopicArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VendorName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VendorName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ManagedProductDescriptorUnmarshaller _instance = new ManagedProductDescriptorUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ManagedProductDescriptorUnmarshaller Instance => _instance;
    }
}
