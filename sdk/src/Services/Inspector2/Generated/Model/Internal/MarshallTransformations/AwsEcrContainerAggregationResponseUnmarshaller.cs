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
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEcrContainerAggregationResponse Object
    /// </summary>  
    public class AwsEcrContainerAggregationResponseUnmarshaller : IUnmarshaller<AwsEcrContainerAggregationResponse, XmlUnmarshallerContext>, IUnmarshaller<AwsEcrContainerAggregationResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEcrContainerAggregationResponse IUnmarshaller<AwsEcrContainerAggregationResponse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEcrContainerAggregationResponse Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEcrContainerAggregationResponse unmarshalledObject = new AwsEcrContainerAggregationResponse();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("architecture", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Architecture = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageSha", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageSha = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ImageTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("repository", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Repository = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("severityCounts", targetDepth))
                {
                    var unmarshaller = SeverityCountsUnmarshaller.Instance;
                    unmarshalledObject.SeverityCounts = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEcrContainerAggregationResponseUnmarshaller _instance = new AwsEcrContainerAggregationResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcrContainerAggregationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}