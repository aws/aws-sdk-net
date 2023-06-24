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
    /// AmazonOpenSearchServerlessDestinationConfiguration Marshaller
    /// </summary>
    public class AmazonOpenSearchServerlessDestinationConfigurationMarshaller : IRequestMarshaller<AmazonOpenSearchServerlessDestinationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AmazonOpenSearchServerlessDestinationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBufferingHints())
            {
                context.Writer.WritePropertyName("BufferingHints");
                context.Writer.WriteObjectStart();

                var marshaller = AmazonOpenSearchServerlessBufferingHintsMarshaller.Instance;
                marshaller.Marshall(requestObject.BufferingHints, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCloudWatchLoggingOptions())
            {
                context.Writer.WritePropertyName("CloudWatchLoggingOptions");
                context.Writer.WriteObjectStart();

                var marshaller = CloudWatchLoggingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLoggingOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCollectionEndpoint())
            {
                context.Writer.WritePropertyName("CollectionEndpoint");
                context.Writer.Write(requestObject.CollectionEndpoint);
            }

            if(requestObject.IsSetIndexName())
            {
                context.Writer.WritePropertyName("IndexName");
                context.Writer.Write(requestObject.IndexName);
            }

            if(requestObject.IsSetProcessingConfiguration())
            {
                context.Writer.WritePropertyName("ProcessingConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ProcessingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProcessingConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRetryOptions())
            {
                context.Writer.WritePropertyName("RetryOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AmazonOpenSearchServerlessRetryOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("RoleARN");
                context.Writer.Write(requestObject.RoleARN);
            }

            if(requestObject.IsSetS3BackupMode())
            {
                context.Writer.WritePropertyName("S3BackupMode");
                context.Writer.Write(requestObject.S3BackupMode);
            }

            if(requestObject.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("S3Configuration");
                context.Writer.WriteObjectStart();

                var marshaller = S3DestinationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Configuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = VpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AmazonOpenSearchServerlessDestinationConfigurationMarshaller Instance = new AmazonOpenSearchServerlessDestinationConfigurationMarshaller();

    }
}