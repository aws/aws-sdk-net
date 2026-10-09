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

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IntegrationCredential Marshaller
    /// </summary>
    public partial class IntegrationCredentialMarshaller : IRequestMarshaller<IntegrationCredential, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(IntegrationCredential requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetApiKeyCredential())
            {
                context.Writer.WriteTextString("apiKeyCredential");
                context.Writer.WriteStartMap(null);

                var marshaller = ApiKeyCredentialMarshaller.Instance;
                marshaller.Marshall(requestObject.ApiKeyCredential, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetOauthClientCredential())
            {
                context.Writer.WriteTextString("oauthClientCredential");
                context.Writer.WriteStartMap(null);

                var marshaller = OAuthClientCredentialMarshaller.Instance;
                marshaller.Marshall(requestObject.OauthClientCredential, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetOauthCodeCredential())
            {
                context.Writer.WriteTextString("oauthCodeCredential");
                context.Writer.WriteStartMap(null);

                var marshaller = OAuthCodeCredentialMarshaller.Instance;
                marshaller.Marshall(requestObject.OauthCodeCredential, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static IntegrationCredentialMarshaller Instance = new IntegrationCredentialMarshaller();
    }
}
