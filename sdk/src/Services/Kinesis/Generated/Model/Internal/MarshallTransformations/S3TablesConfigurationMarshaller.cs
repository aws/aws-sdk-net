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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3TablesConfiguration Marshaller
    /// </summary>
    public class S3TablesConfigurationMarshaller : IRequestMarshaller<S3TablesConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3TablesConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompressionType())
            {
                context.Writer.WritePropertyName("CompressionType");
                context.Writer.WriteStringValue(requestObject.CompressionType);
            }

            if(requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.WriteStringValue(requestObject.Namespace);
            }

            if(requestObject.IsSetPartitionSpec())
            {
                context.Writer.WritePropertyName("PartitionSpec");
                context.Writer.WriteStartObject();

                var marshaller = PartitionSpecMarshaller.Instance;
                marshaller.Marshall(requestObject.PartitionSpec, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTableBucketARN())
            {
                context.Writer.WritePropertyName("TableBucketARN");
                context.Writer.WriteStringValue(requestObject.TableBucketARN);
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.WriteStringValue(requestObject.TableName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3TablesConfigurationMarshaller Instance = new S3TablesConfigurationMarshaller();

    }
}