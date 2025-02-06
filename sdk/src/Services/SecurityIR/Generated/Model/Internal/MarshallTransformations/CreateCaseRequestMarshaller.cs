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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityIR.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityIR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCase Request Marshaller
    /// </summary>       
    public class CreateCaseRequestMarshaller : IMarshaller<IRequest, CreateCaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityIR");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/create-case";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEngagementType())
            {
                context.Writer.WritePropertyName("engagementType");
                context.Writer.WriteStringValue(publicRequest.EngagementType);
            }

            if(publicRequest.IsSetImpactedAccounts())
            {
                context.Writer.WritePropertyName("impactedAccounts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedAccountsListValue in publicRequest.ImpactedAccounts)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedAccountsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedAwsRegions())
            {
                context.Writer.WritePropertyName("impactedAwsRegions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedAwsRegionsListValue in publicRequest.ImpactedAwsRegions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ImpactedAwsRegionMarshaller.Instance;
                    marshaller.Marshall(publicRequestImpactedAwsRegionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedServices())
            {
                context.Writer.WritePropertyName("impactedServices");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedServicesListValue in publicRequest.ImpactedServices)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedServicesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetReportedIncidentStartDate())
            {
                context.Writer.WritePropertyName("reportedIncidentStartDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ReportedIncidentStartDate.Value)));
            }

            if(publicRequest.IsSetResolverType())
            {
                context.Writer.WritePropertyName("resolverType");
                context.Writer.WriteStringValue(publicRequest.ResolverType);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetThreatActorIpAddresses())
            {
                context.Writer.WritePropertyName("threatActorIpAddresses");
                context.Writer.WriteStartArray();
                foreach(var publicRequestThreatActorIpAddressesListValue in publicRequest.ThreatActorIpAddresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ThreatActorIpMarshaller.Instance;
                    marshaller.Marshall(publicRequestThreatActorIpAddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(publicRequest.Title);
            }

            if(publicRequest.IsSetWatchers())
            {
                context.Writer.WritePropertyName("watchers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWatchersListValue in publicRequest.Watchers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WatcherMarshaller.Instance;
                    marshaller.Marshall(publicRequestWatchersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateCaseRequestMarshaller _instance = new CreateCaseRequestMarshaller();        

        internal static CreateCaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}