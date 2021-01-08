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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RelationalTable Marshaller
    /// </summary>       
    public class RelationalTableMarshaller : IRequestMarshaller<RelationalTable, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RelationalTable requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCatalog())
            {
                context.Writer.WritePropertyName("Catalog");
                context.Writer.Write(requestObject.Catalog);
            }

            if(requestObject.IsSetDataSourceArn())
            {
                context.Writer.WritePropertyName("DataSourceArn");
                context.Writer.Write(requestObject.DataSourceArn);
            }

            if(requestObject.IsSetInputColumns())
            {
                context.Writer.WritePropertyName("InputColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputColumnsListValue in requestObject.InputColumns)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InputColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputColumnsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetSchema())
            {
                context.Writer.WritePropertyName("Schema");
                context.Writer.Write(requestObject.Schema);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RelationalTableMarshaller Instance = new RelationalTableMarshaller();

    }
}