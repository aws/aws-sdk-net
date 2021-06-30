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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCatalogId())
            {
                context.Writer.WritePropertyName("CatalogId");
                context.Writer.Write(requestObject.CatalogId);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDatabaseOptions())
            {
                context.Writer.WritePropertyName("DatabaseOptions");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseTableOutputOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOverwrite())
            {
                context.Writer.WritePropertyName("Overwrite");
                context.Writer.Write(requestObject.Overwrite);
            }

            if(requestObject.IsSetS3Options())
            {
                context.Writer.WritePropertyName("S3Options");
                context.Writer.WriteObjectStart();

                var marshaller = S3TableOutputOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Options, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTableName())
            {
                context.Writer.WritePropertyName("TableName");
                context.Writer.Write(requestObject.TableName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DataCatalogOutputMarshaller Instance = new DataCatalogOutputMarshaller();

    }
}