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
    /// SheetDefinition Marshaller
    /// </summary>
    public class SheetDefinitionMarshaller : IRequestMarshaller<SheetDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SheetDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContentType())
            {
                context.Writer.WritePropertyName("ContentType");
                context.Writer.WriteStringValue(requestObject.ContentType);
            }

            if(requestObject.IsSetCustomActionDefaults())
            {
                context.Writer.WritePropertyName("CustomActionDefaults");
                context.Writer.WriteStartObject();

                var marshaller = VisualCustomActionDefaultsMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomActionDefaults, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFilterControls())
            {
                context.Writer.WritePropertyName("FilterControls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFilterControlsListValue in requestObject.FilterControls)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterControlMarshaller.Instance;
                    marshaller.Marshall(requestObjectFilterControlsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

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

            if(requestObject.IsSetParameterControls())
            {
                context.Writer.WritePropertyName("ParameterControls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectParameterControlsListValue in requestObject.ParameterControls)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ParameterControlMarshaller.Instance;
                    marshaller.Marshall(requestObjectParameterControlsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSheetControlLayouts())
            {
                context.Writer.WritePropertyName("SheetControlLayouts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSheetControlLayoutsListValue in requestObject.SheetControlLayouts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SheetControlLayoutMarshaller.Instance;
                    marshaller.Marshall(requestObjectSheetControlLayoutsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
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
        public readonly static SheetDefinitionMarshaller Instance = new SheetDefinitionMarshaller();

    }
}