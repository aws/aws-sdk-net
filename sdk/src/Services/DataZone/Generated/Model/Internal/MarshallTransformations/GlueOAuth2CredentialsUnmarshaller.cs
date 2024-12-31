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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GlueOAuth2Credentials Object
    /// </summary>  
    public class GlueOAuth2CredentialsUnmarshaller : IUnmarshaller<GlueOAuth2Credentials, XmlUnmarshallerContext>, IUnmarshaller<GlueOAuth2Credentials, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        GlueOAuth2Credentials IUnmarshaller<GlueOAuth2Credentials, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public GlueOAuth2Credentials Unmarshall(JsonUnmarshallerContext context)
        {
            GlueOAuth2Credentials unmarshalledObject = new GlueOAuth2Credentials();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jwtToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JwtToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("refreshToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RefreshToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userManagedClientApplicationClientSecret", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserManagedClientApplicationClientSecret = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GlueOAuth2CredentialsUnmarshaller _instance = new GlueOAuth2CredentialsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GlueOAuth2CredentialsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}