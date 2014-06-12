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

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EC2SecurityGroup Object
    /// </summary>  
    public class EC2SecurityGroupUnmarshaller : IUnmarshaller<EC2SecurityGroup, XmlUnmarshallerContext>, IUnmarshaller<EC2SecurityGroup, JsonUnmarshallerContext>
    {
        public EC2SecurityGroup Unmarshall(XmlUnmarshallerContext context)
        {
            EC2SecurityGroup unmarshalledObject = new EC2SecurityGroup();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("EC2SecurityGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EC2SecurityGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EC2SecurityGroupOwnerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EC2SecurityGroupOwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public EC2SecurityGroup Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static EC2SecurityGroupUnmarshaller _instance = new EC2SecurityGroupUnmarshaller();        

        public static EC2SecurityGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}