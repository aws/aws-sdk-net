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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDetectorVersion Request Marshaller
    /// </summary>       
    public class UpdateDetectorVersionRequestMarshaller : IMarshaller<IRequest, UpdateDetectorVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDetectorVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDetectorVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FraudDetector");
            string target = "AWSHawksNestServiceFacade.UpdateDetectorVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-15";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDetectorId())
                {
                    context.Writer.WritePropertyName("detectorId");
                    context.Writer.Write(publicRequest.DetectorId);
                }

                if(publicRequest.IsSetDetectorVersionId())
                {
                    context.Writer.WritePropertyName("detectorVersionId");
                    context.Writer.Write(publicRequest.DetectorVersionId);
                }

                if(publicRequest.IsSetExternalModelEndpoints())
                {
                    context.Writer.WritePropertyName("externalModelEndpoints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestExternalModelEndpointsListValue in publicRequest.ExternalModelEndpoints)
                    {
                            context.Writer.Write(publicRequestExternalModelEndpointsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetModelVersions())
                {
                    context.Writer.WritePropertyName("modelVersions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestModelVersionsListValue in publicRequest.ModelVersions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ModelVersionMarshaller.Instance;
                        marshaller.Marshall(publicRequestModelVersionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRuleExecutionMode())
                {
                    context.Writer.WritePropertyName("ruleExecutionMode");
                    context.Writer.Write(publicRequest.RuleExecutionMode);
                }

                if(publicRequest.IsSetRules())
                {
                    context.Writer.WritePropertyName("rules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRulesListValue in publicRequest.Rules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestRulesListValue, context);

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
        private static UpdateDetectorVersionRequestMarshaller _instance = new UpdateDetectorVersionRequestMarshaller();        

        internal static UpdateDetectorVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDetectorVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}