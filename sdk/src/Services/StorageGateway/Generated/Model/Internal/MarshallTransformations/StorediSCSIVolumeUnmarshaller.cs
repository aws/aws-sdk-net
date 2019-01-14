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
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StorediSCSIVolume Object
    /// </summary>  
    public class StorediSCSIVolumeUnmarshaller : IUnmarshaller<StorediSCSIVolume, XmlUnmarshallerContext>, IUnmarshaller<StorediSCSIVolume, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StorediSCSIVolume IUnmarshaller<StorediSCSIVolume, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StorediSCSIVolume Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StorediSCSIVolume unmarshalledObject = new StorediSCSIVolume();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreatedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KMSKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KMSKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreservedExistingData", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PreservedExistingData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceSnapshotId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceSnapshotId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeAttachmentStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeAttachmentStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeDiskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeDiskId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeiSCSIAttributes", targetDepth))
                {
                    var unmarshaller = VolumeiSCSIAttributesUnmarshaller.Instance;
                    unmarshalledObject.VolumeiSCSIAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeProgress", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.VolumeProgress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeSizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.VolumeSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeUsedInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.VolumeUsedInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StorediSCSIVolumeUnmarshaller _instance = new StorediSCSIVolumeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StorediSCSIVolumeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}