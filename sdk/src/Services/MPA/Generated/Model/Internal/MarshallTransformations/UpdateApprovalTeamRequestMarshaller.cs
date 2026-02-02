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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MPA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MPA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateApprovalTeam Request Marshaller
    /// </summary>       
    public class UpdateApprovalTeamRequestMarshaller : IMarshaller<IRequest, UpdateApprovalTeamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApprovalTeamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApprovalTeamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MPA");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-26";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetArn())
                throw new AmazonMPAException("Request object does not have required field Arn set");
            request.AddPathResource("{Arn}", StringUtils.FromString(publicRequest.Arn));
            request.ResourcePath = "/approval-teams/{Arn}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApprovalStrategy())
                {
                    context.Writer.WritePropertyName("ApprovalStrategy");
                    context.Writer.WriteObjectStart();

                    var marshaller = ApprovalStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApprovalStrategy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApprovers())
                {
                    context.Writer.WritePropertyName("Approvers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestApproversListValue in publicRequest.Approvers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ApprovalTeamRequestApproverMarshaller.Instance;
                        marshaller.Marshall(publicRequestApproversListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetUpdateActions())
                {
                    context.Writer.WritePropertyName("UpdateActions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUpdateActionsListValue in publicRequest.UpdateActions)
                    {
                            context.Writer.Write(publicRequestUpdateActionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateApprovalTeamRequestMarshaller _instance = new UpdateApprovalTeamRequestMarshaller();        

        internal static UpdateApprovalTeamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApprovalTeamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}