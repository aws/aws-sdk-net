/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeliveryStream Request Marshaller
    /// </summary>       
    public class CreateDeliveryStreamRequestMarshaller : IMarshaller<IRequest, CreateDeliveryStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeliveryStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeliveryStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisFirehose");
            string target = "Firehose_20150804.CreateDeliveryStream";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeliveryStreamName())
                {
                    context.Writer.WritePropertyName("DeliveryStreamName");
                    context.Writer.Write(publicRequest.DeliveryStreamName);
                }

                if(publicRequest.IsSetDeliveryStreamType())
                {
                    context.Writer.WritePropertyName("DeliveryStreamType");
                    context.Writer.Write(publicRequest.DeliveryStreamType);
                }

                if(publicRequest.IsSetElasticsearchDestinationConfiguration())
                {
                    context.Writer.WritePropertyName("ElasticsearchDestinationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ElasticsearchDestinationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ElasticsearchDestinationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExtendedS3DestinationConfiguration())
                {
                    context.Writer.WritePropertyName("ExtendedS3DestinationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExtendedS3DestinationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExtendedS3DestinationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKinesisStreamSourceConfiguration())
                {
                    context.Writer.WritePropertyName("KinesisStreamSourceConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = KinesisStreamSourceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KinesisStreamSourceConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRedshiftDestinationConfiguration())
                {
                    context.Writer.WritePropertyName("RedshiftDestinationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RedshiftDestinationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RedshiftDestinationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetS3DestinationConfiguration())
                {
                    context.Writer.WritePropertyName("S3DestinationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3DestinationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3DestinationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSplunkDestinationConfiguration())
                {
                    context.Writer.WritePropertyName("SplunkDestinationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = SplunkDestinationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SplunkDestinationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDeliveryStreamRequestMarshaller _instance = new CreateDeliveryStreamRequestMarshaller();        

        internal static CreateDeliveryStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDeliveryStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}