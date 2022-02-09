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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OAuthProperties Marshaller
    /// </summary>
    public class OAuthPropertiesMarshaller : IRequestMarshaller<OAuthProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OAuthProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAuthCodeUrl())
            {
                context.Writer.WritePropertyName("authCodeUrl");
                context.Writer.Write(requestObject.AuthCodeUrl);
            }

            if(requestObject.IsSetOAuthScopes())
            {
                context.Writer.WritePropertyName("oAuthScopes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOAuthScopesListValue in requestObject.OAuthScopes)
                {
                        context.Writer.Write(requestObjectOAuthScopesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTokenUrl())
            {
                context.Writer.WritePropertyName("tokenUrl");
                context.Writer.Write(requestObject.TokenUrl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OAuthPropertiesMarshaller Instance = new OAuthPropertiesMarshaller();

    }
}