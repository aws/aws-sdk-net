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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEcrRepositoryDetails Object
    /// </summary>  
    public class AwsEcrRepositoryDetailsUnmarshaller : IUnmarshaller<AwsEcrRepositoryDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEcrRepositoryDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEcrRepositoryDetails IUnmarshaller<AwsEcrRepositoryDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEcrRepositoryDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEcrRepositoryDetails unmarshalledObject = new AwsEcrRepositoryDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageScanningConfiguration", targetDepth))
                {
                    var unmarshaller = AwsEcrRepositoryImageScanningConfigurationDetailsUnmarshaller.Instance;
                    unmarshalledObject.ImageScanningConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImageTagMutability", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageTagMutability = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifecyclePolicy", targetDepth))
                {
                    var unmarshaller = AwsEcrRepositoryLifecyclePolicyDetailsUnmarshaller.Instance;
                    unmarshalledObject.LifecyclePolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RepositoryName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepositoryName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RepositoryPolicyText", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepositoryPolicyText = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEcrRepositoryDetailsUnmarshaller _instance = new AwsEcrRepositoryDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcrRepositoryDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}