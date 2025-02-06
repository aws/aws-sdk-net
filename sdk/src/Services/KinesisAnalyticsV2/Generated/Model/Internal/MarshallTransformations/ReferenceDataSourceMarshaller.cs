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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReferenceDataSource Marshaller
    /// </summary>
    public class ReferenceDataSourceMarshaller : IRequestMarshaller<ReferenceDataSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReferenceDataSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetReferenceSchema())
            {
                context.Writer.WritePropertyName("ReferenceSchema");
                context.Writer.WriteStartObject();

                var marshaller = SourceSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.ReferenceSchema, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3ReferenceDataSource())
            {
                context.Writer.WritePropertyName("S3ReferenceDataSource");
                context.Writer.WriteStartObject();

                var marshaller = S3ReferenceDataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ReferenceDataSource, context);

                context.Writer.WriteEndObject();
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
        public readonly static ReferenceDataSourceMarshaller Instance = new ReferenceDataSourceMarshaller();

    }
}