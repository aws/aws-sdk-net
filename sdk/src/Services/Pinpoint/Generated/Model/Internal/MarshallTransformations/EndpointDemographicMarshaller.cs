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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EndpointDemographic Marshaller
    /// </summary>       
    public class EndpointDemographicMarshaller : IRequestMarshaller<EndpointDemographic, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EndpointDemographic requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAppVersion())
            {
                context.Writer.WritePropertyName("AppVersion");
                context.Writer.Write(requestObject.AppVersion);
            }

            if(requestObject.IsSetLocale())
            {
                context.Writer.WritePropertyName("Locale");
                context.Writer.Write(requestObject.Locale);
            }

            if(requestObject.IsSetMake())
            {
                context.Writer.WritePropertyName("Make");
                context.Writer.Write(requestObject.Make);
            }

            if(requestObject.IsSetModel())
            {
                context.Writer.WritePropertyName("Model");
                context.Writer.Write(requestObject.Model);
            }

            if(requestObject.IsSetModelVersion())
            {
                context.Writer.WritePropertyName("ModelVersion");
                context.Writer.Write(requestObject.ModelVersion);
            }

            if(requestObject.IsSetPlatform())
            {
                context.Writer.WritePropertyName("Platform");
                context.Writer.Write(requestObject.Platform);
            }

            if(requestObject.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("PlatformVersion");
                context.Writer.Write(requestObject.PlatformVersion);
            }

            if(requestObject.IsSetTimezone())
            {
                context.Writer.WritePropertyName("Timezone");
                context.Writer.Write(requestObject.Timezone);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EndpointDemographicMarshaller Instance = new EndpointDemographicMarshaller();

    }
}