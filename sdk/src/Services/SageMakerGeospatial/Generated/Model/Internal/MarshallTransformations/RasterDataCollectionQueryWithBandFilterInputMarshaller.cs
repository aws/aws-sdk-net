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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerGeospatial.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RasterDataCollectionQueryWithBandFilterInput Marshaller
    /// </summary>
    public class RasterDataCollectionQueryWithBandFilterInputMarshaller : IRequestMarshaller<RasterDataCollectionQueryWithBandFilterInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RasterDataCollectionQueryWithBandFilterInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAreaOfInterest())
            {
                context.Writer.WritePropertyName("AreaOfInterest");
                context.Writer.WriteObjectStart();

                var marshaller = AreaOfInterestMarshaller.Instance;
                marshaller.Marshall(requestObject.AreaOfInterest, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBandFilter())
            {
                context.Writer.WritePropertyName("BandFilter");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBandFilterListValue in requestObject.BandFilter)
                {
                        context.Writer.Write(requestObjectBandFilterListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPropertyFilters())
            {
                context.Writer.WritePropertyName("PropertyFilters");
                context.Writer.WriteObjectStart();

                var marshaller = PropertyFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.PropertyFilters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeRangeFilter())
            {
                context.Writer.WritePropertyName("TimeRangeFilter");
                context.Writer.WriteObjectStart();

                var marshaller = TimeRangeFilterInputMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeRangeFilter, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RasterDataCollectionQueryWithBandFilterInputMarshaller Instance = new RasterDataCollectionQueryWithBandFilterInputMarshaller();

    }
}