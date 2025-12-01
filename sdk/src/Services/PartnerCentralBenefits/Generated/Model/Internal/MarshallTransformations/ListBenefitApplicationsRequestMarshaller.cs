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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralBenefits.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralBenefits.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListBenefitApplications Request Marshaller
    /// </summary>       
    public class ListBenefitApplicationsRequestMarshaller : IMarshaller<IRequest, ListBenefitApplicationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListBenefitApplicationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListBenefitApplicationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralBenefits");
            string target = "PartnerCentralBenefitsService.ListBenefitApplications";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociatedResourceArns())
                {
                    context.Writer.WritePropertyName("AssociatedResourceArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssociatedResourceArnsListValue in publicRequest.AssociatedResourceArns)
                    {
                            context.Writer.Write(publicRequestAssociatedResourceArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAssociatedResources())
                {
                    context.Writer.WritePropertyName("AssociatedResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAssociatedResourcesListValue in publicRequest.AssociatedResources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AssociatedResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestAssociatedResourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBenefitIdentifiers())
                {
                    context.Writer.WritePropertyName("BenefitIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBenefitIdentifiersListValue in publicRequest.BenefitIdentifiers)
                    {
                            context.Writer.Write(publicRequestBenefitIdentifiersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCatalog())
                {
                    context.Writer.WritePropertyName("Catalog");
                    context.Writer.Write(publicRequest.Catalog);
                }

                if(publicRequest.IsSetFulfillmentTypes())
                {
                    context.Writer.WritePropertyName("FulfillmentTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFulfillmentTypesListValue in publicRequest.FulfillmentTypes)
                    {
                            context.Writer.Write(publicRequestFulfillmentTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("MaxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("NextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPrograms())
                {
                    context.Writer.WritePropertyName("Programs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestProgramsListValue in publicRequest.Programs)
                    {
                            context.Writer.Write(publicRequestProgramsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStages())
                {
                    context.Writer.WritePropertyName("Stages");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStagesListValue in publicRequest.Stages)
                    {
                            context.Writer.Write(publicRequestStagesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("Status");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStatusListValue in publicRequest.Status)
                    {
                            context.Writer.Write(publicRequestStatusListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListBenefitApplicationsRequestMarshaller _instance = new ListBenefitApplicationsRequestMarshaller();        

        internal static ListBenefitApplicationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListBenefitApplicationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}