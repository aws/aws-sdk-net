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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProjectVersion Request Marshaller
    /// </summary>       
    public class CreateProjectVersionRequestMarshaller : IMarshaller<IRequest, CreateProjectVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProjectVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProjectVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.CreateProjectVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetOutputConfig())
                {
                    context.Writer.WritePropertyName("OutputConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProjectArn())
                {
                    context.Writer.WritePropertyName("ProjectArn");
                    context.Writer.Write(publicRequest.ProjectArn);
                }

                if(publicRequest.IsSetTestingData())
                {
                    context.Writer.WritePropertyName("TestingData");
                    context.Writer.WriteObjectStart();

                    var marshaller = TestingDataMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TestingData, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTrainingData())
                {
                    context.Writer.WritePropertyName("TrainingData");
                    context.Writer.WriteObjectStart();

                    var marshaller = TrainingDataMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TrainingData, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVersionName())
                {
                    context.Writer.WritePropertyName("VersionName");
                    context.Writer.Write(publicRequest.VersionName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateProjectVersionRequestMarshaller _instance = new CreateProjectVersionRequestMarshaller();        

        internal static CreateProjectVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProjectVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}