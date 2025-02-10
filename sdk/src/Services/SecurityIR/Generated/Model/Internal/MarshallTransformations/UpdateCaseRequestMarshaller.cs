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
    /// UpdateCase Request Marshaller
    /// </summary>       
    public class UpdateCaseRequestMarshaller : IMarshaller<IRequest, UpdateCaseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCaseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCaseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityIR");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCaseId())
                throw new AmazonSecurityIRException("Request object does not have required field CaseId set");
            request.AddPathResource("{caseId}", StringUtils.FromString(publicRequest.CaseId));
            request.ResourcePath = "/v1/cases/{caseId}/update-case";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActualIncidentStartDate())
            {
                context.Writer.WritePropertyName("actualIncidentStartDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ActualIncidentStartDate.Value)));
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

            if(publicRequest.IsSetImpactedAccountsToAdd())
            {
                context.Writer.WritePropertyName("impactedAccountsToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedAccountsToAddListValue in publicRequest.ImpactedAccountsToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedAccountsToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedAccountsToDelete())
            {
                context.Writer.WritePropertyName("impactedAccountsToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedAccountsToDeleteListValue in publicRequest.ImpactedAccountsToDelete)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedAccountsToDeleteListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedAwsRegionsToAdd())
            {
                context.Writer.WritePropertyName("impactedAwsRegionsToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedAwsRegionsToAddListValue in publicRequest.ImpactedAwsRegionsToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ImpactedAwsRegionMarshaller.Instance;
                    marshaller.Marshall(publicRequestImpactedAwsRegionsToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedAwsRegionsToDelete())
            {
                context.Writer.WritePropertyName("impactedAwsRegionsToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedAwsRegionsToDeleteListValue in publicRequest.ImpactedAwsRegionsToDelete)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ImpactedAwsRegionMarshaller.Instance;
                    marshaller.Marshall(publicRequestImpactedAwsRegionsToDeleteListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedServicesToAdd())
            {
                context.Writer.WritePropertyName("impactedServicesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedServicesToAddListValue in publicRequest.ImpactedServicesToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedServicesToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImpactedServicesToDelete())
            {
                context.Writer.WritePropertyName("impactedServicesToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpactedServicesToDeleteListValue in publicRequest.ImpactedServicesToDelete)
                {
                        context.Writer.WriteStringValue(publicRequestImpactedServicesToDeleteListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetReportedIncidentStartDate())
            {
                context.Writer.WritePropertyName("reportedIncidentStartDate");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ReportedIncidentStartDate.Value)));
            }

            if(publicRequest.IsSetThreatActorIpAddressesToAdd())
            {
                context.Writer.WritePropertyName("threatActorIpAddressesToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestThreatActorIpAddressesToAddListValue in publicRequest.ThreatActorIpAddressesToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ThreatActorIpMarshaller.Instance;
                    marshaller.Marshall(publicRequestThreatActorIpAddressesToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetThreatActorIpAddressesToDelete())
            {
                context.Writer.WritePropertyName("threatActorIpAddressesToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestThreatActorIpAddressesToDeleteListValue in publicRequest.ThreatActorIpAddressesToDelete)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ThreatActorIpMarshaller.Instance;
                    marshaller.Marshall(publicRequestThreatActorIpAddressesToDeleteListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(publicRequest.Title);
            }

            if(publicRequest.IsSetWatchersToAdd())
            {
                context.Writer.WritePropertyName("watchersToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWatchersToAddListValue in publicRequest.WatchersToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WatcherMarshaller.Instance;
                    marshaller.Marshall(publicRequestWatchersToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWatchersToDelete())
            {
                context.Writer.WritePropertyName("watchersToDelete");
                context.Writer.WriteStartArray();
                foreach(var publicRequestWatchersToDeleteListValue in publicRequest.WatchersToDelete)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WatcherMarshaller.Instance;
                    marshaller.Marshall(publicRequestWatchersToDeleteListValue, context);

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
        private static UpdateCaseRequestMarshaller _instance = new UpdateCaseRequestMarshaller();        

        internal static UpdateCaseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCaseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}