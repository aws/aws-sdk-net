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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.PartnerCentralBenefits.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralBenefits.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBenefitApplication Request Marshaller
    /// </summary>
    public partial class UpdateBenefitApplicationRequestMarshaller : IMarshaller<IRequest, UpdateBenefitApplicationRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBenefitApplicationRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateBenefitApplicationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralBenefits");
            string target = "PartnerCentralBenefitsService.UpdateBenefitApplication";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetBenefitApplicationDetails())
            {
                context.Writer.WritePropertyName("BenefitApplicationDetails");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequest.BenefitApplicationDetails);
            }
            if (publicRequest.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStringValue(publicRequest.Catalog);
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetFileDetails())
            {
                context.Writer.WritePropertyName("FileDetails");
                context.Writer.WriteStartArray();
                foreach (var publicRequestFileDetailsListValue in publicRequest.FileDetails)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FileInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestFileDetailsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetIdentifier())
            {
                context.Writer.WritePropertyName("Identifier");
                context.Writer.WriteStringValue(publicRequest.Identifier);
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetPartnerContacts())
            {
                context.Writer.WritePropertyName("PartnerContacts");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPartnerContactsListValue in publicRequest.PartnerContacts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ContactMarshaller.Instance;
                    marshaller.Marshall(publicRequestPartnerContactsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetRevision())
            {
                context.Writer.WritePropertyName("Revision");
                context.Writer.WriteStringValue(publicRequest.Revision);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateBenefitApplicationRequestMarshaller _instance = new();

        internal static UpdateBenefitApplicationRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateBenefitApplicationRequestMarshaller Instance => _instance;
    }
}
