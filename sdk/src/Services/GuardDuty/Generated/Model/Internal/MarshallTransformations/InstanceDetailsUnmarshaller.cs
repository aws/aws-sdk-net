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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceDetails Object
    /// </summary>  
    public class InstanceDetailsUnmarshaller : IUnmarshaller<InstanceDetails, XmlUnmarshallerContext>, IUnmarshaller<InstanceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InstanceDetails IUnmarshaller<InstanceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InstanceDetails unmarshalledObject = new InstanceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("availabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamInstanceProfile", targetDepth))
                {
                    var unmarshaller = IamInstanceProfileUnmarshaller.Instance;
                    unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("instanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("launchTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LaunchTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkInterfaces", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NetworkInterface, NetworkInterfaceUnmarshaller>(NetworkInterfaceUnmarshaller.Instance);
                    unmarshalledObject.NetworkInterfaces = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("productCodes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProductCode, ProductCodeUnmarshaller>(ProductCodeUnmarshaller.Instance);
                    unmarshalledObject.ProductCodes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InstanceDetailsUnmarshaller _instance = new InstanceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}