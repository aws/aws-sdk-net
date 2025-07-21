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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConnectionPropertiesOutput Object
    /// </summary>  
    public class ConnectionPropertiesOutputUnmarshaller : IJsonUnmarshaller<ConnectionPropertiesOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConnectionPropertiesOutput Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConnectionPropertiesOutput unmarshalledObject = new ConnectionPropertiesOutput();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("athenaProperties", targetDepth))
                {
                    var unmarshaller = AthenaPropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.AthenaProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("glueProperties", targetDepth))
                {
                    var unmarshaller = GluePropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.GlueProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hyperPodProperties", targetDepth))
                {
                    var unmarshaller = HyperPodPropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.HyperPodProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iamProperties", targetDepth))
                {
                    var unmarshaller = IamPropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.IamProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("redshiftProperties", targetDepth))
                {
                    var unmarshaller = RedshiftPropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.RedshiftProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("s3Properties", targetDepth))
                {
                    var unmarshaller = S3PropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.S3Properties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sparkEmrProperties", targetDepth))
                {
                    var unmarshaller = SparkEmrPropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.SparkEmrProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sparkGlueProperties", targetDepth))
                {
                    var unmarshaller = SparkGluePropertiesOutputUnmarshaller.Instance;
                    unmarshalledObject.SparkGlueProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConnectionPropertiesOutputUnmarshaller _instance = new ConnectionPropertiesOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConnectionPropertiesOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}