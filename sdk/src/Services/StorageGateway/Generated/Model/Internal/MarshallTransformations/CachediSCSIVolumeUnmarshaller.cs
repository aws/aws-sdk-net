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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CachediSCSIVolume Object
    /// </summary>  
    public class CachediSCSIVolumeUnmarshaller : IJsonUnmarshaller<CachediSCSIVolume, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CachediSCSIVolume Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CachediSCSIVolume unmarshalledObject = new CachediSCSIVolume();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CreatedDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KMSKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KMSKey = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceSnapshotId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceSnapshotId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeARN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeAttachmentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeAttachmentStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeiSCSIAttributes", targetDepth))
                {
                    var unmarshaller = VolumeiSCSIAttributesUnmarshaller.Instance;
                    unmarshalledObject.VolumeiSCSIAttributes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeProgress", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.VolumeProgress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeSizeInBytes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.VolumeSizeInBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VolumeUsedInBytes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.VolumeUsedInBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CachediSCSIVolumeUnmarshaller _instance = new CachediSCSIVolumeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CachediSCSIVolumeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}