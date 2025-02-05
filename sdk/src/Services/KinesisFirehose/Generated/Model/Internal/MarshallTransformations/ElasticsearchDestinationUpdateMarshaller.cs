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
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ElasticsearchDestinationUpdate Marshaller
    /// </summary>
    public class ElasticsearchDestinationUpdateMarshaller : IRequestMarshaller<ElasticsearchDestinationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ElasticsearchDestinationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBufferingHints())
            {
                context.Writer.WritePropertyName("BufferingHints");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchBufferingHintsMarshaller.Instance;
                marshaller.Marshall(requestObject.BufferingHints, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCloudWatchLoggingOptions())
            {
                context.Writer.WritePropertyName("CloudWatchLoggingOptions");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLoggingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLoggingOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClusterEndpoint())
            {
                context.Writer.WritePropertyName("ClusterEndpoint");
                context.Writer.WriteStringValue(requestObject.ClusterEndpoint);
            }

            if(requestObject.IsSetDocumentIdOptions())
            {
                context.Writer.WritePropertyName("DocumentIdOptions");
                context.Writer.WriteStartObject();

                var marshaller = DocumentIdOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DocumentIdOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDomainARN())
            {
                context.Writer.WritePropertyName("DomainARN");
                context.Writer.WriteStringValue(requestObject.DomainARN);
            }

            if(requestObject.IsSetIndexName())
            {
                context.Writer.WritePropertyName("IndexName");
                context.Writer.WriteStringValue(requestObject.IndexName);
            }

            if(requestObject.IsSetIndexRotationPeriod())
            {
                context.Writer.WritePropertyName("IndexRotationPeriod");
                context.Writer.WriteStringValue(requestObject.IndexRotationPeriod);
            }

            if(requestObject.IsSetProcessingConfiguration())
            {
                context.Writer.WritePropertyName("ProcessingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ProcessingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProcessingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetryOptions())
            {
                context.Writer.WritePropertyName("RetryOptions");
                context.Writer.WriteStartObject();

                var marshaller = ElasticsearchRetryOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("RoleARN");
                context.Writer.WriteStringValue(requestObject.RoleARN);
            }

            if(requestObject.IsSetS3Update())
            {
                context.Writer.WritePropertyName("S3Update");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Update, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTypeName())
            {
                context.Writer.WritePropertyName("TypeName");
                context.Writer.WriteStringValue(requestObject.TypeName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ElasticsearchDestinationUpdateMarshaller Instance = new ElasticsearchDestinationUpdateMarshaller();

    }
}