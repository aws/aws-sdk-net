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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NotifyConfigurationType Object
    /// </summary>  
    public class NotifyConfigurationTypeUnmarshaller : IUnmarshaller<NotifyConfigurationType, XmlUnmarshallerContext>, IUnmarshaller<NotifyConfigurationType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NotifyConfigurationType IUnmarshaller<NotifyConfigurationType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NotifyConfigurationType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NotifyConfigurationType unmarshalledObject = new NotifyConfigurationType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BlockEmail", targetDepth))
                {
                    var unmarshaller = NotifyEmailTypeUnmarshaller.Instance;
                    unmarshalledObject.BlockEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("From", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.From = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MfaEmail", targetDepth))
                {
                    var unmarshaller = NotifyEmailTypeUnmarshaller.Instance;
                    unmarshalledObject.MfaEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoActionEmail", targetDepth))
                {
                    var unmarshaller = NotifyEmailTypeUnmarshaller.Instance;
                    unmarshalledObject.NoActionEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplyTo", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplyTo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NotifyConfigurationTypeUnmarshaller _instance = new NotifyConfigurationTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NotifyConfigurationTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}