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
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SemanticType Marshaller
    /// </summary>
    public class SemanticTypeMarshaller : IRequestMarshaller<SemanticType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SemanticType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFalseyCellValue())
            {
                context.Writer.WritePropertyName("FalseyCellValue");
                context.Writer.WriteStringValue(requestObject.FalseyCellValue);
            }

            if(requestObject.IsSetFalseyCellValueSynonyms())
            {
                context.Writer.WritePropertyName("FalseyCellValueSynonyms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFalseyCellValueSynonymsListValue in requestObject.FalseyCellValueSynonyms)
                {
                        context.Writer.WriteStringValue(requestObjectFalseyCellValueSynonymsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubTypeName())
            {
                context.Writer.WritePropertyName("SubTypeName");
                context.Writer.WriteStringValue(requestObject.SubTypeName);
            }

            if(requestObject.IsSetTruthyCellValue())
            {
                context.Writer.WritePropertyName("TruthyCellValue");
                context.Writer.WriteStringValue(requestObject.TruthyCellValue);
            }

            if(requestObject.IsSetTruthyCellValueSynonyms())
            {
                context.Writer.WritePropertyName("TruthyCellValueSynonyms");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTruthyCellValueSynonymsListValue in requestObject.TruthyCellValueSynonyms)
                {
                        context.Writer.WriteStringValue(requestObjectTruthyCellValueSynonymsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTypeName())
            {
                context.Writer.WritePropertyName("TypeName");
                context.Writer.WriteStringValue(requestObject.TypeName);
            }

            if(requestObject.IsSetTypeParameters())
            {
                context.Writer.WritePropertyName("TypeParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTypeParametersKvp in requestObject.TypeParameters)
                {
                    context.Writer.WritePropertyName(requestObjectTypeParametersKvp.Key);
                    var requestObjectTypeParametersValue = requestObjectTypeParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTypeParametersValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SemanticTypeMarshaller Instance = new SemanticTypeMarshaller();

    }
}