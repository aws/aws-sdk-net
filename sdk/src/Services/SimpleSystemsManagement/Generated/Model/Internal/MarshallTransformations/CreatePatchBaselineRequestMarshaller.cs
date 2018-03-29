/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePatchBaseline Request Marshaller
    /// </summary>       
    public class CreatePatchBaselineRequestMarshaller : IMarshaller<IRequest, CreatePatchBaselineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePatchBaselineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePatchBaselineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.CreatePatchBaseline";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApprovalRules())
                {
                    context.Writer.WritePropertyName("ApprovalRules");
                    context.Writer.WriteObjectStart();

                    var marshaller = PatchRuleGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ApprovalRules, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetApprovedPatches())
                {
                    context.Writer.WritePropertyName("ApprovedPatches");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestApprovedPatchesListValue in publicRequest.ApprovedPatches)
                    {
                            context.Writer.Write(publicRequestApprovedPatchesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetApprovedPatchesComplianceLevel())
                {
                    context.Writer.WritePropertyName("ApprovedPatchesComplianceLevel");
                    context.Writer.Write(publicRequest.ApprovedPatchesComplianceLevel);
                }

                if(publicRequest.IsSetApprovedPatchesEnableNonSecurity())
                {
                    context.Writer.WritePropertyName("ApprovedPatchesEnableNonSecurity");
                    context.Writer.Write(publicRequest.ApprovedPatchesEnableNonSecurity);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetGlobalFilters())
                {
                    context.Writer.WritePropertyName("GlobalFilters");
                    context.Writer.WriteObjectStart();

                    var marshaller = PatchFilterGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GlobalFilters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOperatingSystem())
                {
                    context.Writer.WritePropertyName("OperatingSystem");
                    context.Writer.Write(publicRequest.OperatingSystem);
                }

                if(publicRequest.IsSetRejectedPatches())
                {
                    context.Writer.WritePropertyName("RejectedPatches");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRejectedPatchesListValue in publicRequest.RejectedPatches)
                    {
                            context.Writer.Write(publicRequestRejectedPatchesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSources())
                {
                    context.Writer.WritePropertyName("Sources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PatchSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourcesListValue, context);

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
        private static CreatePatchBaselineRequestMarshaller _instance = new CreatePatchBaselineRequestMarshaller();        

        internal static CreatePatchBaselineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePatchBaselineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}