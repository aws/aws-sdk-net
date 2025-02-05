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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SourceDescription Object
    /// </summary>  
    public class SourceDescriptionUnmarshaller : IJsonUnmarshaller<SourceDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SourceDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SourceDescription unmarshalledObject = new SourceDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DatabaseSourceDescription", targetDepth))
                {
                    var unmarshaller = DatabaseSourceDescriptionUnmarshaller.Instance;
                    unmarshalledObject.DatabaseSourceDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DirectPutSourceDescription", targetDepth))
                {
                    var unmarshaller = DirectPutSourceDescriptionUnmarshaller.Instance;
                    unmarshalledObject.DirectPutSourceDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KinesisStreamSourceDescription", targetDepth))
                {
                    var unmarshaller = KinesisStreamSourceDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KinesisStreamSourceDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MSKSourceDescription", targetDepth))
                {
                    var unmarshaller = MSKSourceDescriptionUnmarshaller.Instance;
                    unmarshalledObject.MSKSourceDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SourceDescriptionUnmarshaller _instance = new SourceDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SourceDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}