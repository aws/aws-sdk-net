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
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RdsDbInstance Object
    /// </summary>  
    public class RdsDbInstanceUnmarshaller : IUnmarshaller<RdsDbInstance, XmlUnmarshallerContext>, IUnmarshaller<RdsDbInstance, JsonUnmarshallerContext>
    {
        RdsDbInstance IUnmarshaller<RdsDbInstance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public RdsDbInstance Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RdsDbInstance unmarshalledObject = new RdsDbInstance();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Address", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbInstanceIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbInstanceIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbPassword", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbPassword = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DbUser", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Engine", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MissingOnRds", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MissingOnRds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RdsDbInstanceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RdsDbInstanceArn = unmarshaller.Unmarshall(context);
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
            }
          
            return unmarshalledObject;
        }


        private static RdsDbInstanceUnmarshaller _instance = new RdsDbInstanceUnmarshaller();        

        public static RdsDbInstanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}