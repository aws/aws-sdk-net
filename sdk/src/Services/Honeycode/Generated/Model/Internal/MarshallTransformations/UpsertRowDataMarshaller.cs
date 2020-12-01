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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Honeycode.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Honeycode.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpsertRowData Marshaller
    /// </summary>       
    public class UpsertRowDataMarshaller : IRequestMarshaller<UpsertRowData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpsertRowData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBatchItemId())
            {
                context.Writer.WritePropertyName("batchItemId");
                context.Writer.Write(requestObject.BatchItemId);
            }

            if(requestObject.IsSetCellsToUpdate())
            {
                context.Writer.WritePropertyName("cellsToUpdate");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCellsToUpdateKvp in requestObject.CellsToUpdate)
                {
                    context.Writer.WritePropertyName(requestObjectCellsToUpdateKvp.Key);
                    var requestObjectCellsToUpdateValue = requestObjectCellsToUpdateKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = CellInputMarshaller.Instance;
                    marshaller.Marshall(requestObjectCellsToUpdateValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.WriteObjectStart();

                var marshaller = FilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UpsertRowDataMarshaller Instance = new UpsertRowDataMarshaller();

    }
}