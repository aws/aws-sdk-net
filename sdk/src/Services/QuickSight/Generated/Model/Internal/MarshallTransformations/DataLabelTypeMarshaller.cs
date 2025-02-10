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
    /// DataLabelType Marshaller
    /// </summary>
    public class DataLabelTypeMarshaller : IRequestMarshaller<DataLabelType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataLabelType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataPathLabelType())
            {
                context.Writer.WritePropertyName("DataPathLabelType");
                context.Writer.WriteStartObject();

                var marshaller = DataPathLabelTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.DataPathLabelType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFieldLabelType())
            {
                context.Writer.WritePropertyName("FieldLabelType");
                context.Writer.WriteStartObject();

                var marshaller = FieldLabelTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldLabelType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaximumLabelType())
            {
                context.Writer.WritePropertyName("MaximumLabelType");
                context.Writer.WriteStartObject();

                var marshaller = MaximumLabelTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.MaximumLabelType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMinimumLabelType())
            {
                context.Writer.WritePropertyName("MinimumLabelType");
                context.Writer.WriteStartObject();

                var marshaller = MinimumLabelTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.MinimumLabelType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRangeEndsLabelType())
            {
                context.Writer.WritePropertyName("RangeEndsLabelType");
                context.Writer.WriteStartObject();

                var marshaller = RangeEndsLabelTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.RangeEndsLabelType, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataLabelTypeMarshaller Instance = new DataLabelTypeMarshaller();

    }
}