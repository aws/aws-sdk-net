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
    /// Response Unmarshaller for AwsCloudFrontDistributionDetails Object
    /// </summary>  
    public class AwsCloudFrontDistributionDetailsUnmarshaller : IUnmarshaller<AwsCloudFrontDistributionDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsCloudFrontDistributionDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsCloudFrontDistributionDetails IUnmarshaller<AwsCloudFrontDistributionDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsCloudFrontDistributionDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsCloudFrontDistributionDetails unmarshalledObject = new AwsCloudFrontDistributionDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CacheBehaviors", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionCacheBehaviorsUnmarshaller.Instance;
                    unmarshalledObject.CacheBehaviors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultCacheBehavior", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionDefaultCacheBehaviorUnmarshaller.Instance;
                    unmarshalledObject.DefaultCacheBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultRootObject", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultRootObject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ETag", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ETag = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Logging", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionLoggingUnmarshaller.Instance;
                    unmarshalledObject.Logging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginGroups", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionOriginGroupsUnmarshaller.Instance;
                    unmarshalledObject.OriginGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Origins", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionOriginsUnmarshaller.Instance;
                    unmarshalledObject.Origins = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WebAclId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WebAclId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsCloudFrontDistributionDetailsUnmarshaller _instance = new AwsCloudFrontDistributionDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsCloudFrontDistributionDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}