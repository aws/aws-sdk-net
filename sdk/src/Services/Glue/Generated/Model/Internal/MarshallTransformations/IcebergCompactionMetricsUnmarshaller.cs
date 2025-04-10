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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IcebergCompactionMetrics Object
    /// </summary>  
    public class IcebergCompactionMetricsUnmarshaller : IUnmarshaller<IcebergCompactionMetrics, XmlUnmarshallerContext>, IUnmarshaller<IcebergCompactionMetrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IcebergCompactionMetrics IUnmarshaller<IcebergCompactionMetrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IcebergCompactionMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            IcebergCompactionMetrics unmarshalledObject = new IcebergCompactionMetrics();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DpuHours", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DpuHours = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobDurationInHour", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.JobDurationInHour = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfBytesCompacted", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfBytesCompacted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfDpus", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfDpus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfFilesCompacted", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfFilesCompacted = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IcebergCompactionMetricsUnmarshaller _instance = new IcebergCompactionMetricsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IcebergCompactionMetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}