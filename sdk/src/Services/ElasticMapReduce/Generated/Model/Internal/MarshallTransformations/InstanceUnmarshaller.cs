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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Instance Object
    /// </summary>  
    public class InstanceUnmarshaller : IUnmarshaller<Instance, XmlUnmarshallerContext>, IUnmarshaller<Instance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Instance IUnmarshaller<Instance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Instance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Instance unmarshalledObject = new Instance();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EbsVolumes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EbsVolume, EbsVolumeUnmarshaller>(EbsVolumeUnmarshaller.Instance);
                    unmarshalledObject.EbsVolumes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceFleetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceFleetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceGroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceGroupId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Market", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Market = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateIpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PublicDnsName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicDnsName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PublicIpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PublicIpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = InstanceStatusUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InstanceUnmarshaller _instance = new InstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}