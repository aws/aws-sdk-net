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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.WriteObjectStart();

                var marshaller = CatalogResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Catalog, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Database, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataLocation())
            {
                context.Writer.WritePropertyName("DataLocation");
                context.Writer.WriteObjectStart();

                var marshaller = DataLocationResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DataLocation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLFTag())
            {
                context.Writer.WritePropertyName("LFTag");
                context.Writer.WriteObjectStart();

                var marshaller = LFTagKeyResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.LFTag, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLFTagPolicy())
            {
                context.Writer.WritePropertyName("LFTagPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = LFTagPolicyResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.LFTagPolicy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTable())
            {
                context.Writer.WritePropertyName("Table");
                context.Writer.WriteObjectStart();

                var marshaller = TableResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Table, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTableWithColumns())
            {
                context.Writer.WritePropertyName("TableWithColumns");
                context.Writer.WriteObjectStart();

                var marshaller = TableWithColumnsResourceMarshaller.Instance;
                marshaller.Marshall(requestObject.TableWithColumns, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ResourceMarshaller Instance = new ResourceMarshaller();

    }
}