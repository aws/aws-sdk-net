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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Ec2Instance Object
    /// </summary>  
    public class Ec2InstanceUnmarshaller : IJsonUnmarshaller<Ec2Instance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Ec2Instance Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Ec2Instance unmarshalledObject = new Ec2Instance();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("availabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2NetworkInterfaceUids", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Ec2NetworkInterfaceUids = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IamInstanceProfile", targetDepth))
                {
                    var unmarshaller = IamInstanceProfileUnmarshaller.Instance;
                    unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outpostArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutpostArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("platform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("productCodes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ProductCode, ProductCodeUnmarshaller>(ProductCodeUnmarshaller.Instance);
                    unmarshalledObject.ProductCodes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Ec2InstanceUnmarshaller _instance = new Ec2InstanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Ec2InstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}