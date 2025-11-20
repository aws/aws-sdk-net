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
    /// GridLayoutElement Marshaller
    /// </summary>
    public class GridLayoutElementMarshaller : IRequestMarshaller<GridLayoutElement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GridLayoutElement requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackgroundStyle())
            {
                context.Writer.WritePropertyName("BackgroundStyle");
                context.Writer.WriteObjectStart();

                var marshaller = GridLayoutElementBackgroundStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.BackgroundStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBorderRadius())
            {
                context.Writer.WritePropertyName("BorderRadius");
                context.Writer.Write(requestObject.BorderRadius);
            }

            if(requestObject.IsSetBorderStyle())
            {
                context.Writer.WritePropertyName("BorderStyle");
                context.Writer.WriteObjectStart();

                var marshaller = GridLayoutElementBorderStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.BorderStyle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetColumnIndex())
            {
                context.Writer.WritePropertyName("ColumnIndex");
                context.Writer.Write(requestObject.ColumnIndex);
            }

            if(requestObject.IsSetColumnSpan())
            {
                context.Writer.WritePropertyName("ColumnSpan");
                context.Writer.Write(requestObject.ColumnSpan);
            }

            if(requestObject.IsSetElementId())
            {
                context.Writer.WritePropertyName("ElementId");
                context.Writer.Write(requestObject.ElementId);
            }

            if(requestObject.IsSetElementType())
            {
                context.Writer.WritePropertyName("ElementType");
                context.Writer.Write(requestObject.ElementType);
            }

            if(requestObject.IsSetLoadingAnimation())
            {
                context.Writer.WritePropertyName("LoadingAnimation");
                context.Writer.WriteObjectStart();

                var marshaller = LoadingAnimationMarshaller.Instance;
                marshaller.Marshall(requestObject.LoadingAnimation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPadding())
            {
                context.Writer.WritePropertyName("Padding");
                context.Writer.Write(requestObject.Padding);
            }

            if(requestObject.IsSetRowIndex())
            {
                context.Writer.WritePropertyName("RowIndex");
                context.Writer.Write(requestObject.RowIndex);
            }

            if(requestObject.IsSetRowSpan())
            {
                context.Writer.WritePropertyName("RowSpan");
                context.Writer.Write(requestObject.RowSpan);
            }

            if(requestObject.IsSetSelectedBorderStyle())
            {
                context.Writer.WritePropertyName("SelectedBorderStyle");
                context.Writer.WriteObjectStart();

                var marshaller = GridLayoutElementBorderStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectedBorderStyle, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GridLayoutElementMarshaller Instance = new GridLayoutElementMarshaller();

    }
}