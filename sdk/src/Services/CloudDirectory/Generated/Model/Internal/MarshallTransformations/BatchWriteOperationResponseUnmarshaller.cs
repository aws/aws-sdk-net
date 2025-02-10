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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchWriteOperationResponse Object
    /// </summary>  
    public class BatchWriteOperationResponseUnmarshaller : IJsonUnmarshaller<BatchWriteOperationResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public BatchWriteOperationResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            BatchWriteOperationResponse unmarshalledObject = new BatchWriteOperationResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AddFacetToObject", targetDepth))
                {
                    var unmarshaller = BatchAddFacetToObjectResponseUnmarshaller.Instance;
                    unmarshalledObject.AddFacetToObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AttachObject", targetDepth))
                {
                    var unmarshaller = BatchAttachObjectResponseUnmarshaller.Instance;
                    unmarshalledObject.AttachObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AttachPolicy", targetDepth))
                {
                    var unmarshaller = BatchAttachPolicyResponseUnmarshaller.Instance;
                    unmarshalledObject.AttachPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AttachToIndex", targetDepth))
                {
                    var unmarshaller = BatchAttachToIndexResponseUnmarshaller.Instance;
                    unmarshalledObject.AttachToIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AttachTypedLink", targetDepth))
                {
                    var unmarshaller = BatchAttachTypedLinkResponseUnmarshaller.Instance;
                    unmarshalledObject.AttachTypedLink = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateIndex", targetDepth))
                {
                    var unmarshaller = BatchCreateIndexResponseUnmarshaller.Instance;
                    unmarshalledObject.CreateIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateObject", targetDepth))
                {
                    var unmarshaller = BatchCreateObjectResponseUnmarshaller.Instance;
                    unmarshalledObject.CreateObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeleteObject", targetDepth))
                {
                    var unmarshaller = BatchDeleteObjectResponseUnmarshaller.Instance;
                    unmarshalledObject.DeleteObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DetachFromIndex", targetDepth))
                {
                    var unmarshaller = BatchDetachFromIndexResponseUnmarshaller.Instance;
                    unmarshalledObject.DetachFromIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DetachObject", targetDepth))
                {
                    var unmarshaller = BatchDetachObjectResponseUnmarshaller.Instance;
                    unmarshalledObject.DetachObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DetachPolicy", targetDepth))
                {
                    var unmarshaller = BatchDetachPolicyResponseUnmarshaller.Instance;
                    unmarshalledObject.DetachPolicy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DetachTypedLink", targetDepth))
                {
                    var unmarshaller = BatchDetachTypedLinkResponseUnmarshaller.Instance;
                    unmarshalledObject.DetachTypedLink = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RemoveFacetFromObject", targetDepth))
                {
                    var unmarshaller = BatchRemoveFacetFromObjectResponseUnmarshaller.Instance;
                    unmarshalledObject.RemoveFacetFromObject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdateLinkAttributes", targetDepth))
                {
                    var unmarshaller = BatchUpdateLinkAttributesResponseUnmarshaller.Instance;
                    unmarshalledObject.UpdateLinkAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdateObjectAttributes", targetDepth))
                {
                    var unmarshaller = BatchUpdateObjectAttributesResponseUnmarshaller.Instance;
                    unmarshalledObject.UpdateObjectAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BatchWriteOperationResponseUnmarshaller _instance = new BatchWriteOperationResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchWriteOperationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}