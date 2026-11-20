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

using Amazon.PartnerCentralChannel.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ManagedServicesAttestationPayload Marshaller
    /// </summary>
    public partial class ManagedServicesAttestationPayloadMarshaller : IRequestMarshaller<ManagedServicesAttestationPayload, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ManagedServicesAttestationPayload requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetEndDate())
            {
                context.Writer.WritePropertyName("endDate");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.EndDate));
            }

            if (requestObject.IsSetLegalEntityAddress())
            {
                context.Writer.WritePropertyName("legalEntityAddress");
                context.Writer.WriteStartObject();

                var marshaller = AddressMarshaller.Instance;
                marshaller.Marshall(requestObject.LegalEntityAddress, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetLegalEntityName())
            {
                context.Writer.WritePropertyName("legalEntityName");
                context.Writer.WriteStringValue(requestObject.LegalEntityName);
            }

            if (requestObject.IsSetMemberAccountIds())
            {
                context.Writer.WritePropertyName("memberAccountIds");
                context.Writer.WriteStartArray();
                foreach (var requestObjectMemberAccountIdsListValue in requestObject.MemberAccountIds)
                {
                    context.Writer.WriteStringValue(requestObjectMemberAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetProgramManagementAccountIdentifier())
            {
                context.Writer.WritePropertyName("programManagementAccountIdentifier");
                context.Writer.WriteStringValue(requestObject.ProgramManagementAccountIdentifier);
            }

            if (requestObject.IsSetRelationshipIdentifier())
            {
                context.Writer.WritePropertyName("relationshipIdentifier");
                context.Writer.WriteStringValue(requestObject.RelationshipIdentifier);
            }

            if (requestObject.IsSetSignatoryEmail())
            {
                context.Writer.WritePropertyName("signatoryEmail");
                context.Writer.WriteStringValue(requestObject.SignatoryEmail);
            }

            if (requestObject.IsSetSignatoryName())
            {
                context.Writer.WritePropertyName("signatoryName");
                context.Writer.WriteStringValue(requestObject.SignatoryName);
            }

            if (requestObject.IsSetSupportedServices())
            {
                context.Writer.WritePropertyName("supportedServices");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSupportedServicesListValue in requestObject.SupportedServices)
                {
                    context.Writer.WriteStringValue(requestObjectSupportedServicesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ManagedServicesAttestationPayloadMarshaller Instance = new ManagedServicesAttestationPayloadMarshaller();
    }
}
