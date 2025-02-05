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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsIamGroupDetails Object
    /// </summary>  
    public class AwsIamGroupDetailsUnmarshaller : IJsonUnmarshaller<AwsIamGroupDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsIamGroupDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsIamGroupDetails unmarshalledObject = new AwsIamGroupDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AttachedManagedPolicies", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsIamAttachedManagedPolicy, AwsIamAttachedManagedPolicyUnmarshaller>(AwsIamAttachedManagedPolicyUnmarshaller.Instance);
                    unmarshalledObject.AttachedManagedPolicies = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GroupName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GroupPolicyList", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsIamGroupPolicy, AwsIamGroupPolicyUnmarshaller>(AwsIamGroupPolicyUnmarshaller.Instance);
                    unmarshalledObject.GroupPolicyList = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Path", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Path = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsIamGroupDetailsUnmarshaller _instance = new AwsIamGroupDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsIamGroupDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}