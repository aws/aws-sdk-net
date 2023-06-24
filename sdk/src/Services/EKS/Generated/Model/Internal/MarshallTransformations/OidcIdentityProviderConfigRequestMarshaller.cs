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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OidcIdentityProviderConfigRequest Marshaller
    /// </summary>
    public class OidcIdentityProviderConfigRequestMarshaller : IRequestMarshaller<OidcIdentityProviderConfigRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OidcIdentityProviderConfigRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClientId())
            {
                context.Writer.WritePropertyName("clientId");
                context.Writer.Write(requestObject.ClientId);
            }

            if(requestObject.IsSetGroupsClaim())
            {
                context.Writer.WritePropertyName("groupsClaim");
                context.Writer.Write(requestObject.GroupsClaim);
            }

            if(requestObject.IsSetGroupsPrefix())
            {
                context.Writer.WritePropertyName("groupsPrefix");
                context.Writer.Write(requestObject.GroupsPrefix);
            }

            if(requestObject.IsSetIdentityProviderConfigName())
            {
                context.Writer.WritePropertyName("identityProviderConfigName");
                context.Writer.Write(requestObject.IdentityProviderConfigName);
            }

            if(requestObject.IsSetIssuerUrl())
            {
                context.Writer.WritePropertyName("issuerUrl");
                context.Writer.Write(requestObject.IssuerUrl);
            }

            if(requestObject.IsSetRequiredClaims())
            {
                context.Writer.WritePropertyName("requiredClaims");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRequiredClaimsKvp in requestObject.RequiredClaims)
                {
                    context.Writer.WritePropertyName(requestObjectRequiredClaimsKvp.Key);
                    var requestObjectRequiredClaimsValue = requestObjectRequiredClaimsKvp.Value;

                        context.Writer.Write(requestObjectRequiredClaimsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUsernameClaim())
            {
                context.Writer.WritePropertyName("usernameClaim");
                context.Writer.Write(requestObject.UsernameClaim);
            }

            if(requestObject.IsSetUsernamePrefix())
            {
                context.Writer.WritePropertyName("usernamePrefix");
                context.Writer.Write(requestObject.UsernamePrefix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OidcIdentityProviderConfigRequestMarshaller Instance = new OidcIdentityProviderConfigRequestMarshaller();

    }
}