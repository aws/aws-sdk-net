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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageVod.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackageVod.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DashPackage Marshaller
    /// </summary>
    public class DashPackageMarshaller : IRequestMarshaller<DashPackage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DashPackage requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDashManifests())
            {
                context.Writer.WritePropertyName("dashManifests");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDashManifestsListValue in requestObject.DashManifests)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DashManifestMarshaller.Instance;
                    marshaller.Marshall(requestObjectDashManifestsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteObjectStart();

                var marshaller = DashEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIncludeEncoderConfigurationInSegments())
            {
                context.Writer.WritePropertyName("includeEncoderConfigurationInSegments");
                context.Writer.Write(requestObject.IncludeEncoderConfigurationInSegments);
            }

            if(requestObject.IsSetIncludeIframeOnlyStream())
            {
                context.Writer.WritePropertyName("includeIframeOnlyStream");
                context.Writer.Write(requestObject.IncludeIframeOnlyStream);
            }

            if(requestObject.IsSetPeriodTriggers())
            {
                context.Writer.WritePropertyName("periodTriggers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPeriodTriggersListValue in requestObject.PeriodTriggers)
                {
                        context.Writer.Write(requestObjectPeriodTriggersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSegmentDurationSeconds())
            {
                context.Writer.WritePropertyName("segmentDurationSeconds");
                context.Writer.Write(requestObject.SegmentDurationSeconds);
            }

            if(requestObject.IsSetSegmentTemplateFormat())
            {
                context.Writer.WritePropertyName("segmentTemplateFormat");
                context.Writer.Write(requestObject.SegmentTemplateFormat);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DashPackageMarshaller Instance = new DashPackageMarshaller();

    }
}