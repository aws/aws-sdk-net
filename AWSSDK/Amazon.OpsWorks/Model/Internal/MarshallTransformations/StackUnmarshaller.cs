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

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Stack Object
    /// </summary>  
    public class StackUnmarshaller : IUnmarshaller<Stack, XmlUnmarshallerContext>, IUnmarshaller<Stack, JsonUnmarshallerContext>
    {
        Stack IUnmarshaller<Stack, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public Stack Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new Stack();
            unmarshalledObject.Attributes = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Arn", targetDepth))
                    {
                        unmarshalledObject.Arn = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Attributes", targetDepth))
                    {
                        unmarshalledObject.Attributes = new Dictionary<string, string>();
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.GetInstance(), StringUnmarshaller.GetInstance());
                        while (context.Read())
                        {
                          if (((context.IsStartArray || context.IsStartElement || context.IsLeafValue) && (context.CurrentDepth == targetDepth)) ||
                              ((context.IsKey) && (context.CurrentDepth == targetDepth+1)))
                          {
                            var kvp = unmarshaller.Unmarshall(context);
                            unmarshalledObject.Attributes.Add(kvp.Key, kvp.Value);
                          }
                          else if (context.IsEndElement)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("ChefConfiguration", targetDepth))
                    {
                        unmarshalledObject.ChefConfiguration = ChefConfigurationUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ConfigurationManager", targetDepth))
                    {
                        unmarshalledObject.ConfigurationManager = StackConfigurationManagerUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedAt", targetDepth))
                    {
                        unmarshalledObject.CreatedAt = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomCookbooksSource", targetDepth))
                    {
                        unmarshalledObject.CustomCookbooksSource = SourceUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomJson", targetDepth))
                    {
                        unmarshalledObject.CustomJson = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultAvailabilityZone", targetDepth))
                    {
                        unmarshalledObject.DefaultAvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultInstanceProfileArn", targetDepth))
                    {
                        unmarshalledObject.DefaultInstanceProfileArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultOs", targetDepth))
                    {
                        unmarshalledObject.DefaultOs = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultRootDeviceType", targetDepth))
                    {
                        unmarshalledObject.DefaultRootDeviceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultSshKeyName", targetDepth))
                    {
                        unmarshalledObject.DefaultSshKeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultSubnetId", targetDepth))
                    {
                        unmarshalledObject.DefaultSubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HostnameTheme", targetDepth))
                    {
                        unmarshalledObject.HostnameTheme = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        unmarshalledObject.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Region", targetDepth))
                    {
                        unmarshalledObject.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceRoleArn", targetDepth))
                    {
                        unmarshalledObject.ServiceRoleArn = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackId", targetDepth))
                    {
                        unmarshalledObject.StackId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UseCustomCookbooks", targetDepth))
                    {
                        unmarshalledObject.UseCustomCookbooks = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UseOpsworksSecurityGroups", targetDepth))
                    {
                        unmarshalledObject.UseOpsworksSecurityGroups = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VpcId", targetDepth))
                    {
                        unmarshalledObject.VpcId = StringUnmarshaller.GetInstance().Unmarshall(context);
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


        private static StackUnmarshaller instance;
        public static StackUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new StackUnmarshaller();
            }
            return instance;
        }

    }
}