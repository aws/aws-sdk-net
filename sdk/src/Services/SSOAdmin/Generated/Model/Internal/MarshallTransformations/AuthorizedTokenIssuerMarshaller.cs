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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSOAdmin.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SSOAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthorizedTokenIssuer Marshaller
    /// </summary>
    public class AuthorizedTokenIssuerMarshaller : IRequestMarshaller<AuthorizedTokenIssuer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AuthorizedTokenIssuer requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthorizedAudiences())
            {
                context.Writer.WritePropertyName("AuthorizedAudiences");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAuthorizedAudiencesListValue in requestObject.AuthorizedAudiences)
                {
                        context.Writer.Write(requestObjectAuthorizedAudiencesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTrustedTokenIssuerArn())
            {
                context.Writer.WritePropertyName("TrustedTokenIssuerArn");
                context.Writer.Write(requestObject.TrustedTokenIssuerArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AuthorizedTokenIssuerMarshaller Instance = new AuthorizedTokenIssuerMarshaller();

    }
}