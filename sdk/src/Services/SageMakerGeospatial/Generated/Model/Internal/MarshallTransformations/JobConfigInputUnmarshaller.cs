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
using System.Net;
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
    /// Response Unmarshaller for JobConfigInput Object
    /// </summary>  
    public class JobConfigInputUnmarshaller : IUnmarshaller<JobConfigInput, XmlUnmarshallerContext>, IUnmarshaller<JobConfigInput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobConfigInput IUnmarshaller<JobConfigInput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobConfigInput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            JobConfigInput unmarshalledObject = new JobConfigInput();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BandMathConfig", targetDepth))
                {
                    var unmarshaller = BandMathConfigInputUnmarshaller.Instance;
                    unmarshalledObject.BandMathConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudMaskingConfig", targetDepth))
                {
                    var unmarshaller = CloudMaskingConfigInputUnmarshaller.Instance;
                    unmarshalledObject.CloudMaskingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudRemovalConfig", targetDepth))
                {
                    var unmarshaller = CloudRemovalConfigInputUnmarshaller.Instance;
                    unmarshalledObject.CloudRemovalConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeoMosaicConfig", targetDepth))
                {
                    var unmarshaller = GeoMosaicConfigInputUnmarshaller.Instance;
                    unmarshalledObject.GeoMosaicConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LandCoverSegmentationConfig", targetDepth))
                {
                    var unmarshaller = LandCoverSegmentationConfigInputUnmarshaller.Instance;
                    unmarshalledObject.LandCoverSegmentationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResamplingConfig", targetDepth))
                {
                    var unmarshaller = ResamplingConfigInputUnmarshaller.Instance;
                    unmarshalledObject.ResamplingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StackConfig", targetDepth))
                {
                    var unmarshaller = StackConfigInputUnmarshaller.Instance;
                    unmarshalledObject.StackConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TemporalStatisticsConfig", targetDepth))
                {
                    var unmarshaller = TemporalStatisticsConfigInputUnmarshaller.Instance;
                    unmarshalledObject.TemporalStatisticsConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ZonalStatisticsConfig", targetDepth))
                {
                    var unmarshaller = ZonalStatisticsConfigInputUnmarshaller.Instance;
                    unmarshalledObject.ZonalStatisticsConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobConfigInputUnmarshaller _instance = new JobConfigInputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobConfigInputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}