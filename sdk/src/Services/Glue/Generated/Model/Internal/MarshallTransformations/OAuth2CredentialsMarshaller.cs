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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OAuth2Credentials Marshaller
    /// </summary>
    public class OAuth2CredentialsMarshaller : IRequestMarshaller<OAuth2Credentials, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OAuth2Credentials requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessToken())
            {
                context.Writer.WritePropertyName("AccessToken");
                context.Writer.WriteStringValue(requestObject.AccessToken);
            }

            if(requestObject.IsSetJwtToken())
            {
                context.Writer.WritePropertyName("JwtToken");
                context.Writer.WriteStringValue(requestObject.JwtToken);
            }

            if(requestObject.IsSetRefreshToken())
            {
                context.Writer.WritePropertyName("RefreshToken");
                context.Writer.WriteStringValue(requestObject.RefreshToken);
            }

            if(requestObject.IsSetUserManagedClientApplicationClientSecret())
            {
                context.Writer.WritePropertyName("UserManagedClientApplicationClientSecret");
                context.Writer.WriteStringValue(requestObject.UserManagedClientApplicationClientSecret);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OAuth2CredentialsMarshaller Instance = new OAuth2CredentialsMarshaller();

    }
}