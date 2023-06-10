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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Scan Object
    /// </summary>  
    public class ScanUnmarshaller : IUnmarshaller<Scan, XmlUnmarshallerContext>, IUnmarshaller<Scan, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Scan IUnmarshaller<Scan, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Scan Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Scan unmarshalledObject = new Scan();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("adminDetectorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdminDetectorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("attachedVolumes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<VolumeDetail, VolumeDetailUnmarshaller>(VolumeDetailUnmarshaller.Instance);
                    unmarshalledObject.AttachedVolumes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("detectorId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DetectorId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.FileCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceDetails", targetDepth))
                {
                    var unmarshaller = ResourceDetailsUnmarshaller.Instance;
                    unmarshalledObject.ResourceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ScanEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanResultDetails", targetDepth))
                {
                    var unmarshaller = ScanResultDetailsUnmarshaller.Instance;
                    unmarshalledObject.ScanResultDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ScanStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("triggerDetails", targetDepth))
                {
                    var unmarshaller = TriggerDetailsUnmarshaller.Instance;
                    unmarshalledObject.TriggerDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ScanUnmarshaller _instance = new ScanUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScanUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}