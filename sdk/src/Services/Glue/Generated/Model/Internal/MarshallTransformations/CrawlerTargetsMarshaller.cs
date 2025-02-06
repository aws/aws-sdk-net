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
    /// CrawlerTargets Marshaller
    /// </summary>
    public class CrawlerTargetsMarshaller : IRequestMarshaller<CrawlerTargets, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CrawlerTargets requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCatalogTargets())
            {
                context.Writer.WritePropertyName("CatalogTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCatalogTargetsListValue in requestObject.CatalogTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CatalogTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectCatalogTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDeltaTargets())
            {
                context.Writer.WritePropertyName("DeltaTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDeltaTargetsListValue in requestObject.DeltaTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DeltaTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectDeltaTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDynamoDBTargets())
            {
                context.Writer.WritePropertyName("DynamoDBTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDynamoDBTargetsListValue in requestObject.DynamoDBTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DynamoDBTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectDynamoDBTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHudiTargets())
            {
                context.Writer.WritePropertyName("HudiTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHudiTargetsListValue in requestObject.HudiTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HudiTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectHudiTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIcebergTargets())
            {
                context.Writer.WritePropertyName("IcebergTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIcebergTargetsListValue in requestObject.IcebergTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IcebergTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectIcebergTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJdbcTargets())
            {
                context.Writer.WritePropertyName("JdbcTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectJdbcTargetsListValue in requestObject.JdbcTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = JdbcTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectJdbcTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMongoDBTargets())
            {
                context.Writer.WritePropertyName("MongoDBTargets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMongoDBTargetsListValue in requestObject.MongoDBTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MongoDBTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectMongoDBTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetS3Targets())
            {
                context.Writer.WritePropertyName("S3Targets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectS3TargetsListValue in requestObject.S3Targets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = S3TargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectS3TargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CrawlerTargetsMarshaller Instance = new CrawlerTargetsMarshaller();

    }
}