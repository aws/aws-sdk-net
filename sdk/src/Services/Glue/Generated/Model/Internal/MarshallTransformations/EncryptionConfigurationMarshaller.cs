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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EncryptionConfiguration Marshaller
    /// </summary>
    public class EncryptionConfigurationMarshaller : IRequestMarshaller<EncryptionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EncryptionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchEncryption())
            {
                context.Writer.WritePropertyName("CloudWatchEncryption");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchEncryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataQualityEncryption())
            {
                context.Writer.WritePropertyName("DataQualityEncryption");
                context.Writer.WriteStartObject();

                var marshaller = DataQualityEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.DataQualityEncryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJobBookmarksEncryption())
            {
                context.Writer.WritePropertyName("JobBookmarksEncryption");
                context.Writer.WriteStartObject();

                var marshaller = JobBookmarksEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.JobBookmarksEncryption, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Encryption())
            {
                context.Writer.WritePropertyName("S3Encryption");
                context.Writer.WriteStartArray();
                foreach(var requestObjectS3EncryptionListValue in requestObject.S3Encryption)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = S3EncryptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectS3EncryptionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EncryptionConfigurationMarshaller Instance = new EncryptionConfigurationMarshaller();

    }
}