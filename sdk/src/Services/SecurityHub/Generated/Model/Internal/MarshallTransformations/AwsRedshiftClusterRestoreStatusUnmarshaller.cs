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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsRedshiftClusterRestoreStatus Object
    /// </summary>  
    public class AwsRedshiftClusterRestoreStatusUnmarshaller : IUnmarshaller<AwsRedshiftClusterRestoreStatus, XmlUnmarshallerContext>, IUnmarshaller<AwsRedshiftClusterRestoreStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsRedshiftClusterRestoreStatus IUnmarshaller<AwsRedshiftClusterRestoreStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsRedshiftClusterRestoreStatus Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsRedshiftClusterRestoreStatus unmarshalledObject = new AwsRedshiftClusterRestoreStatus();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrentRestoreRateInMegaBytesPerSecond", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.CurrentRestoreRateInMegaBytesPerSecond = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElapsedTimeInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ElapsedTimeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EstimatedTimeToCompletionInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.EstimatedTimeToCompletionInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProgressInMegaBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ProgressInMegaBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotSizeInMegaBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SnapshotSizeInMegaBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsRedshiftClusterRestoreStatusUnmarshaller _instance = new AwsRedshiftClusterRestoreStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsRedshiftClusterRestoreStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}