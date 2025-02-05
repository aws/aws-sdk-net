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
    /// DestinationTableConfiguration Marshaller
    /// </summary>
    public class DestinationTableConfigurationMarshaller : IRequestMarshaller<DestinationTableConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DestinationTableConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationDatabaseName())
            {
                context.Writer.WritePropertyName("DestinationDatabaseName");
                context.Writer.WriteStringValue(requestObject.DestinationDatabaseName);
            }

            if(requestObject.IsSetDestinationTableName())
            {
                context.Writer.WritePropertyName("DestinationTableName");
                context.Writer.WriteStringValue(requestObject.DestinationTableName);
            }

            if(requestObject.IsSetPartitionSpec())
            {
                context.Writer.WritePropertyName("PartitionSpec");
                context.Writer.WriteStartObject();

                var marshaller = PartitionSpecMarshaller.Instance;
                marshaller.Marshall(requestObject.PartitionSpec, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3ErrorOutputPrefix())
            {
                context.Writer.WritePropertyName("S3ErrorOutputPrefix");
                context.Writer.WriteStringValue(requestObject.S3ErrorOutputPrefix);
            }

            if(requestObject.IsSetUniqueKeys())
            {
                context.Writer.WritePropertyName("UniqueKeys");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUniqueKeysListValue in requestObject.UniqueKeys)
                {
                        context.Writer.WriteStringValue(requestObjectUniqueKeysListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DestinationTableConfigurationMarshaller Instance = new DestinationTableConfigurationMarshaller();

    }
}