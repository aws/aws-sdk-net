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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResiliencyPolicy Object
    /// </summary>  
    public class ResiliencyPolicyUnmarshaller : IJsonUnmarshaller<ResiliencyPolicy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ResiliencyPolicy Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResiliencyPolicy unmarshalledObject = new ResiliencyPolicy();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataLocationConstraint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataLocationConstraint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("estimatedCostTier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EstimatedCostTier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("policy", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, FailurePolicy, StringUnmarshaller, FailurePolicyUnmarshaller>(StringUnmarshaller.Instance, FailurePolicyUnmarshaller.Instance);
                    unmarshalledObject.Policy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("policyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("policyDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("policyName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Tier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResiliencyPolicyUnmarshaller _instance = new ResiliencyPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResiliencyPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}