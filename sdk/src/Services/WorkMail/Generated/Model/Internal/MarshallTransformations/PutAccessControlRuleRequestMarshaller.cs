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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAccessControlRule Request Marshaller
    /// </summary>       
    public class PutAccessControlRuleRequestMarshaller : IMarshaller<IRequest, PutAccessControlRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAccessControlRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAccessControlRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkMail");
            string target = "WorkMailService.PutAccessControlRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActions())
                {
                    context.Writer.WritePropertyName("Actions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestActionsListValue in publicRequest.Actions)
                    {
                            context.Writer.Write(publicRequestActionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEffect())
                {
                    context.Writer.WritePropertyName("Effect");
                    context.Writer.Write(publicRequest.Effect);
                }

                if(publicRequest.IsSetImpersonationRoleIds())
                {
                    context.Writer.WritePropertyName("ImpersonationRoleIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestImpersonationRoleIdsListValue in publicRequest.ImpersonationRoleIds)
                    {
                            context.Writer.Write(publicRequestImpersonationRoleIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIpRanges())
                {
                    context.Writer.WritePropertyName("IpRanges");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestIpRangesListValue in publicRequest.IpRanges)
                    {
                            context.Writer.Write(publicRequestIpRangesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNotActions())
                {
                    context.Writer.WritePropertyName("NotActions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotActionsListValue in publicRequest.NotActions)
                    {
                            context.Writer.Write(publicRequestNotActionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNotImpersonationRoleIds())
                {
                    context.Writer.WritePropertyName("NotImpersonationRoleIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotImpersonationRoleIdsListValue in publicRequest.NotImpersonationRoleIds)
                    {
                            context.Writer.Write(publicRequestNotImpersonationRoleIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNotIpRanges())
                {
                    context.Writer.WritePropertyName("NotIpRanges");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotIpRangesListValue in publicRequest.NotIpRanges)
                    {
                            context.Writer.Write(publicRequestNotIpRangesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNotUserIds())
                {
                    context.Writer.WritePropertyName("NotUserIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNotUserIdsListValue in publicRequest.NotUserIds)
                    {
                            context.Writer.Write(publicRequestNotUserIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOrganizationId())
                {
                    context.Writer.WritePropertyName("OrganizationId");
                    context.Writer.Write(publicRequest.OrganizationId);
                }

                if(publicRequest.IsSetUserIds())
                {
                    context.Writer.WritePropertyName("UserIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserIdsListValue in publicRequest.UserIds)
                    {
                            context.Writer.Write(publicRequestUserIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutAccessControlRuleRequestMarshaller _instance = new PutAccessControlRuleRequestMarshaller();        

        internal static PutAccessControlRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAccessControlRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}