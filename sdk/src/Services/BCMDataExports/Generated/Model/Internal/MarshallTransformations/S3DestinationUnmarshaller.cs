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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDataExports.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDataExports.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3Destination Object
    /// </summary>  
    public class S3DestinationUnmarshaller : IJsonUnmarshaller<S3Destination, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public S3Destination Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            S3Destination unmarshalledObject = new S3Destination();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("S3Bucket", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3Bucket = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3OutputConfigurations", targetDepth))
                {
                    var unmarshaller = S3OutputConfigurationsUnmarshaller.Instance;
                    unmarshalledObject.S3OutputConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Prefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3Prefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static S3DestinationUnmarshaller _instance = new S3DestinationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3DestinationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}