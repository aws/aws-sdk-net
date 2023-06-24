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
    /// FilterGroup Marshaller
    /// </summary>
    public class FilterGroupMarshaller : IRequestMarshaller<FilterGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FilterGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCrossDataset())
            {
                context.Writer.WritePropertyName("CrossDataset");
                context.Writer.Write(requestObject.CrossDataset);
            }

            if(requestObject.IsSetFilterGroupId())
            {
                context.Writer.WritePropertyName("FilterGroupId");
                context.Writer.Write(requestObject.FilterGroupId);
            }

            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFiltersListValue in requestObject.Filters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScopeConfiguration())
            {
                context.Writer.WritePropertyName("ScopeConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FilterScopeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ScopeConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FilterGroupMarshaller Instance = new FilterGroupMarshaller();

    }
}