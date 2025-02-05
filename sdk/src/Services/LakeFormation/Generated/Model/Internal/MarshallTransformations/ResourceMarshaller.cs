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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Resource Marshaller
    /// </summary>
    public class ResourceMarshaller : IRequestMarshaller<Resource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Resource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteStartObject();

                var marshaller = CatalogResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Catalog, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteStartObject();

                var marshaller = DatabaseResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Database, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataCellsFilter())
            {
                context.Writer.WritePropertyName("DataCellsFilter");
                context.Writer.WriteStartObject();

                var marshaller = DataCellsFilterResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DataCellsFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataLocation())
            {
                context.Writer.WritePropertyName("DataLocation");
                context.Writer.WriteStartObject();

                var marshaller = DataLocationResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DataLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLFTag())
            {
                context.Writer.WritePropertyName("LFTag");
                context.Writer.WriteStartObject();

                var marshaller = LFTagKeyResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.LFTag, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLFTagExpression())
            {
                context.Writer.WritePropertyName("LFTagExpression");
                context.Writer.WriteStartObject();

                var marshaller = LFTagExpressionResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.LFTagExpression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLFTagPolicy())
            {
                context.Writer.WritePropertyName("LFTagPolicy");
                context.Writer.WriteStartObject();

                var marshaller = LFTagPolicyResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.LFTagPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTable())
            {
                context.Writer.WritePropertyName("Table");
                context.Writer.WriteStartObject();

                var marshaller = TableResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Table, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTableWithColumns())
            {
                context.Writer.WritePropertyName("TableWithColumns");
                context.Writer.WriteStartObject();

                var marshaller = TableWithColumnsResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.TableWithColumns, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceMarshaller Instance = new ResourceMarshaller();

    }
}