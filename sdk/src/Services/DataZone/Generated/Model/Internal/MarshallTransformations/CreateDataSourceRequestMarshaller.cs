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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataSource Request Marshaller
    /// </summary>       
    public class CreateDataSourceRequestMarshaller : IMarshaller<IRequest, CreateDataSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/data-sources";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssetFormsInput())
            {
                context.Writer.WritePropertyName("assetFormsInput");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssetFormsInputListValue in publicRequest.AssetFormsInput)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FormInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssetFormsInputListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceConfigurationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConnectionIdentifier())
            {
                context.Writer.WritePropertyName("connectionIdentifier");
                context.Writer.WriteStringValue(publicRequest.ConnectionIdentifier);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnableSetting())
            {
                context.Writer.WritePropertyName("enableSetting");
                context.Writer.WriteStringValue(publicRequest.EnableSetting);
            }

            if(publicRequest.IsSetEnvironmentIdentifier())
            {
                context.Writer.WritePropertyName("environmentIdentifier");
                context.Writer.WriteStringValue(publicRequest.EnvironmentIdentifier);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProjectIdentifier())
            {
                context.Writer.WritePropertyName("projectIdentifier");
                context.Writer.WriteStringValue(publicRequest.ProjectIdentifier);
            }

            if(publicRequest.IsSetPublishOnImport())
            {
                context.Writer.WritePropertyName("publishOnImport");
                context.Writer.WriteBooleanValue(publicRequest.PublishOnImport.Value);
            }

            if(publicRequest.IsSetRecommendation())
            {
                context.Writer.WritePropertyName("recommendation");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Recommendation, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSchedule())
            {
                context.Writer.WritePropertyName("schedule");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(publicRequest.Type);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateDataSourceRequestMarshaller _instance = new CreateDataSourceRequestMarshaller();        

        internal static CreateDataSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}