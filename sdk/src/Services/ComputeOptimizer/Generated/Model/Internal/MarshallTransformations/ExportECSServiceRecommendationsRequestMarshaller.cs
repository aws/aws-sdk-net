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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportECSServiceRecommendations Request Marshaller
    /// </summary>       
    public class ExportECSServiceRecommendationsRequestMarshaller : IMarshaller<IRequest, ExportECSServiceRecommendationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportECSServiceRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExportECSServiceRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizer");
            string target = "ComputeOptimizerService.ExportECSServiceRecommendations";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountIds())
                {
                    context.Writer.WritePropertyName("accountIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                    {
                            context.Writer.Write(publicRequestAccountIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFieldsToExport())
                {
                    context.Writer.WritePropertyName("fieldsToExport");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFieldsToExportListValue in publicRequest.FieldsToExport)
                    {
                            context.Writer.Write(publicRequestFieldsToExportListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFileFormat())
                {
                    context.Writer.WritePropertyName("fileFormat");
                    context.Writer.Write(publicRequest.FileFormat);
                }

                if(publicRequest.IsSetFilters())
                {
                    context.Writer.WritePropertyName("filters");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ECSServiceRecommendationFilterMarshaller.Instance;
                        marshaller.Marshall(publicRequestFiltersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIncludeMemberAccounts())
                {
                    context.Writer.WritePropertyName("includeMemberAccounts");
                    context.Writer.Write(publicRequest.IncludeMemberAccounts);
                }

                if(publicRequest.IsSetS3DestinationConfig())
                {
                    context.Writer.WritePropertyName("s3DestinationConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3DestinationConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3DestinationConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ExportECSServiceRecommendationsRequestMarshaller _instance = new ExportECSServiceRecommendationsRequestMarshaller();        

        internal static ExportECSServiceRecommendationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportECSServiceRecommendationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}