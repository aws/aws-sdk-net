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
    /// Response Unmarshaller for AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails Object
    /// </summary>  
    public class AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetailsUnmarshaller : IUnmarshaller<AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails IUnmarshaller<AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails unmarshalledObject = new AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AssignPublicIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssignPublicIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Subnets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Subnets = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetailsUnmarshaller _instance = new AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEcsServiceNetworkConfigurationAwsVpcConfigurationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}