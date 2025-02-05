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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchJobDefinition Object
    /// </summary>  
    public class BatchJobDefinitionUnmarshaller : IJsonUnmarshaller<BatchJobDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public BatchJobDefinition Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            BatchJobDefinition unmarshalledObject = new BatchJobDefinition();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("fileBatchJobDefinition", targetDepth))
                {
                    var unmarshaller = FileBatchJobDefinitionUnmarshaller.Instance;
                    unmarshalledObject.FileBatchJobDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scriptBatchJobDefinition", targetDepth))
                {
                    var unmarshaller = ScriptBatchJobDefinitionUnmarshaller.Instance;
                    unmarshalledObject.ScriptBatchJobDefinition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BatchJobDefinitionUnmarshaller _instance = new BatchJobDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchJobDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}