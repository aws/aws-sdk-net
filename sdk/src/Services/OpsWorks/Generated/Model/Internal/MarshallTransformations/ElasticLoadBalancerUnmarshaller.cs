/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ElasticLoadBalancer Object
    /// </summary>  
    public class ElasticLoadBalancerUnmarshaller : IUnmarshaller<ElasticLoadBalancer, XmlUnmarshallerContext>, IUnmarshaller<ElasticLoadBalancer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ElasticLoadBalancer IUnmarshaller<ElasticLoadBalancer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ElasticLoadBalancer Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ElasticLoadBalancer unmarshalledObject = new ElasticLoadBalancer();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AvailabilityZones", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2InstanceIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ec2InstanceIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElasticLoadBalancerName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElasticLoadBalancerName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LayerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LayerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StackId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SubnetIds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ElasticLoadBalancerUnmarshaller _instance = new ElasticLoadBalancerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ElasticLoadBalancerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}