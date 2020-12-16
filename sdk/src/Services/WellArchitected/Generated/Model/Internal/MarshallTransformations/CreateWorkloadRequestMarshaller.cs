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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWorkload Request Marshaller
    /// </summary>       
    public class CreateWorkloadRequestMarshaller : IMarshaller<IRequest, CreateWorkloadRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateWorkloadRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateWorkloadRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/workloads";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountIds())
                {
                    context.Writer.WritePropertyName("AccountIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                    {
                            context.Writer.Write(publicRequestAccountIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetArchitecturalDesign())
                {
                    context.Writer.WritePropertyName("ArchitecturalDesign");
                    context.Writer.Write(publicRequest.ArchitecturalDesign);
                }

                if(publicRequest.IsSetAwsRegions())
                {
                    context.Writer.WritePropertyName("AwsRegions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAwsRegionsListValue in publicRequest.AwsRegions)
                    {
                            context.Writer.Write(publicRequestAwsRegionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEnvironment())
                {
                    context.Writer.WritePropertyName("Environment");
                    context.Writer.Write(publicRequest.Environment);
                }

                if(publicRequest.IsSetIndustry())
                {
                    context.Writer.WritePropertyName("Industry");
                    context.Writer.Write(publicRequest.Industry);
                }

                if(publicRequest.IsSetIndustryType())
                {
                    context.Writer.WritePropertyName("IndustryType");
                    context.Writer.Write(publicRequest.IndustryType);
                }

                if(publicRequest.IsSetLenses())
                {
                    context.Writer.WritePropertyName("Lenses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLensesListValue in publicRequest.Lenses)
                    {
                            context.Writer.Write(publicRequestLensesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNonAwsRegions())
                {
                    context.Writer.WritePropertyName("NonAwsRegions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNonAwsRegionsListValue in publicRequest.NonAwsRegions)
                    {
                            context.Writer.Write(publicRequestNonAwsRegionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNotes())
                {
                    context.Writer.WritePropertyName("Notes");
                    context.Writer.Write(publicRequest.Notes);
                }

                if(publicRequest.IsSetPillarPriorities())
                {
                    context.Writer.WritePropertyName("PillarPriorities");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPillarPrioritiesListValue in publicRequest.PillarPriorities)
                    {
                            context.Writer.Write(publicRequestPillarPrioritiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetReviewOwner())
                {
                    context.Writer.WritePropertyName("ReviewOwner");
                    context.Writer.Write(publicRequest.ReviewOwner);
                }

                if(publicRequest.IsSetWorkloadName())
                {
                    context.Writer.WritePropertyName("WorkloadName");
                    context.Writer.Write(publicRequest.WorkloadName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateWorkloadRequestMarshaller _instance = new CreateWorkloadRequestMarshaller();        

        internal static CreateWorkloadRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateWorkloadRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}