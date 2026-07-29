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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSearchesFilters Marshaller
    /// </summary>
    public class ListSearchesFiltersMarshaller : IRequestMarshaller<ListSearchesFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListSearchesFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGroupIdFilter())
            {
                context.Writer.WritePropertyName("groupIdFilter");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGroupIdFilterListValue in requestObject.GroupIdFilter)
                {
                        context.Writer.WriteStringValue(requestObjectGroupIdFilterListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSearchTypeFilter())
            {
                context.Writer.WritePropertyName("searchTypeFilter");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSearchTypeFilterListValue in requestObject.SearchTypeFilter)
                {
                        context.Writer.WriteStringValue(requestObjectSearchTypeFilterListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStartedAfter())
            {
                context.Writer.WritePropertyName("startedAfter");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.StartedAfter.Value)));
            }

            if(requestObject.IsSetStartedBefore())
            {
                context.Writer.WritePropertyName("startedBefore");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.StartedBefore.Value)));
            }

            if(requestObject.IsSetStatusFilter())
            {
                context.Writer.WritePropertyName("statusFilter");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStatusFilterListValue in requestObject.StatusFilter)
                {
                        context.Writer.WriteStringValue(requestObjectStatusFilterListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListSearchesFiltersMarshaller Instance = new ListSearchesFiltersMarshaller();

    }
}