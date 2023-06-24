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
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchGetAssetPropertyValueHistoryEntry Marshaller
    /// </summary>
    public class BatchGetAssetPropertyValueHistoryEntryMarshaller : IRequestMarshaller<BatchGetAssetPropertyValueHistoryEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchGetAssetPropertyValueHistoryEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssetId())
            {
                context.Writer.WritePropertyName("assetId");
                context.Writer.Write(requestObject.AssetId);
            }

            if(requestObject.IsSetEndDate())
            {
                context.Writer.WritePropertyName("endDate");
                context.Writer.Write(requestObject.EndDate);
            }

            if(requestObject.IsSetEntryId())
            {
                context.Writer.WritePropertyName("entryId");
                context.Writer.Write(requestObject.EntryId);
            }

            if(requestObject.IsSetPropertyAlias())
            {
                context.Writer.WritePropertyName("propertyAlias");
                context.Writer.Write(requestObject.PropertyAlias);
            }

            if(requestObject.IsSetPropertyId())
            {
                context.Writer.WritePropertyName("propertyId");
                context.Writer.Write(requestObject.PropertyId);
            }

            if(requestObject.IsSetQualities())
            {
                context.Writer.WritePropertyName("qualities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectQualitiesListValue in requestObject.Qualities)
                {
                        context.Writer.Write(requestObjectQualitiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStartDate())
            {
                context.Writer.WritePropertyName("startDate");
                context.Writer.Write(requestObject.StartDate);
            }

            if(requestObject.IsSetTimeOrdering())
            {
                context.Writer.WritePropertyName("timeOrdering");
                context.Writer.Write(requestObject.TimeOrdering);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchGetAssetPropertyValueHistoryEntryMarshaller Instance = new BatchGetAssetPropertyValueHistoryEntryMarshaller();

    }
}