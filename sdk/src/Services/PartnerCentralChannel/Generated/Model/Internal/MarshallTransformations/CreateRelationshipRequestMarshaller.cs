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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralChannel.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRelationship Request Marshaller
    /// </summary>       
    public class CreateRelationshipRequestMarshaller : IMarshaller<IRequest, CreateRelationshipRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRelationshipRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRelationshipRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PartnerCentralChannel");
            string target = "PartnerCentralChannel.CreateRelationship";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-03-18";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociatedAccountId())
                {
                    context.Writer.WritePropertyName("associatedAccountId");
                    context.Writer.Write(publicRequest.AssociatedAccountId);
                }

                if(publicRequest.IsSetAssociationType())
                {
                    context.Writer.WritePropertyName("associationType");
                    context.Writer.Write(publicRequest.AssociationType);
                }

                if(publicRequest.IsSetCatalog())
                {
                    context.Writer.WritePropertyName("catalog");
                    context.Writer.Write(publicRequest.Catalog);
                }

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
                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetProgramManagementAccountIdentifier())
                {
                    context.Writer.WritePropertyName("programManagementAccountIdentifier");
                    context.Writer.Write(publicRequest.ProgramManagementAccountIdentifier);
                }

                if(publicRequest.IsSetRequestedSupportPlan())
                {
                    context.Writer.WritePropertyName("requestedSupportPlan");
                    context.Writer.WriteObjectStart();

                    var marshaller = SupportPlanMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RequestedSupportPlan, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResaleAccountModel())
                {
                    context.Writer.WritePropertyName("resaleAccountModel");
                    context.Writer.Write(publicRequest.ResaleAccountModel);
                }

                if(publicRequest.IsSetSector())
                {
                    context.Writer.WritePropertyName("sector");
                    context.Writer.Write(publicRequest.Sector);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateRelationshipRequestMarshaller _instance = new CreateRelationshipRequestMarshaller();        

        internal static CreateRelationshipRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRelationshipRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}