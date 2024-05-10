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
    /// PivotTableCellConditionalFormatting Marshaller
    /// </summary>
    public class PivotTableCellConditionalFormattingMarshaller : IRequestMarshaller<PivotTableCellConditionalFormatting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PivotTableCellConditionalFormatting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFieldId())
            {
                context.Writer.WritePropertyName("FieldId");
                context.Writer.Write(requestObject.FieldId);
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteObjectStart();

                var marshaller = PivotTableConditionalFormattingScopeMarshaller.Instance;
                marshaller.Marshall(requestObject.Scope, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetScopes())
            {
                context.Writer.WritePropertyName("Scopes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScopesListValue in requestObject.Scopes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PivotTableConditionalFormattingScopeMarshaller.Instance;
                    marshaller.Marshall(requestObjectScopesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTextFormat())
            {
                context.Writer.WritePropertyName("TextFormat");
                context.Writer.WriteObjectStart();

                var marshaller = TextConditionalFormatMarshaller.Instance;
                marshaller.Marshall(requestObject.TextFormat, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PivotTableCellConditionalFormattingMarshaller Instance = new PivotTableCellConditionalFormattingMarshaller();

    }
}