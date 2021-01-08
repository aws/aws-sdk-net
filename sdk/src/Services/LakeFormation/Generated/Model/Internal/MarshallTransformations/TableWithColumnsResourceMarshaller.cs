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
    /// TableWithColumnsResource Marshaller
    /// </summary>       
    public class TableWithColumnsResourceMarshaller : IRequestMarshaller<TableWithColumnsResource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableWithColumnsResource requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCatalogId())
            {
                context.Writer.WritePropertyName("CatalogId");
                context.Writer.Write(requestObject.CatalogId);
            }

            if(requestObject.IsSetColumnNames())
            {
                context.Writer.WritePropertyName("ColumnNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectColumnNamesListValue in requestObject.ColumnNames)
                {
                        context.Writer.Write(requestObjectColumnNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetColumnWildcard())
            {
                context.Writer.WritePropertyName("ColumnWildcard");
                context.Writer.WriteObjectStart();

                var marshaller = ColumnWildcardMarshaller.Instance;
                marshaller.Marshall(requestObject.ColumnWildcard, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TableWithColumnsResourceMarshaller Instance = new TableWithColumnsResourceMarshaller();

    }
}