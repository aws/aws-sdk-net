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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAssessmentTemplate Request Marshaller
    /// </summary>       
    public class CreateAssessmentTemplateRequestMarshaller : IMarshaller<IRequest, CreateAssessmentTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAssessmentTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAssessmentTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Inspector");
            string target = "InspectorService.CreateAssessmentTemplate";
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
                if(publicRequest.IsSetAssessmentTargetArn())
                {
                    context.Writer.WritePropertyName("assessmentTargetArn");
                    context.Writer.Write(publicRequest.AssessmentTargetArn);
                }

                if(publicRequest.IsSetAssessmentTemplateName())
                {
                    context.Writer.WritePropertyName("assessmentTemplateName");
                    context.Writer.Write(publicRequest.AssessmentTemplateName);
                }

                if(publicRequest.IsSetDurationInSeconds())
                {
                    context.Writer.WritePropertyName("durationInSeconds");
                    context.Writer.Write(publicRequest.DurationInSeconds);
                }

                if(publicRequest.IsSetRulesPackageArns())
                {
                    context.Writer.WritePropertyName("rulesPackageArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRulesPackageArnsListValue in publicRequest.RulesPackageArns)
                    {
                            context.Writer.Write(publicRequestRulesPackageArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserAttributesForFindings())
                {
                    context.Writer.WritePropertyName("userAttributesForFindings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserAttributesForFindingsListValue in publicRequest.UserAttributesForFindings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AttributeMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserAttributesForFindingsListValue, context);

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
        private static CreateAssessmentTemplateRequestMarshaller _instance = new CreateAssessmentTemplateRequestMarshaller();        

        internal static CreateAssessmentTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssessmentTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}