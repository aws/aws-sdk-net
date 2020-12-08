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
    /// BatchImportEvidenceToAssessmentControl Request Marshaller
    /// </summary>       
    public class BatchImportEvidenceToAssessmentControlRequestMarshaller : IMarshaller<IRequest, BatchImportEvidenceToAssessmentControlRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchImportEvidenceToAssessmentControlRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchImportEvidenceToAssessmentControlRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAssessmentId())
                throw new AmazonAuditManagerException("Request object does not have required field AssessmentId set");
            request.AddPathResource("{assessmentId}", StringUtils.FromString(publicRequest.AssessmentId));
            if (!publicRequest.IsSetControlId())
                throw new AmazonAuditManagerException("Request object does not have required field ControlId set");
            request.AddPathResource("{controlId}", StringUtils.FromString(publicRequest.ControlId));
            if (!publicRequest.IsSetControlSetId())
                throw new AmazonAuditManagerException("Request object does not have required field ControlSetId set");
            request.AddPathResource("{controlSetId}", StringUtils.FromString(publicRequest.ControlSetId));
            request.ResourcePath = "/assessments/{assessmentId}/controlSets/{controlSetId}/controls/{controlId}/evidence";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetManualEvidence())
                {
                    context.Writer.WritePropertyName("manualEvidence");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestManualEvidenceListValue in publicRequest.ManualEvidence)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ManualEvidenceMarshaller.Instance;
                        marshaller.Marshall(publicRequestManualEvidenceListValue, context);

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
        private static BatchImportEvidenceToAssessmentControlRequestMarshaller _instance = new BatchImportEvidenceToAssessmentControlRequestMarshaller();        

        internal static BatchImportEvidenceToAssessmentControlRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchImportEvidenceToAssessmentControlRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}