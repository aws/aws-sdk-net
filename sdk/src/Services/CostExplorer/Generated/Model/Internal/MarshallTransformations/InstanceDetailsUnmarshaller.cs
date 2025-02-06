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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceDetails Object
    /// </summary>  
    public class InstanceDetailsUnmarshaller : IJsonUnmarshaller<InstanceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InstanceDetails unmarshalledObject = new InstanceDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("EC2InstanceDetails", targetDepth))
                {
                    var unmarshaller = EC2InstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.EC2InstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ElastiCacheInstanceDetails", targetDepth))
                {
                    var unmarshaller = ElastiCacheInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.ElastiCacheInstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ESInstanceDetails", targetDepth))
                {
                    var unmarshaller = ESInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.ESInstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MemoryDBInstanceDetails", targetDepth))
                {
                    var unmarshaller = MemoryDBInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.MemoryDBInstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RDSInstanceDetails", targetDepth))
                {
                    var unmarshaller = RDSInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.RDSInstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RedshiftInstanceDetails", targetDepth))
                {
                    var unmarshaller = RedshiftInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.RedshiftInstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceDetailsUnmarshaller _instance = new InstanceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}