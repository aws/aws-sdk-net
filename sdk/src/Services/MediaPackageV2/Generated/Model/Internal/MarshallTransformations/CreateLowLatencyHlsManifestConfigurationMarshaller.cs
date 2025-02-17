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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLowLatencyHlsManifestConfiguration Marshaller
    /// </summary>
    public class CreateLowLatencyHlsManifestConfigurationMarshaller : IRequestMarshaller<CreateLowLatencyHlsManifestConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateLowLatencyHlsManifestConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChildManifestName())
            {
                context.Writer.WritePropertyName("ChildManifestName");
                context.Writer.Write(requestObject.ChildManifestName);
            }

            if(requestObject.IsSetFilterConfiguration())
            {
                context.Writer.WritePropertyName("FilterConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FilterConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetManifestName())
            {
                context.Writer.WritePropertyName("ManifestName");
                context.Writer.Write(requestObject.ManifestName);
            }

            if(requestObject.IsSetManifestWindowSeconds())
            {
                context.Writer.WritePropertyName("ManifestWindowSeconds");
                context.Writer.Write(requestObject.ManifestWindowSeconds);
            }

            if(requestObject.IsSetProgramDateTimeIntervalSeconds())
            {
                context.Writer.WritePropertyName("ProgramDateTimeIntervalSeconds");
                context.Writer.Write(requestObject.ProgramDateTimeIntervalSeconds);
            }

            if(requestObject.IsSetScteHls())
            {
                context.Writer.WritePropertyName("ScteHls");
                context.Writer.WriteObjectStart();

                var marshaller = ScteHlsMarshaller.Instance;
                marshaller.Marshall(requestObject.ScteHls, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStartTag())
            {
                context.Writer.WritePropertyName("StartTag");
                context.Writer.WriteObjectStart();

                var marshaller = StartTagMarshaller.Instance;
                marshaller.Marshall(requestObject.StartTag, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateLowLatencyHlsManifestConfigurationMarshaller Instance = new CreateLowLatencyHlsManifestConfigurationMarshaller();

    }
}