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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AdvancedSecurityOptionsInput Marshaller
    /// </summary>
    public class AdvancedSecurityOptionsInputMarshaller : IRequestMarshaller<AdvancedSecurityOptionsInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AdvancedSecurityOptionsInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnonymousAuthEnabled())
            {
                context.Writer.WritePropertyName("AnonymousAuthEnabled");
                context.Writer.WriteBooleanValue(requestObject.AnonymousAuthEnabled.Value);
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetIAMFederationOptions())
            {
                context.Writer.WritePropertyName("IAMFederationOptions");
                context.Writer.WriteStartObject();

                var marshaller = IAMFederationOptionsInputMarshaller.Instance;
                marshaller.Marshall(requestObject.IAMFederationOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInternalUserDatabaseEnabled())
            {
                context.Writer.WritePropertyName("InternalUserDatabaseEnabled");
                context.Writer.WriteBooleanValue(requestObject.InternalUserDatabaseEnabled.Value);
            }

            if(requestObject.IsSetJWTOptions())
            {
                context.Writer.WritePropertyName("JWTOptions");
                context.Writer.WriteStartObject();

                var marshaller = JWTOptionsInputMarshaller.Instance;
                marshaller.Marshall(requestObject.JWTOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMasterUserOptions())
            {
                context.Writer.WritePropertyName("MasterUserOptions");
                context.Writer.WriteStartObject();

                var marshaller = MasterUserOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.MasterUserOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSAMLOptions())
            {
                context.Writer.WritePropertyName("SAMLOptions");
                context.Writer.WriteStartObject();

                var marshaller = SAMLOptionsInputMarshaller.Instance;
                marshaller.Marshall(requestObject.SAMLOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AdvancedSecurityOptionsInputMarshaller Instance = new AdvancedSecurityOptionsInputMarshaller();

    }
}