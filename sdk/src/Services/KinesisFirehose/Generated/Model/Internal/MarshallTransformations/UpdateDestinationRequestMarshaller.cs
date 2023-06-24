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
    /// UpdateDestination Request Marshaller
    /// </summary>       
    public class UpdateDestinationRequestMarshaller : IMarshaller<IRequest, UpdateDestinationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDestinationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KinesisFirehose");
            string target = "Firehose_20150804.UpdateDestination";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-08-04";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAmazonOpenSearchServerlessDestinationUpdate())
                {
                    context.Writer.WritePropertyName("AmazonOpenSearchServerlessDestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = AmazonOpenSearchServerlessDestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AmazonOpenSearchServerlessDestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAmazonopensearchserviceDestinationUpdate())
                {
                    context.Writer.WritePropertyName("AmazonopensearchserviceDestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = AmazonopensearchserviceDestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AmazonopensearchserviceDestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCurrentDeliveryStreamVersionId())
                {
                    context.Writer.WritePropertyName("CurrentDeliveryStreamVersionId");
                    context.Writer.Write(publicRequest.CurrentDeliveryStreamVersionId);
                }

                if(publicRequest.IsSetDeliveryStreamName())
                {
                    context.Writer.WritePropertyName("DeliveryStreamName");
                    context.Writer.Write(publicRequest.DeliveryStreamName);
                }

                if(publicRequest.IsSetDestinationId())
                {
                    context.Writer.WritePropertyName("DestinationId");
                    context.Writer.Write(publicRequest.DestinationId);
                }

                if(publicRequest.IsSetElasticsearchDestinationUpdate())
                {
                    context.Writer.WritePropertyName("ElasticsearchDestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = ElasticsearchDestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ElasticsearchDestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExtendedS3DestinationUpdate())
                {
                    context.Writer.WritePropertyName("ExtendedS3DestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExtendedS3DestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExtendedS3DestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetHttpEndpointDestinationUpdate())
                {
                    context.Writer.WritePropertyName("HttpEndpointDestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = HttpEndpointDestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.HttpEndpointDestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRedshiftDestinationUpdate())
                {
                    context.Writer.WritePropertyName("RedshiftDestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = RedshiftDestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RedshiftDestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetS3DestinationUpdate())
                {
                    context.Writer.WritePropertyName("S3DestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3DestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3DestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSplunkDestinationUpdate())
                {
                    context.Writer.WritePropertyName("SplunkDestinationUpdate");
                    context.Writer.WriteObjectStart();

                    var marshaller = SplunkDestinationUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SplunkDestinationUpdate, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDestinationRequestMarshaller _instance = new UpdateDestinationRequestMarshaller();        

        internal static UpdateDestinationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDestinationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}