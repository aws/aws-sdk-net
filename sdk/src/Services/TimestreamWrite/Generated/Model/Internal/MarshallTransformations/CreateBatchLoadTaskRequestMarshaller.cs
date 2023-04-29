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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamWrite.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamWrite.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBatchLoadTask Request Marshaller
    /// </summary>       
    public class CreateBatchLoadTaskRequestMarshaller : IMarshaller<IRequest, CreateBatchLoadTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBatchLoadTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBatchLoadTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.TimestreamWrite");
            string target = "Timestream_20181101.CreateBatchLoadTask";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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
                if(publicRequest.IsSetDataModelConfiguration())
                {
                    context.Writer.WritePropertyName("DataModelConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataModelConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataModelConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataSourceConfiguration())
                {
                    context.Writer.WritePropertyName("DataSourceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSourceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRecordVersion())
                {
                    context.Writer.WritePropertyName("RecordVersion");
                    context.Writer.Write(publicRequest.RecordVersion);
                }

                if(publicRequest.IsSetReportConfiguration())
                {
                    context.Writer.WritePropertyName("ReportConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ReportConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ReportConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTargetDatabaseName())
                {
                    context.Writer.WritePropertyName("TargetDatabaseName");
                    context.Writer.Write(publicRequest.TargetDatabaseName);
                }

                if(publicRequest.IsSetTargetTableName())
                {
                    context.Writer.WritePropertyName("TargetTableName");
                    context.Writer.Write(publicRequest.TargetTableName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateBatchLoadTaskRequestMarshaller _instance = new CreateBatchLoadTaskRequestMarshaller();        

        internal static CreateBatchLoadTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBatchLoadTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}