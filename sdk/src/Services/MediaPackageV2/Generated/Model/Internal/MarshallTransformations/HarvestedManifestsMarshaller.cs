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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HarvestedManifests Marshaller
    /// </summary>
    public class HarvestedManifestsMarshaller : IRequestMarshaller<HarvestedManifests, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HarvestedManifests requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDashManifests())
            {
                context.Writer.WritePropertyName("DashManifests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDashManifestsListValue in requestObject.DashManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarvestedDashManifestMarshaller.Instance;
                    marshaller.Marshall(requestObjectDashManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetHlsManifests())
            {
                context.Writer.WritePropertyName("HlsManifests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHlsManifestsListValue in requestObject.HlsManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarvestedHlsManifestMarshaller.Instance;
                    marshaller.Marshall(requestObjectHlsManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLowLatencyHlsManifests())
            {
                context.Writer.WritePropertyName("LowLatencyHlsManifests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLowLatencyHlsManifestsListValue in requestObject.LowLatencyHlsManifests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarvestedLowLatencyHlsManifestMarshaller.Instance;
                    marshaller.Marshall(requestObjectLowLatencyHlsManifestsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HarvestedManifestsMarshaller Instance = new HarvestedManifestsMarshaller();

    }
}