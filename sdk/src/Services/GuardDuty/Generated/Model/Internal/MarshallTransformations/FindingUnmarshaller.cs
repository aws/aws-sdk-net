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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Finding Object
    /// </summary>  
    public class FindingUnmarshaller : IJsonUnmarshaller<Finding, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Finding Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Finding unmarshalledObject = new Finding();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("associatedAttackSequenceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociatedAttackSequenceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("confidence", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("partition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Partition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resource", targetDepth))
                {
                    var unmarshaller = ResourceUnmarshaller.Instance;
                    unmarshalledObject.Resource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("schemaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("service", targetDepth))
                {
                    var unmarshaller = ServiceUnmarshaller.Instance;
                    unmarshalledObject.Service = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("severity", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FindingUnmarshaller _instance = new FindingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}