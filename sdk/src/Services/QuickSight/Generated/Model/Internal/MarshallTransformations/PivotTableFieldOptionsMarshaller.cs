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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PivotTableFieldOptions Marshaller
    /// </summary>
    public class PivotTableFieldOptionsMarshaller : IRequestMarshaller<PivotTableFieldOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PivotTableFieldOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCollapseStateOptions())
            {
                context.Writer.WritePropertyName("CollapseStateOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCollapseStateOptionsListValue in requestObject.CollapseStateOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PivotTableFieldCollapseStateOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCollapseStateOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataPathOptions())
            {
                context.Writer.WritePropertyName("DataPathOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataPathOptionsListValue in requestObject.DataPathOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PivotTableDataPathOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataPathOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSelectedFieldOptions())
            {
                context.Writer.WritePropertyName("SelectedFieldOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSelectedFieldOptionsListValue in requestObject.SelectedFieldOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PivotTableFieldOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectSelectedFieldOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PivotTableFieldOptionsMarshaller Instance = new PivotTableFieldOptionsMarshaller();

    }
}