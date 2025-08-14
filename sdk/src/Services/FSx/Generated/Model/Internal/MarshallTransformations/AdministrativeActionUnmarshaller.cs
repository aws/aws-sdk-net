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

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AdministrativeAction Object
    /// </summary>  
    public class AdministrativeActionUnmarshaller : IUnmarshaller<AdministrativeAction, XmlUnmarshallerContext>, IUnmarshaller<AdministrativeAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AdministrativeAction IUnmarshaller<AdministrativeAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AdministrativeAction Unmarshall(JsonUnmarshallerContext context)
        {
            AdministrativeAction unmarshalledObject = new AdministrativeAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdministrativeActionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdministrativeActionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureDetails", targetDepth))
                {
                    var unmarshaller = AdministrativeActionFailureDetailsUnmarshaller.Instance;
                    unmarshalledObject.FailureDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProgressPercent", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ProgressPercent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RemainingTransferBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.RemainingTransferBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RequestTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetFileSystemValues", targetDepth))
                {
                    var unmarshaller = FileSystemUnmarshaller.Instance;
                    unmarshalledObject.TargetFileSystemValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetSnapshotValues", targetDepth))
                {
                    var unmarshaller = SnapshotUnmarshaller.Instance;
                    unmarshalledObject.TargetSnapshotValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetVolumeValues", targetDepth))
                {
                    var unmarshaller = VolumeUnmarshaller.Instance;
                    unmarshalledObject.TargetVolumeValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalTransferBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalTransferBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AdministrativeActionUnmarshaller _instance = new AdministrativeActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdministrativeActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}