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
    /// CatalogKinesisSource Marshaller
    /// </summary>
    public class CatalogKinesisSourceMarshaller : IRequestMarshaller<CatalogKinesisSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CatalogKinesisSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteStringValue(requestObject.Database);
            }

            if(requestObject.IsSetDataPreviewOptions())
            {
                context.Writer.WritePropertyName("DataPreviewOptions");
                context.Writer.WriteStartObject();

                var marshaller = StreamingDataPreviewOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataPreviewOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDetectSchema())
            {
                context.Writer.WritePropertyName("DetectSchema");
                context.Writer.WriteBooleanValue(requestObject.DetectSchema.Value);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetStreamingOptions())
            {
                context.Writer.WritePropertyName("StreamingOptions");
                context.Writer.WriteStartObject();

                var marshaller = KinesisStreamingSourceOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamingOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTable())
            {
                context.Writer.WritePropertyName("Table");
                context.Writer.WriteStringValue(requestObject.Table);
            }

            if(requestObject.IsSetWindowSize())
            {
                context.Writer.WritePropertyName("WindowSize");
                context.Writer.WriteNumberValue(requestObject.WindowSize.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CatalogKinesisSourceMarshaller Instance = new CatalogKinesisSourceMarshaller();

    }
}