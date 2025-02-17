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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEngagementType())
                {
                    context.Writer.WritePropertyName("engagementType");
                    context.Writer.Write(publicRequest.EngagementType);
                }

                if(publicRequest.IsSetImpactedAccounts())
                {
                    context.Writer.WritePropertyName("impactedAccounts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestImpactedAccountsListValue in publicRequest.ImpactedAccounts)
                    {
                            context.Writer.Write(publicRequestImpactedAccountsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetImpactedAwsRegions())
                {
                    context.Writer.WritePropertyName("impactedAwsRegions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestImpactedAwsRegionsListValue in publicRequest.ImpactedAwsRegions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ImpactedAwsRegionMarshaller.Instance;
                        marshaller.Marshall(publicRequestImpactedAwsRegionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetImpactedServices())
                {
                    context.Writer.WritePropertyName("impactedServices");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestImpactedServicesListValue in publicRequest.ImpactedServices)
                    {
                            context.Writer.Write(publicRequestImpactedServicesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetReportedIncidentStartDate())
                {
                    context.Writer.WritePropertyName("reportedIncidentStartDate");
                    context.Writer.Write(publicRequest.ReportedIncidentStartDate);
                }

                if(publicRequest.IsSetResolverType())
                {
                    context.Writer.WritePropertyName("resolverType");
                    context.Writer.Write(publicRequest.ResolverType);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetThreatActorIpAddresses())
                {
                    context.Writer.WritePropertyName("threatActorIpAddresses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestThreatActorIpAddressesListValue in publicRequest.ThreatActorIpAddresses)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ThreatActorIpMarshaller.Instance;
                        marshaller.Marshall(publicRequestThreatActorIpAddressesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("title");
                    context.Writer.Write(publicRequest.Title);
                }

                if(publicRequest.IsSetWatchers())
                {
                    context.Writer.WritePropertyName("watchers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestWatchersListValue in publicRequest.Watchers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = WatcherMarshaller.Instance;
                        marshaller.Marshall(publicRequestWatchersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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