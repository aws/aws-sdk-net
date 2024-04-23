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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipeLogConfiguration Object
    /// </summary>  
    public class PipeLogConfigurationUnmarshaller : IUnmarshaller<PipeLogConfiguration, XmlUnmarshallerContext>, IUnmarshaller<PipeLogConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PipeLogConfiguration IUnmarshaller<PipeLogConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PipeLogConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            PipeLogConfiguration unmarshalledObject = new PipeLogConfiguration();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudwatchLogsLogDestination", targetDepth))
                {
                    var unmarshaller = CloudwatchLogsLogDestinationUnmarshaller.Instance;
                    unmarshalledObject.CloudwatchLogsLogDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FirehoseLogDestination", targetDepth))
                {
                    var unmarshaller = FirehoseLogDestinationUnmarshaller.Instance;
                    unmarshalledObject.FirehoseLogDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeExecutionData", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IncludeExecutionData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Level", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Level = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3LogDestination", targetDepth))
                {
                    var unmarshaller = S3LogDestinationUnmarshaller.Instance;
                    unmarshalledObject.S3LogDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PipeLogConfigurationUnmarshaller _instance = new PipeLogConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PipeLogConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618