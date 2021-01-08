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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SplunkDestinationDescription Object
    /// </summary>  
    public class SplunkDestinationDescriptionUnmarshaller : IUnmarshaller<SplunkDestinationDescription, XmlUnmarshallerContext>, IUnmarshaller<SplunkDestinationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SplunkDestinationDescription IUnmarshaller<SplunkDestinationDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SplunkDestinationDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SplunkDestinationDescription unmarshalledObject = new SplunkDestinationDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchLoggingOptions", targetDepth))
                {
                    var unmarshaller = CloudWatchLoggingOptionsUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchLoggingOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HECAcknowledgmentTimeoutInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.HECAcknowledgmentTimeoutInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HECEndpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HECEndpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HECEndpointType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HECEndpointType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HECToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HECToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProcessingConfiguration", targetDepth))
                {
                    var unmarshaller = ProcessingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProcessingConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetryOptions", targetDepth))
                {
                    var unmarshaller = SplunkRetryOptionsUnmarshaller.Instance;
                    unmarshalledObject.RetryOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3BackupMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3BackupMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DestinationDescription", targetDepth))
                {
                    var unmarshaller = S3DestinationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.S3DestinationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SplunkDestinationDescriptionUnmarshaller _instance = new SplunkDestinationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SplunkDestinationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}