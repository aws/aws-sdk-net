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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBulkImportJob Request Marshaller
    /// </summary>       
    public class CreateBulkImportJobRequestMarshaller : IMarshaller<IRequest, CreateBulkImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBulkImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBulkImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "POST";

            request.ResourcePath = "/jobs";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdaptiveIngestion())
                {
                    context.Writer.WritePropertyName("adaptiveIngestion");
                    context.Writer.Write(publicRequest.AdaptiveIngestion);
                }

                if(publicRequest.IsSetDeleteFilesAfterImport())
                {
                    context.Writer.WritePropertyName("deleteFilesAfterImport");
                    context.Writer.Write(publicRequest.DeleteFilesAfterImport);
                }

                if(publicRequest.IsSetErrorReportLocation())
                {
                    context.Writer.WritePropertyName("errorReportLocation");
                    context.Writer.WriteObjectStart();

                    var marshaller = ErrorReportLocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ErrorReportLocation, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFiles())
                {
                    context.Writer.WritePropertyName("files");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFilesListValue in publicRequest.Files)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FileMarshaller.Instance;
                        marshaller.Marshall(publicRequestFilesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetJobConfiguration())
                {
                    context.Writer.WritePropertyName("jobConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.JobConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobName())
                {
                    context.Writer.WritePropertyName("jobName");
                    context.Writer.Write(publicRequest.JobName);
                }

                if(publicRequest.IsSetJobRoleArn())
                {
                    context.Writer.WritePropertyName("jobRoleArn");
                    context.Writer.Write(publicRequest.JobRoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"data.";

            return request;
        }
        private static CreateBulkImportJobRequestMarshaller _instance = new CreateBulkImportJobRequestMarshaller();        

        internal static CreateBulkImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBulkImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}