/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NoiseReducer Marshaller
    /// </summary>       
    public class NoiseReducerMarshaller : IRequestMarshaller<NoiseReducer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NoiseReducer requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("filter");
                context.Writer.Write(requestObject.Filter);
            }

            if(requestObject.IsSetFilterSettings())
            {
                context.Writer.WritePropertyName("filterSettings");
                context.Writer.WriteObjectStart();

                var marshaller = NoiseReducerFilterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSpatialFilterSettings())
            {
                context.Writer.WritePropertyName("spatialFilterSettings");
                context.Writer.WriteObjectStart();

                var marshaller = NoiseReducerSpatialFilterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SpatialFilterSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static NoiseReducerMarshaller Instance = new NoiseReducerMarshaller();

    }
}