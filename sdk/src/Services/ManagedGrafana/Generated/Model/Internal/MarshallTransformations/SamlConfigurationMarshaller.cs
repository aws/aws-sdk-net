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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SamlConfiguration Marshaller
    /// </summary>
    public class SamlConfigurationMarshaller : IRequestMarshaller<SamlConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SamlConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowedOrganizations())
            {
                context.Writer.WritePropertyName("allowedOrganizations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedOrganizationsListValue in requestObject.AllowedOrganizations)
                {
                        context.Writer.Write(requestObjectAllowedOrganizationsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAssertionAttributes())
            {
                context.Writer.WritePropertyName("assertionAttributes");
                context.Writer.WriteObjectStart();

                var marshaller = AssertionAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.AssertionAttributes, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIdpMetadata())
            {
                context.Writer.WritePropertyName("idpMetadata");
                context.Writer.WriteObjectStart();

                var marshaller = IdpMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.IdpMetadata, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLoginValidityDuration())
            {
                context.Writer.WritePropertyName("loginValidityDuration");
                context.Writer.Write(requestObject.LoginValidityDuration);
            }

            if(requestObject.IsSetRoleValues())
            {
                context.Writer.WritePropertyName("roleValues");
                context.Writer.WriteObjectStart();

                var marshaller = RoleValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.RoleValues, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SamlConfigurationMarshaller Instance = new SamlConfigurationMarshaller();

    }
}