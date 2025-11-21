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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthenticationMetadata Marshaller
    /// </summary>
    public class AuthenticationMetadataMarshaller : IRequestMarshaller<AuthenticationMetadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AuthenticationMetadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiKeyConnectionMetadata())
            {
                context.Writer.WritePropertyName("ApiKeyConnectionMetadata");
                context.Writer.WriteStartObject();

                var marshaller = APIKeyConnectionMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.ApiKeyConnectionMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAuthorizationCodeGrantMetadata())
            {
                context.Writer.WritePropertyName("AuthorizationCodeGrantMetadata");
                context.Writer.WriteStartObject();

                var marshaller = AuthorizationCodeGrantMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthorizationCodeGrantMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBasicAuthConnectionMetadata())
            {
                context.Writer.WritePropertyName("BasicAuthConnectionMetadata");
                context.Writer.WriteStartObject();

                var marshaller = BasicAuthConnectionMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.BasicAuthConnectionMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClientCredentialsGrantMetadata())
            {
                context.Writer.WritePropertyName("ClientCredentialsGrantMetadata");
                context.Writer.WriteStartObject();

                var marshaller = ClientCredentialsGrantMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientCredentialsGrantMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamConnectionMetadata())
            {
                context.Writer.WritePropertyName("IamConnectionMetadata");
                context.Writer.WriteStartObject();

                var marshaller = IAMConnectionMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.IamConnectionMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNoneConnectionMetadata())
            {
                context.Writer.WritePropertyName("NoneConnectionMetadata");
                context.Writer.WriteStartObject();

                var marshaller = NoneConnectionMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.NoneConnectionMetadata, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AuthenticationMetadataMarshaller Instance = new AuthenticationMetadataMarshaller();

    }
}