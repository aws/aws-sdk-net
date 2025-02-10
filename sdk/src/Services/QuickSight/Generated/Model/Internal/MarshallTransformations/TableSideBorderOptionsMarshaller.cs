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
    /// TableSideBorderOptions Marshaller
    /// </summary>
    public class TableSideBorderOptionsMarshaller : IRequestMarshaller<TableSideBorderOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableSideBorderOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBottom())
            {
                context.Writer.WritePropertyName("Bottom");
                context.Writer.WriteStartObject();

                var marshaller = TableBorderOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Bottom, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInnerHorizontal())
            {
                context.Writer.WritePropertyName("InnerHorizontal");
                context.Writer.WriteStartObject();

                var marshaller = TableBorderOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.InnerHorizontal, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInnerVertical())
            {
                context.Writer.WritePropertyName("InnerVertical");
                context.Writer.WriteStartObject();

                var marshaller = TableBorderOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.InnerVertical, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLeft())
            {
                context.Writer.WritePropertyName("Left");
                context.Writer.WriteStartObject();

                var marshaller = TableBorderOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Left, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRight())
            {
                context.Writer.WritePropertyName("Right");
                context.Writer.WriteStartObject();

                var marshaller = TableBorderOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Right, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTop())
            {
                context.Writer.WritePropertyName("Top");
                context.Writer.WriteStartObject();

                var marshaller = TableBorderOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Top, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableSideBorderOptionsMarshaller Instance = new TableSideBorderOptionsMarshaller();

    }
}