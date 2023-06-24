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
    /// Property Marshaller
    /// </summary>
    public class PropertyMarshaller : IRequestMarshaller<Property, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Property requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEoCloudCover())
            {
                context.Writer.WritePropertyName("EoCloudCover");
                context.Writer.WriteObjectStart();

                var marshaller = EoCloudCoverInputMarshaller.Instance;
                marshaller.Marshall(requestObject.EoCloudCover, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLandsatCloudCoverLand())
            {
                context.Writer.WritePropertyName("LandsatCloudCoverLand");
                context.Writer.WriteObjectStart();

                var marshaller = LandsatCloudCoverLandInputMarshaller.Instance;
                marshaller.Marshall(requestObject.LandsatCloudCoverLand, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlatform())
            {
                context.Writer.WritePropertyName("Platform");
                context.Writer.WriteObjectStart();

                var marshaller = PlatformInputMarshaller.Instance;
                marshaller.Marshall(requestObject.Platform, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetViewOffNadir())
            {
                context.Writer.WritePropertyName("ViewOffNadir");
                context.Writer.WriteObjectStart();

                var marshaller = ViewOffNadirInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ViewOffNadir, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetViewSunAzimuth())
            {
                context.Writer.WritePropertyName("ViewSunAzimuth");
                context.Writer.WriteObjectStart();

                var marshaller = ViewSunAzimuthInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ViewSunAzimuth, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetViewSunElevation())
            {
                context.Writer.WritePropertyName("ViewSunElevation");
                context.Writer.WriteObjectStart();

                var marshaller = ViewSunElevationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ViewSunElevation, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PropertyMarshaller Instance = new PropertyMarshaller();

    }
}