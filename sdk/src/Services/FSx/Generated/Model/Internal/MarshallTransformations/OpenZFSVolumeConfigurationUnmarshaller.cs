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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpenZFSVolumeConfiguration Object
    /// </summary>  
    public class OpenZFSVolumeConfigurationUnmarshaller : IUnmarshaller<OpenZFSVolumeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<OpenZFSVolumeConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OpenZFSVolumeConfiguration IUnmarshaller<OpenZFSVolumeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OpenZFSVolumeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OpenZFSVolumeConfiguration unmarshalledObject = new OpenZFSVolumeConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CopyTagsToSnapshots", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTagsToSnapshots = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataCompressionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataCompressionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeleteClonedVolumes", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeleteClonedVolumes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeleteIntermediateSnaphots", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeleteIntermediateSnaphots = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NfsExports", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OpenZFSNfsExport, OpenZFSNfsExportUnmarshaller>(OpenZFSNfsExportUnmarshaller.Instance);
                    unmarshalledObject.NfsExports = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OriginSnapshot", targetDepth))
                {
                    var unmarshaller = OpenZFSOriginSnapshotConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OriginSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParentVolumeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentVolumeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReadOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ReadOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordSizeKiB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RecordSizeKiB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RestoreToSnapshot", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RestoreToSnapshot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageCapacityQuotaGiB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StorageCapacityQuotaGiB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageCapacityReservationGiB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StorageCapacityReservationGiB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserAndGroupQuotas", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OpenZFSUserOrGroupQuota, OpenZFSUserOrGroupQuotaUnmarshaller>(OpenZFSUserOrGroupQuotaUnmarshaller.Instance);
                    unmarshalledObject.UserAndGroupQuotas = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumePath = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OpenZFSVolumeConfigurationUnmarshaller _instance = new OpenZFSVolumeConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpenZFSVolumeConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}