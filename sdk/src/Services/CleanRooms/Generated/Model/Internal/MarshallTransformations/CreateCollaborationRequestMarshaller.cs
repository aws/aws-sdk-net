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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCollaboration Request Marshaller
    /// </summary>       
    public class CreateCollaborationRequestMarshaller : IMarshaller<IRequest, CreateCollaborationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCollaborationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCollaborationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/collaborations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCreatorDisplayName())
                {
                    context.Writer.WritePropertyName("creatorDisplayName");
                    context.Writer.Write(publicRequest.CreatorDisplayName);
                }

                if(publicRequest.IsSetCreatorMemberAbilities())
                {
                    context.Writer.WritePropertyName("creatorMemberAbilities");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCreatorMemberAbilitiesListValue in publicRequest.CreatorMemberAbilities)
                    {
                            context.Writer.Write(publicRequestCreatorMemberAbilitiesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDataEncryptionMetadata())
                {
                    context.Writer.WritePropertyName("dataEncryptionMetadata");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataEncryptionMetadataMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataEncryptionMetadata, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetMembers())
                {
                    context.Writer.WritePropertyName("members");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMembersListValue in publicRequest.Members)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MemberSpecificationMarshaller.Instance;
                        marshaller.Marshall(publicRequestMembersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetQueryLogStatus())
                {
                    context.Writer.WritePropertyName("queryLogStatus");
                    context.Writer.Write(publicRequest.QueryLogStatus);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCollaborationRequestMarshaller _instance = new CreateCollaborationRequestMarshaller();        

        internal static CreateCollaborationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCollaborationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}