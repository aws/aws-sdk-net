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
    /// UpdateImageVersion Request Marshaller
    /// </summary>       
    public class UpdateImageVersionRequestMarshaller : IMarshaller<IRequest, UpdateImageVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateImageVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateImageVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMaker");
            string target = "SageMaker.UpdateImageVersion";
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
                if(publicRequest.IsSetAlias())
                {
                    context.Writer.WritePropertyName("Alias");
                    context.Writer.Write(publicRequest.Alias);
                }

                if(publicRequest.IsSetAliasesToAdd())
                {
                    context.Writer.WritePropertyName("AliasesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAliasesToAddListValue in publicRequest.AliasesToAdd)
                    {
                            context.Writer.Write(publicRequestAliasesToAddListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAliasesToDelete())
                {
                    context.Writer.WritePropertyName("AliasesToDelete");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAliasesToDeleteListValue in publicRequest.AliasesToDelete)
                    {
                            context.Writer.Write(publicRequestAliasesToDeleteListValue);
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetVersion())
                {
                    context.Writer.WritePropertyName("Version");
                    context.Writer.Write(publicRequest.Version);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateImageVersionRequestMarshaller _instance = new UpdateImageVersionRequestMarshaller();        

        internal static UpdateImageVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateImageVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}