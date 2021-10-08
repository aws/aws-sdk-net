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
    /// Response Unmarshaller for AwsEc2VpcEndpointServiceDetails Object
    /// </summary>  
    public class AwsEc2VpcEndpointServiceDetailsUnmarshaller : IUnmarshaller<AwsEc2VpcEndpointServiceDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2VpcEndpointServiceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2VpcEndpointServiceDetails IUnmarshaller<AwsEc2VpcEndpointServiceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2VpcEndpointServiceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2VpcEndpointServiceDetails unmarshalledObject = new AwsEc2VpcEndpointServiceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AcceptanceRequired", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AcceptanceRequired = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AvailabilityZones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BaseEndpointDnsNames", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BaseEndpointDnsNames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GatewayLoadBalancerArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.GatewayLoadBalancerArns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManagesVpcEndpoints", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ManagesVpcEndpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkLoadBalancerArns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NetworkLoadBalancerArns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceType", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2VpcEndpointServiceServiceTypeDetails, AwsEc2VpcEndpointServiceServiceTypeDetailsUnmarshaller>(AwsEc2VpcEndpointServiceServiceTypeDetailsUnmarshaller.Instance);
                    unmarshalledObject.ServiceType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2VpcEndpointServiceDetailsUnmarshaller _instance = new AwsEc2VpcEndpointServiceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2VpcEndpointServiceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}