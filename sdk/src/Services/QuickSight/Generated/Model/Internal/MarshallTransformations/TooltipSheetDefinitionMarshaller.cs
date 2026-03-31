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
    /// TooltipSheetDefinition Marshaller
    /// </summary>
    public class TooltipSheetDefinitionMarshaller : IRequestMarshaller<TooltipSheetDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TooltipSheetDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetImages())
            {
                context.Writer.WritePropertyName("Images");
                context.Writer.WriteStartArray();
                foreach(var requestObjectImagesListValue in requestObject.Images)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SheetImageMarshaller.Instance;
                    marshaller.Marshall(requestObjectImagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLayouts())
            {
                context.Writer.WritePropertyName("Layouts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLayoutsListValue in requestObject.Layouts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LayoutMarshaller.Instance;
                    marshaller.Marshall(requestObjectLayoutsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetSheetId())
            {
                context.Writer.WritePropertyName("SheetId");
                context.Writer.WriteStringValue(requestObject.SheetId);
            }

            if(requestObject.IsSetTextBoxes())
            {
                context.Writer.WritePropertyName("TextBoxes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTextBoxesListValue in requestObject.TextBoxes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SheetTextBoxMarshaller.Instance;
                    marshaller.Marshall(requestObjectTextBoxesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVisuals())
            {
                context.Writer.WritePropertyName("Visuals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVisualsListValue in requestObject.Visuals)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VisualMarshaller.Instance;
                    marshaller.Marshall(requestObjectVisualsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TooltipSheetDefinitionMarshaller Instance = new TooltipSheetDefinitionMarshaller();

    }
}