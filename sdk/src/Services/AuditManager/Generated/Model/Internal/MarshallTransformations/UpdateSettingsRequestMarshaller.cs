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
    /// UpdateSettings Request Marshaller
    /// </summary>       
    public class UpdateSettingsRequestMarshaller : IMarshaller<IRequest, UpdateSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/settings";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefaultAssessmentReportsDestination())
                {
                    context.Writer.WritePropertyName("defaultAssessmentReportsDestination");
                    context.Writer.WriteObjectStart();

                    var marshaller = AssessmentReportsDestinationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefaultAssessmentReportsDestination, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultProcessOwners())
                {
                    context.Writer.WritePropertyName("defaultProcessOwners");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDefaultProcessOwnersListValue in publicRequest.DefaultProcessOwners)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RoleMarshaller.Instance;
                        marshaller.Marshall(publicRequestDefaultProcessOwnersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDeregistrationPolicy())
                {
                    context.Writer.WritePropertyName("deregistrationPolicy");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeregistrationPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeregistrationPolicy, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEvidenceFinderEnabled())
                {
                    context.Writer.WritePropertyName("evidenceFinderEnabled");
                    context.Writer.Write(publicRequest.EvidenceFinderEnabled);
                }

                if(publicRequest.IsSetKmsKey())
                {
                    context.Writer.WritePropertyName("kmsKey");
                    context.Writer.Write(publicRequest.KmsKey);
                }

                if(publicRequest.IsSetSnsTopic())
                {
                    context.Writer.WritePropertyName("snsTopic");
                    context.Writer.Write(publicRequest.SnsTopic);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSettingsRequestMarshaller _instance = new UpdateSettingsRequestMarshaller();        

        internal static UpdateSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}