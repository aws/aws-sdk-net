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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutJobSuccessResult Request Marshaller
    /// </summary>       
    public class PutJobSuccessResultRequestMarshaller : IMarshaller<IRequest, PutJobSuccessResultRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutJobSuccessResultRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutJobSuccessResultRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodePipeline");
            string target = "CodePipeline_20150709.PutJobSuccessResult";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContinuationToken())
                {
                    context.Writer.WritePropertyName("continuationToken");
                    context.Writer.Write(publicRequest.ContinuationToken);
                }

                if(publicRequest.IsSetCurrentRevision())
                {
                    context.Writer.WritePropertyName("currentRevision");
                    context.Writer.WriteObjectStart();

                    var marshaller = CurrentRevisionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CurrentRevision, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExecutionDetails())
                {
                    context.Writer.WritePropertyName("executionDetails");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExecutionDetailsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExecutionDetails, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobId())
                {
                    context.Writer.WritePropertyName("jobId");
                    context.Writer.Write(publicRequest.JobId);
                }

                if(publicRequest.IsSetOutputVariables())
                {
                    context.Writer.WritePropertyName("outputVariables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestOutputVariablesKvp in publicRequest.OutputVariables)
                    {
                        context.Writer.WritePropertyName(publicRequestOutputVariablesKvp.Key);
                        var publicRequestOutputVariablesValue = publicRequestOutputVariablesKvp.Value;

                            context.Writer.Write(publicRequestOutputVariablesValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutJobSuccessResultRequestMarshaller _instance = new PutJobSuccessResultRequestMarshaller();        

        internal static PutJobSuccessResultRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutJobSuccessResultRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}