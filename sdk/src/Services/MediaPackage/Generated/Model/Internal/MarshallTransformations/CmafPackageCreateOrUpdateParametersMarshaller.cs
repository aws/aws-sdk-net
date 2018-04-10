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
    /// CmafPackageCreateOrUpdateParameters Marshaller
    /// </summary>       
    public class CmafPackageCreateOrUpdateParametersMarshaller : IRequestMarshaller<CmafPackageCreateOrUpdateParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CmafPackageCreateOrUpdateParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteObjectStart();

                var marshaller = CmafEncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHlsManifests())
            {
                context.Writer.WritePropertyName("hlsManifests");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHlsManifestsListValue in requestObject.HlsManifests)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HlsManifestCreateOrUpdateParametersMarshaller.Instance;
                    marshaller.Marshall(requestObjectHlsManifestsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSegmentDurationSeconds())
            {
                context.Writer.WritePropertyName("segmentDurationSeconds");
                context.Writer.Write(requestObject.SegmentDurationSeconds);
            }

            if(requestObject.IsSetSegmentPrefix())
            {
                context.Writer.WritePropertyName("segmentPrefix");
                context.Writer.Write(requestObject.SegmentPrefix);
            }

            if(requestObject.IsSetStreamSelection())
            {
                context.Writer.WritePropertyName("streamSelection");
                context.Writer.WriteObjectStart();

                var marshaller = StreamSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamSelection, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CmafPackageCreateOrUpdateParametersMarshaller Instance = new CmafPackageCreateOrUpdateParametersMarshaller();

    }
}