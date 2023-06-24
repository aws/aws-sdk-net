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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDatasetImportJob Request Marshaller
    /// </summary>       
    public class CreateDatasetImportJobRequestMarshaller : IMarshaller<IRequest, CreateDatasetImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDatasetImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDatasetImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ForecastService");
            string target = "AmazonForecast.CreateDatasetImportJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-06-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDatasetArn())
                {
                    context.Writer.WritePropertyName("DatasetArn");
                    context.Writer.Write(publicRequest.DatasetArn);
                }

                if(publicRequest.IsSetDatasetImportJobName())
                {
                    context.Writer.WritePropertyName("DatasetImportJobName");
                    context.Writer.Write(publicRequest.DatasetImportJobName);
                }

                if(publicRequest.IsSetDataSource())
                {
                    context.Writer.WritePropertyName("DataSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFormat())
                {
                    context.Writer.WritePropertyName("Format");
                    context.Writer.Write(publicRequest.Format);
                }

                if(publicRequest.IsSetGeolocationFormat())
                {
                    context.Writer.WritePropertyName("GeolocationFormat");
                    context.Writer.Write(publicRequest.GeolocationFormat);
                }

                if(publicRequest.IsSetImportMode())
                {
                    context.Writer.WritePropertyName("ImportMode");
                    context.Writer.Write(publicRequest.ImportMode);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTimestampFormat())
                {
                    context.Writer.WritePropertyName("TimestampFormat");
                    context.Writer.Write(publicRequest.TimestampFormat);
                }

                if(publicRequest.IsSetTimeZone())
                {
                    context.Writer.WritePropertyName("TimeZone");
                    context.Writer.Write(publicRequest.TimeZone);
                }

                if(publicRequest.IsSetUseGeolocationForTimeZone())
                {
                    context.Writer.WritePropertyName("UseGeolocationForTimeZone");
                    context.Writer.Write(publicRequest.UseGeolocationForTimeZone);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDatasetImportJobRequestMarshaller _instance = new CreateDatasetImportJobRequestMarshaller();        

        internal static CreateDatasetImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDatasetImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}