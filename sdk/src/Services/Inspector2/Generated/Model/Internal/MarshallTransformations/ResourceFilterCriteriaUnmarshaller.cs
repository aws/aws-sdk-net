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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceFilterCriteria Object
    /// </summary>  
    public class ResourceFilterCriteriaUnmarshaller : IJsonUnmarshaller<ResourceFilterCriteria, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceFilterCriteria Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ResourceFilterCriteria unmarshalledObject = new ResourceFilterCriteria();
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
                    var unmarshaller = new JsonListUnmarshaller<ResourceStringFilter, ResourceStringFilterUnmarshaller>(ResourceStringFilterUnmarshaller.Instance);
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2InstanceTags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceMapFilter, ResourceMapFilterUnmarshaller>(ResourceMapFilterUnmarshaller.Instance);
                    unmarshalledObject.Ec2InstanceTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ecrImageTags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceStringFilter, ResourceStringFilterUnmarshaller>(ResourceStringFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrImageTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ecrRepositoryName", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceStringFilter, ResourceStringFilterUnmarshaller>(ResourceStringFilterUnmarshaller.Instance);
                    unmarshalledObject.EcrRepositoryName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionName", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceStringFilter, ResourceStringFilterUnmarshaller>(ResourceStringFilterUnmarshaller.Instance);
                    unmarshalledObject.LambdaFunctionName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionTags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceMapFilter, ResourceMapFilterUnmarshaller>(ResourceMapFilterUnmarshaller.Instance);
                    unmarshalledObject.LambdaFunctionTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceId", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceStringFilter, ResourceStringFilterUnmarshaller>(ResourceStringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceType", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceStringFilter, ResourceStringFilterUnmarshaller>(ResourceStringFilterUnmarshaller.Instance);
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceFilterCriteriaUnmarshaller _instance = new ResourceFilterCriteriaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceFilterCriteriaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}