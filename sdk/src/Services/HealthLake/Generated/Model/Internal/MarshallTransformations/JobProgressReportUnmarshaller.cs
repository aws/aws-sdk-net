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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.HealthLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.HealthLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobProgressReport Object
    /// </summary>  
    public class JobProgressReportUnmarshaller : IUnmarshaller<JobProgressReport, XmlUnmarshallerContext>, IUnmarshaller<JobProgressReport, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobProgressReport IUnmarshaller<JobProgressReport, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public JobProgressReport Unmarshall(JsonUnmarshallerContext context)
        {
            JobProgressReport unmarshalledObject = new JobProgressReport();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Throughput", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Throughput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalNumberOfFilesReadWithCustomerError", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalNumberOfFilesReadWithCustomerError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalNumberOfImportedFiles", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalNumberOfImportedFiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalNumberOfResourcesImported", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalNumberOfResourcesImported = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalNumberOfResourcesScanned", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalNumberOfResourcesScanned = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalNumberOfResourcesWithCustomerError", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalNumberOfResourcesWithCustomerError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalNumberOfScannedFiles", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.TotalNumberOfScannedFiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalSizeOfScannedFilesInMB", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.TotalSizeOfScannedFilesInMB = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JobProgressReportUnmarshaller _instance = new JobProgressReportUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobProgressReportUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}