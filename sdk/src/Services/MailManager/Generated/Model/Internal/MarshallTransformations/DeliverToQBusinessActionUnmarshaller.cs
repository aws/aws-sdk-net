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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeliverToQBusinessAction Object
    /// </summary>  
    public class DeliverToQBusinessActionUnmarshaller : IUnmarshaller<DeliverToQBusinessAction, XmlUnmarshallerContext>, IUnmarshaller<DeliverToQBusinessAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DeliverToQBusinessAction IUnmarshaller<DeliverToQBusinessAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DeliverToQBusinessAction Unmarshall(JsonUnmarshallerContext context)
        {
            DeliverToQBusinessAction unmarshalledObject = new DeliverToQBusinessAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActionFailurePolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionFailurePolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApplicationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IndexId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IndexId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DeliverToQBusinessActionUnmarshaller _instance = new DeliverToQBusinessActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeliverToQBusinessActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}