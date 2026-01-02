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

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMembership Request Marshaller
    /// </summary>       
    public class CreateMembershipRequestMarshaller : IMarshaller<IRequest, CreateMembershipRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMembershipRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMembershipRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CleanRooms");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/memberships";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCollaborationIdentifier())
                {
                    context.Writer.WritePropertyName("collaborationIdentifier");
                    context.Writer.Write(publicRequest.CollaborationIdentifier);
                }

                if(publicRequest.IsSetDefaultJobResultConfiguration())
                {
                    context.Writer.WritePropertyName("defaultJobResultConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MembershipProtectedJobResultConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultJobResultConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultResultConfiguration())
                {
                    context.Writer.WritePropertyName("defaultResultConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MembershipProtectedQueryResultConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultResultConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetIsMetricsEnabled())
                {
                    context.Writer.WritePropertyName("isMetricsEnabled");
                    context.Writer.Write(publicRequest.IsMetricsEnabled);
                }

                if(publicRequest.IsSetJobLogStatus())
                {
                    context.Writer.WritePropertyName("jobLogStatus");
                    context.Writer.Write(publicRequest.JobLogStatus);
                }

                if(publicRequest.IsSetPaymentConfiguration())
                {
                    context.Writer.WritePropertyName("paymentConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MembershipPaymentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PaymentConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetQueryLogStatus())
                {
                    context.Writer.WritePropertyName("queryLogStatus");
                    context.Writer.Write(publicRequest.QueryLogStatus);
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateMembershipRequestMarshaller _instance = new CreateMembershipRequestMarshaller();        

        internal static CreateMembershipRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMembershipRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}