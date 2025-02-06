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
            if(requestObject.IsSetColumnIndex())
            {
                context.Writer.WritePropertyName("ColumnIndex");
                context.Writer.WriteNumberValue(requestObject.ColumnIndex.Value);
            }

            if(requestObject.IsSetColumnSpan())
            {
                context.Writer.WritePropertyName("ColumnSpan");
                context.Writer.WriteNumberValue(requestObject.ColumnSpan.Value);
            }

            if(requestObject.IsSetElementId())
            {
                context.Writer.WritePropertyName("ElementId");
                context.Writer.WriteStringValue(requestObject.ElementId);
            }

            if(requestObject.IsSetElementType())
            {
                context.Writer.WritePropertyName("ElementType");
                context.Writer.WriteStringValue(requestObject.ElementType);
            }

            if(requestObject.IsSetRowIndex())
            {
                context.Writer.WritePropertyName("RowIndex");
                context.Writer.WriteNumberValue(requestObject.RowIndex.Value);
            }

            if(requestObject.IsSetRowSpan())
            {
                context.Writer.WritePropertyName("RowSpan");
                context.Writer.WriteNumberValue(requestObject.RowSpan.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GridLayoutElementMarshaller Instance = new GridLayoutElementMarshaller();

    }
}