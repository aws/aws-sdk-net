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
    /// DashIsoGroupSettings Marshaller
    /// </summary>       
    public class DashIsoGroupSettingsMarshaller : IRequestMarshaller<DashIsoGroupSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DashIsoGroupSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBaseUrl())
            {
                context.Writer.WritePropertyName("baseUrl");
                context.Writer.Write(requestObject.BaseUrl);
            }

            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("destination");
                context.Writer.Write(requestObject.Destination);
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteObjectStart();

                var marshaller = DashIsoEncryptionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFragmentLength())
            {
                context.Writer.WritePropertyName("fragmentLength");
                context.Writer.Write(requestObject.FragmentLength);
            }

            if(requestObject.IsSetHbbtvCompliance())
            {
                context.Writer.WritePropertyName("hbbtvCompliance");
                context.Writer.Write(requestObject.HbbtvCompliance);
            }

            if(requestObject.IsSetMinBufferTime())
            {
                context.Writer.WritePropertyName("minBufferTime");
                context.Writer.Write(requestObject.MinBufferTime);
            }

            if(requestObject.IsSetSegmentControl())
            {
                context.Writer.WritePropertyName("segmentControl");
                context.Writer.Write(requestObject.SegmentControl);
            }

            if(requestObject.IsSetSegmentLength())
            {
                context.Writer.WritePropertyName("segmentLength");
                context.Writer.Write(requestObject.SegmentLength);
            }

            if(requestObject.IsSetWriteSegmentTimelineInRepresentation())
            {
                context.Writer.WritePropertyName("writeSegmentTimelineInRepresentation");
                context.Writer.Write(requestObject.WriteSegmentTimelineInRepresentation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DashIsoGroupSettingsMarshaller Instance = new DashIsoGroupSettingsMarshaller();

    }
}