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
    /// FilterRelativeDateTimeControl Marshaller
    /// </summary>
    public class FilterRelativeDateTimeControlMarshaller : IRequestMarshaller<FilterRelativeDateTimeControl, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FilterRelativeDateTimeControl requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDisplayOptions())
            {
                context.Writer.WritePropertyName("DisplayOptions");
                context.Writer.WriteObjectStart();

                var marshaller = RelativeDateTimeControlDisplayOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DisplayOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilterControlId())
            {
                context.Writer.WritePropertyName("FilterControlId");
                context.Writer.Write(requestObject.FilterControlId);
            }

            if(requestObject.IsSetSourceFilterId())
            {
                context.Writer.WritePropertyName("SourceFilterId");
                context.Writer.Write(requestObject.SourceFilterId);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterRelativeDateTimeControlMarshaller Instance = new FilterRelativeDateTimeControlMarshaller();

    }
}