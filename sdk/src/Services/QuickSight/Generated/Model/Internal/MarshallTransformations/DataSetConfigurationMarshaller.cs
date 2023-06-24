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
    /// DataSetConfiguration Marshaller
    /// </summary>
    public class DataSetConfigurationMarshaller : IRequestMarshaller<DataSetConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataSetConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetColumnGroupSchemaList())
            {
                context.Writer.WritePropertyName("ColumnGroupSchemaList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectColumnGroupSchemaListListValue in requestObject.ColumnGroupSchemaList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ColumnGroupSchemaMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnGroupSchemaListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataSetSchema())
            {
                context.Writer.WritePropertyName("DataSetSchema");
                context.Writer.WriteObjectStart();

                var marshaller = DataSetSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSetSchema, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlaceholder())
            {
                context.Writer.WritePropertyName("Placeholder");
                context.Writer.Write(requestObject.Placeholder);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataSetConfigurationMarshaller Instance = new DataSetConfigurationMarshaller();

    }
}