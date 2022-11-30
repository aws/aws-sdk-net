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
    /// InputConfigInput Marshaller
    /// </summary>
    public class InputConfigInputMarshaller : IRequestMarshaller<InputConfigInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InputConfigInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataSourceConfig())
            {
                context.Writer.WritePropertyName("DataSourceConfig");
                context.Writer.WriteObjectStart();

                var marshaller = EojDataSourceConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSourceConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPreviousEarthObservationJobArn())
            {
                context.Writer.WritePropertyName("PreviousEarthObservationJobArn");
                context.Writer.Write(requestObject.PreviousEarthObservationJobArn);
            }

            if(requestObject.IsSetRasterDataCollectionQuery())
            {
                context.Writer.WritePropertyName("RasterDataCollectionQuery");
                context.Writer.WriteObjectStart();

                var marshaller = RasterDataCollectionQueryInputMarshaller.Instance;
                marshaller.Marshall(requestObject.RasterDataCollectionQuery, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputConfigInputMarshaller Instance = new InputConfigInputMarshaller();

    }
}