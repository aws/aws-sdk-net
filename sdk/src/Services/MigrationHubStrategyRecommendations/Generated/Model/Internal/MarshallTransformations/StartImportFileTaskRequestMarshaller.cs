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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartImportFileTask Request Marshaller
    /// </summary>       
    public class StartImportFileTaskRequestMarshaller : IMarshaller<IRequest, StartImportFileTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartImportFileTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartImportFileTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MigrationHubStrategyRecommendations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-19";
            request.HttpMethod = "POST";

            request.ResourcePath = "/start-import-file-task";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataSourceType())
                {
                    context.Writer.WritePropertyName("dataSourceType");
                    context.Writer.Write(publicRequest.DataSourceType);
                }

                if(publicRequest.IsSetGroupId())
                {
                    context.Writer.WritePropertyName("groupId");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGroupIdListValue in publicRequest.GroupId)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = GroupMarshaller.Instance;
                        marshaller.Marshall(publicRequestGroupIdListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetS3Bucket())
                {
                    context.Writer.WritePropertyName("S3Bucket");
                    context.Writer.Write(publicRequest.S3Bucket);
                }

                if(publicRequest.IsSetS3bucketForReportData())
                {
                    context.Writer.WritePropertyName("s3bucketForReportData");
                    context.Writer.Write(publicRequest.S3bucketForReportData);
                }

                if(publicRequest.IsSetS3key())
                {
                    context.Writer.WritePropertyName("s3key");
                    context.Writer.Write(publicRequest.S3key);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartImportFileTaskRequestMarshaller _instance = new StartImportFileTaskRequestMarshaller();        

        internal static StartImportFileTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartImportFileTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}