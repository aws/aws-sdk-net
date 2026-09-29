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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QBusiness.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OAuth2ClientCredentialConfiguration Marshaller
    /// </summary>
    public partial class OAuth2ClientCredentialConfigurationMarshaller : IRequestMarshaller<OAuth2ClientCredentialConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(OAuth2ClientCredentialConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAuthorizationUrl())
            {
                context.Writer.WritePropertyName("authorizationUrl");
                context.Writer.WriteStringValue(requestObject.AuthorizationUrl);
            }

            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if (requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("secretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if (requestObject.IsSetTokenUrl())
            {
                context.Writer.WritePropertyName("tokenUrl");
                context.Writer.WriteStringValue(requestObject.TokenUrl);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OAuth2ClientCredentialConfigurationMarshaller Instance = new OAuth2ClientCredentialConfigurationMarshaller();
    }
}
