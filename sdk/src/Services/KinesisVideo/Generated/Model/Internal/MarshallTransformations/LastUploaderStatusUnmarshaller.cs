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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisVideo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LastUploaderStatus Object
    /// </summary>  
    public class LastUploaderStatusUnmarshaller : IUnmarshaller<LastUploaderStatus, XmlUnmarshallerContext>, IUnmarshaller<LastUploaderStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LastUploaderStatus IUnmarshaller<LastUploaderStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LastUploaderStatus Unmarshall(JsonUnmarshallerContext context)
        {
            LastUploaderStatus unmarshalledObject = new LastUploaderStatus();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("JobStatusDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobStatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastCollectedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastCollectedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UploaderStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UploaderStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LastUploaderStatusUnmarshaller _instance = new LastUploaderStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LastUploaderStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618