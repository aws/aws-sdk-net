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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBackendAuthResourceConfig Marshaller
    /// </summary>
    public class CreateBackendAuthResourceConfigMarshaller : IRequestMarshaller<CreateBackendAuthResourceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateBackendAuthResourceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthResources())
            {
                context.Writer.WritePropertyName("authResources");
                context.Writer.WriteStringValue(requestObject.AuthResources);
            }

            if(requestObject.IsSetIdentityPoolConfigs())
            {
                context.Writer.WritePropertyName("identityPoolConfigs");
                context.Writer.WriteStartObject();

                var marshaller = CreateBackendAuthIdentityPoolConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.IdentityPoolConfigs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetService())
            {
                context.Writer.WritePropertyName("service");
                context.Writer.WriteStringValue(requestObject.Service);
            }

            if(requestObject.IsSetUserPoolConfigs())
            {
                context.Writer.WritePropertyName("userPoolConfigs");
                context.Writer.WriteStartObject();

                var marshaller = CreateBackendAuthUserPoolConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.UserPoolConfigs, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateBackendAuthResourceConfigMarshaller Instance = new CreateBackendAuthResourceConfigMarshaller();

    }
}