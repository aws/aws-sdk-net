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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AuditManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateControl Request Marshaller
    /// </summary>       
    public class UpdateControlRequestMarshaller : IMarshaller<IRequest, UpdateControlRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateControlRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateControlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetControlId())
                throw new AmazonAuditManagerException("Request object does not have required field ControlId set");
            request.AddPathResource("{controlId}", StringUtils.FromString(publicRequest.ControlId));
            request.ResourcePath = "/controls/{controlId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionPlanInstructions())
                {
                    context.Writer.WritePropertyName("actionPlanInstructions");
                    context.Writer.Write(publicRequest.ActionPlanInstructions);
                }

                if(publicRequest.IsSetActionPlanTitle())
                {
                    context.Writer.WritePropertyName("actionPlanTitle");
                    context.Writer.Write(publicRequest.ActionPlanTitle);
                }

                if(publicRequest.IsSetControlMappingSources())
                {
                    context.Writer.WritePropertyName("controlMappingSources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestControlMappingSourcesListValue in publicRequest.ControlMappingSources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ControlMappingSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestControlMappingSourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetTestingInformation())
                {
                    context.Writer.WritePropertyName("testingInformation");
                    context.Writer.Write(publicRequest.TestingInformation);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateControlRequestMarshaller _instance = new UpdateControlRequestMarshaller();        

        internal static UpdateControlRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateControlRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}