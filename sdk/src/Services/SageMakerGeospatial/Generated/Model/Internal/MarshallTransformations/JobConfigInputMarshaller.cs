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
    /// JobConfigInput Marshaller
    /// </summary>
    public class JobConfigInputMarshaller : IRequestMarshaller<JobConfigInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobConfigInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBandMathConfig())
            {
                context.Writer.WritePropertyName("BandMathConfig");
                context.Writer.WriteObjectStart();

                var marshaller = BandMathConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.BandMathConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCloudMaskingConfig())
            {
                context.Writer.WritePropertyName("CloudMaskingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = CloudMaskingConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudMaskingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCloudRemovalConfig())
            {
                context.Writer.WritePropertyName("CloudRemovalConfig");
                context.Writer.WriteObjectStart();

                var marshaller = CloudRemovalConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudRemovalConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGeoMosaicConfig())
            {
                context.Writer.WritePropertyName("GeoMosaicConfig");
                context.Writer.WriteObjectStart();

                var marshaller = GeoMosaicConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.GeoMosaicConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLandCoverSegmentationConfig())
            {
                context.Writer.WritePropertyName("LandCoverSegmentationConfig");
                context.Writer.WriteObjectStart();

                var marshaller = LandCoverSegmentationConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.LandCoverSegmentationConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResamplingConfig())
            {
                context.Writer.WritePropertyName("ResamplingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ResamplingConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ResamplingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStackConfig())
            {
                context.Writer.WritePropertyName("StackConfig");
                context.Writer.WriteObjectStart();

                var marshaller = StackConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.StackConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTemporalStatisticsConfig())
            {
                context.Writer.WritePropertyName("TemporalStatisticsConfig");
                context.Writer.WriteObjectStart();

                var marshaller = TemporalStatisticsConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.TemporalStatisticsConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetZonalStatisticsConfig())
            {
                context.Writer.WritePropertyName("ZonalStatisticsConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ZonalStatisticsConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ZonalStatisticsConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobConfigInputMarshaller Instance = new JobConfigInputMarshaller();

    }
}