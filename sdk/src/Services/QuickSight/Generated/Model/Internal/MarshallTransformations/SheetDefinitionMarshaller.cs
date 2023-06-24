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
            if(requestObject.IsSetContentType())
            {
                context.Writer.WritePropertyName("ContentType");
                context.Writer.Write(requestObject.ContentType);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFilterControls())
            {
                context.Writer.WritePropertyName("FilterControls");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFilterControlsListValue in requestObject.FilterControls)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FilterControlMarshaller.Instance;
                    marshaller.Marshall(requestObjectFilterControlsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLayouts())
            {
                context.Writer.WritePropertyName("Layouts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLayoutsListValue in requestObject.Layouts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LayoutMarshaller.Instance;
                    marshaller.Marshall(requestObjectLayoutsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetParameterControls())
            {
                context.Writer.WritePropertyName("ParameterControls");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectParameterControlsListValue in requestObject.ParameterControls)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ParameterControlMarshaller.Instance;
                    marshaller.Marshall(requestObjectParameterControlsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSheetControlLayouts())
            {
                context.Writer.WritePropertyName("SheetControlLayouts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSheetControlLayoutsListValue in requestObject.SheetControlLayouts)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SheetControlLayoutMarshaller.Instance;
                    marshaller.Marshall(requestObjectSheetControlLayoutsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSheetId())
            {
                context.Writer.WritePropertyName("SheetId");
                context.Writer.Write(requestObject.SheetId);
            }

            if(requestObject.IsSetTextBoxes())
            {
                context.Writer.WritePropertyName("TextBoxes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTextBoxesListValue in requestObject.TextBoxes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SheetTextBoxMarshaller.Instance;
                    marshaller.Marshall(requestObjectTextBoxesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

            if(requestObject.IsSetVisuals())
            {
                context.Writer.WritePropertyName("Visuals");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVisualsListValue in requestObject.Visuals)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VisualMarshaller.Instance;
                    marshaller.Marshall(requestObjectVisualsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SheetDefinitionMarshaller Instance = new SheetDefinitionMarshaller();

    }
}