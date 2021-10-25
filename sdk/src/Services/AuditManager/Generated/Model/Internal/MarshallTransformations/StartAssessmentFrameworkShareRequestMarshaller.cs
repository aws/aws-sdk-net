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
    /// StartAssessmentFrameworkShare Request Marshaller
    /// </summary>       
    public class StartAssessmentFrameworkShareRequestMarshaller : IMarshaller<IRequest, StartAssessmentFrameworkShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAssessmentFrameworkShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartAssessmentFrameworkShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetFrameworkId())
                throw new AmazonAuditManagerException("Request object does not have required field FrameworkId set");
            request.AddPathResource("{frameworkId}", StringUtils.FromString(publicRequest.FrameworkId));
            request.ResourcePath = "/assessmentFrameworks/{frameworkId}/shareRequests";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComment())
                {
                    context.Writer.WritePropertyName("comment");
                    context.Writer.Write(publicRequest.Comment);
                }

                if(publicRequest.IsSetDestinationAccount())
                {
                    context.Writer.WritePropertyName("destinationAccount");
                    context.Writer.Write(publicRequest.DestinationAccount);
                }

                if(publicRequest.IsSetDestinationRegion())
                {
                    context.Writer.WritePropertyName("destinationRegion");
                    context.Writer.Write(publicRequest.DestinationRegion);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartAssessmentFrameworkShareRequestMarshaller _instance = new StartAssessmentFrameworkShareRequestMarshaller();        

        internal static StartAssessmentFrameworkShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartAssessmentFrameworkShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}