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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteObjectStart();

                var marshaller = DashEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetManifestWindowSeconds())
            {
                context.Writer.WritePropertyName("manifestWindowSeconds");
                context.Writer.Write(requestObject.ManifestWindowSeconds);
            }

            if(requestObject.IsSetMinBufferTimeSeconds())
            {
                context.Writer.WritePropertyName("minBufferTimeSeconds");
                context.Writer.Write(requestObject.MinBufferTimeSeconds);
            }

            if(requestObject.IsSetMinUpdatePeriodSeconds())
            {
                context.Writer.WritePropertyName("minUpdatePeriodSeconds");
                context.Writer.Write(requestObject.MinUpdatePeriodSeconds);
            }

            if(requestObject.IsSetProfile())
            {
                context.Writer.WritePropertyName("profile");
                context.Writer.Write(requestObject.Profile);
            }

            if(requestObject.IsSetSegmentDurationSeconds())
            {
                context.Writer.WritePropertyName("segmentDurationSeconds");
                context.Writer.Write(requestObject.SegmentDurationSeconds);
            }

            if(requestObject.IsSetStreamSelection())
            {
                context.Writer.WritePropertyName("streamSelection");
                context.Writer.WriteObjectStart();

                var marshaller = StreamSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamSelection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuggestedPresentationDelaySeconds())
            {
                context.Writer.WritePropertyName("suggestedPresentationDelaySeconds");
                context.Writer.Write(requestObject.SuggestedPresentationDelaySeconds);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DashPackageMarshaller Instance = new DashPackageMarshaller();

    }
}