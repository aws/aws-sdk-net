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
    /// Response Unmarshaller for AwsElasticBeanstalkEnvironmentDetails Object
    /// </summary>  
    public class AwsElasticBeanstalkEnvironmentDetailsUnmarshaller : IUnmarshaller<AwsElasticBeanstalkEnvironmentDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsElasticBeanstalkEnvironmentDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsElasticBeanstalkEnvironmentDetails IUnmarshaller<AwsElasticBeanstalkEnvironmentDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsElasticBeanstalkEnvironmentDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsElasticBeanstalkEnvironmentDetails unmarshalledObject = new AwsElasticBeanstalkEnvironmentDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplicationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Cname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DateCreated", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateCreated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DateUpdated", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnvironmentArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnvironmentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnvironmentLinks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsElasticBeanstalkEnvironmentEnvironmentLink, AwsElasticBeanstalkEnvironmentEnvironmentLinkUnmarshaller>(AwsElasticBeanstalkEnvironmentEnvironmentLinkUnmarshaller.Instance);
                    unmarshalledObject.EnvironmentLinks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnvironmentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EnvironmentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OptionSettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsElasticBeanstalkEnvironmentOptionSetting, AwsElasticBeanstalkEnvironmentOptionSettingUnmarshaller>(AwsElasticBeanstalkEnvironmentOptionSettingUnmarshaller.Instance);
                    unmarshalledObject.OptionSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PlatformArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SolutionStackName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SolutionStackName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tier", targetDepth))
                {
                    var unmarshaller = AwsElasticBeanstalkEnvironmentTierUnmarshaller.Instance;
                    unmarshalledObject.Tier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VersionLabel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VersionLabel = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsElasticBeanstalkEnvironmentDetailsUnmarshaller _instance = new AwsElasticBeanstalkEnvironmentDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsElasticBeanstalkEnvironmentDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}