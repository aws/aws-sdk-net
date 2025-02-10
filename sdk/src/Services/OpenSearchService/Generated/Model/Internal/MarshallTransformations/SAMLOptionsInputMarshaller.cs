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
    /// SAMLOptionsInput Marshaller
    /// </summary>
    public class SAMLOptionsInputMarshaller : IRequestMarshaller<SAMLOptionsInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SAMLOptionsInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetIdp())
            {
                context.Writer.WritePropertyName("Idp");
                context.Writer.WriteStartObject();

                var marshaller = SAMLIdpMarshaller.Instance;
                marshaller.Marshall(requestObject.Idp, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMasterBackendRole())
            {
                context.Writer.WritePropertyName("MasterBackendRole");
                context.Writer.WriteStringValue(requestObject.MasterBackendRole);
            }

            if(requestObject.IsSetMasterUserName())
            {
                context.Writer.WritePropertyName("MasterUserName");
                context.Writer.WriteStringValue(requestObject.MasterUserName);
            }

            if(requestObject.IsSetRolesKey())
            {
                context.Writer.WritePropertyName("RolesKey");
                context.Writer.WriteStringValue(requestObject.RolesKey);
            }

            if(requestObject.IsSetSessionTimeoutMinutes())
            {
                context.Writer.WritePropertyName("SessionTimeoutMinutes");
                context.Writer.WriteNumberValue(requestObject.SessionTimeoutMinutes.Value);
            }

            if(requestObject.IsSetSubjectKey())
            {
                context.Writer.WritePropertyName("SubjectKey");
                context.Writer.WriteStringValue(requestObject.SubjectKey);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SAMLOptionsInputMarshaller Instance = new SAMLOptionsInputMarshaller();

    }
}