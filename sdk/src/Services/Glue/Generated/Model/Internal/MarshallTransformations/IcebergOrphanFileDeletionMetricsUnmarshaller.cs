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
    /// Response Unmarshaller for IcebergOrphanFileDeletionMetrics Object
    /// </summary>  
    public class IcebergOrphanFileDeletionMetricsUnmarshaller : IUnmarshaller<IcebergOrphanFileDeletionMetrics, XmlUnmarshallerContext>, IUnmarshaller<IcebergOrphanFileDeletionMetrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IcebergOrphanFileDeletionMetrics IUnmarshaller<IcebergOrphanFileDeletionMetrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IcebergOrphanFileDeletionMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            IcebergOrphanFileDeletionMetrics unmarshalledObject = new IcebergOrphanFileDeletionMetrics();
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
                if (context.TestExpression("NumberOfDpus", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfDpus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfOrphanFilesDeleted", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfOrphanFilesDeleted = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IcebergOrphanFileDeletionMetricsUnmarshaller _instance = new IcebergOrphanFileDeletionMetricsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IcebergOrphanFileDeletionMetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}