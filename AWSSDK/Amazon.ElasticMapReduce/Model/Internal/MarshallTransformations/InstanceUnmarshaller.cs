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

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Instance Object
    /// </summary>  
    public class InstanceUnmarshaller : IUnmarshaller<Instance, XmlUnmarshallerContext>, IUnmarshaller<Instance, JsonUnmarshallerContext>
    {
        Instance IUnmarshaller<Instance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public Instance Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new Instance();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Ec2InstanceId", targetDepth))
                    {
                        unmarshalledObject.Ec2InstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        unmarshalledObject.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PrivateDnsName", targetDepth))
                    {
                        unmarshalledObject.PrivateDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PrivateIpAddress", targetDepth))
                    {
                        unmarshalledObject.PrivateIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PublicDnsName", targetDepth))
                    {
                        unmarshalledObject.PublicDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PublicIpAddress", targetDepth))
                    {
                        unmarshalledObject.PublicIpAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        unmarshalledObject.Status = InstanceStatusUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static InstanceUnmarshaller instance;
        public static InstanceUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new InstanceUnmarshaller();
            }
            return instance;
        }

    }
}