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
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RdsLoginAttemptAction Object
    /// </summary>  
    public class RdsLoginAttemptActionUnmarshaller : IUnmarshaller<RdsLoginAttemptAction, XmlUnmarshallerContext>, IUnmarshaller<RdsLoginAttemptAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RdsLoginAttemptAction IUnmarshaller<RdsLoginAttemptAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RdsLoginAttemptAction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RdsLoginAttemptAction unmarshalledObject = new RdsLoginAttemptAction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LoginAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LoginAttribute, LoginAttributeUnmarshaller>(LoginAttributeUnmarshaller.Instance);
                    unmarshalledObject.LoginAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("remoteIpDetails", targetDepth))
                {
                    var unmarshaller = RemoteIpDetailsUnmarshaller.Instance;
                    unmarshalledObject.RemoteIpDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RdsLoginAttemptActionUnmarshaller _instance = new RdsLoginAttemptActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RdsLoginAttemptActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}