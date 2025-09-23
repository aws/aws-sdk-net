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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IdMappingJobMetrics Object
    /// </summary>  
    public class IdMappingJobMetricsUnmarshaller : IUnmarshaller<IdMappingJobMetrics, XmlUnmarshallerContext>, IUnmarshaller<IdMappingJobMetrics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IdMappingJobMetrics IUnmarshaller<IdMappingJobMetrics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IdMappingJobMetrics Unmarshall(JsonUnmarshallerContext context)
        {
            IdMappingJobMetrics unmarshalledObject = new IdMappingJobMetrics();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("deleteRecordsProcessed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DeleteRecordsProcessed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputRecords", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.InputRecords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mappedRecordsRemoved", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MappedRecordsRemoved = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mappedSourceRecordsRemoved", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MappedSourceRecordsRemoved = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mappedTargetRecordsRemoved", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MappedTargetRecordsRemoved = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("newMappedRecords", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NewMappedRecords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("newMappedSourceRecords", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NewMappedSourceRecords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("newMappedTargetRecords", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NewMappedTargetRecords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("newUniqueRecordsLoaded", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NewUniqueRecordsLoaded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recordsNotProcessed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RecordsNotProcessed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalMappedRecords", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalMappedRecords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalMappedSourceRecords", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalMappedSourceRecords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalMappedTargetRecords", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalMappedTargetRecords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalRecordsProcessed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalRecordsProcessed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uniqueRecordsLoaded", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.UniqueRecordsLoaded = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IdMappingJobMetricsUnmarshaller _instance = new IdMappingJobMetricsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IdMappingJobMetricsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}