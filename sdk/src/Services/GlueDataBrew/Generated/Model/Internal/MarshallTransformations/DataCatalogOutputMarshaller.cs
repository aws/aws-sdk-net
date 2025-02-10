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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataCatalogOutput Marshaller
    /// </summary>
    public class DataCatalogOutputMarshaller : IRequestMarshaller<DataCatalogOutput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataCatalogOutput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCatalogId())
            {
                context.Writer.WritePropertyName("CatalogId");
                context.Writer.WriteStringValue(requestObject.CatalogId);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDatabaseOptions())
            {
                context.Writer.WritePropertyName("DatabaseOptions");
                context.Writer.WriteStartObject();

                var marshaller = DatabaseTableOutputOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOverwrite())
            {
                context.Writer.WritePropertyName("Overwrite");
                context.Writer.WriteBooleanValue(requestObject.Overwrite.Value);
            }

            if(requestObject.IsSetS3Options())
            {
                context.Writer.WritePropertyName("S3Options");
                context.Writer.WriteStartObject();

                var marshaller = S3TableOutputOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Options, context);

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
        public readonly static DataCatalogOutputMarshaller Instance = new DataCatalogOutputMarshaller();

    }
}