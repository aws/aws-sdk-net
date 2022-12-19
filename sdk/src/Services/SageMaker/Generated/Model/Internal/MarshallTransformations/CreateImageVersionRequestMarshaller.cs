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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateImageVersion Request Marshaller
    /// </summary>       
    public class CreateImageVersionRequestMarshaller : IMarshaller<IRequest, CreateImageVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateImageVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateImageVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.CreateImageVersion";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-24";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAliases())
                {
                    context.Writer.WritePropertyName("Aliases");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAliasesListValue in publicRequest.Aliases)
                    {
                            context.Writer.Write(publicRequestAliasesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBaseImage())
                {
                    context.Writer.WritePropertyName("BaseImage");
                    context.Writer.Write(publicRequest.BaseImage);
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
                if(publicRequest.IsSetHorovod())
                {
                    context.Writer.WritePropertyName("Horovod");
                    context.Writer.Write(publicRequest.Horovod);
                }

                if(publicRequest.IsSetImageName())
                {
                    context.Writer.WritePropertyName("ImageName");
                    context.Writer.Write(publicRequest.ImageName);
                }

                if(publicRequest.IsSetJobType())
                {
                    context.Writer.WritePropertyName("JobType");
                    context.Writer.Write(publicRequest.JobType);
                }

                if(publicRequest.IsSetMLFramework())
                {
                    context.Writer.WritePropertyName("MLFramework");
                    context.Writer.Write(publicRequest.MLFramework);
                }

                if(publicRequest.IsSetProcessor())
                {
                    context.Writer.WritePropertyName("Processor");
                    context.Writer.Write(publicRequest.Processor);
                }

                if(publicRequest.IsSetProgrammingLang())
                {
                    context.Writer.WritePropertyName("ProgrammingLang");
                    context.Writer.Write(publicRequest.ProgrammingLang);
                }

                if(publicRequest.IsSetReleaseNotes())
                {
                    context.Writer.WritePropertyName("ReleaseNotes");
                    context.Writer.Write(publicRequest.ReleaseNotes);
                }

                if(publicRequest.IsSetVendorGuidance())
                {
                    context.Writer.WritePropertyName("VendorGuidance");
                    context.Writer.Write(publicRequest.VendorGuidance);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateImageVersionRequestMarshaller _instance = new CreateImageVersionRequestMarshaller();        

        internal static CreateImageVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateImageVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}