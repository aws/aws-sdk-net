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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribedExecution Object
    /// </summary>  
    public class DescribedExecutionUnmarshaller : IUnmarshaller<DescribedExecution, XmlUnmarshallerContext>, IUnmarshaller<DescribedExecution, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DescribedExecution IUnmarshaller<DescribedExecution, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DescribedExecution Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DescribedExecution unmarshalledObject = new DescribedExecution();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExecutionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitialFileLocation", targetDepth))
                {
                    var unmarshaller = FileLocationUnmarshaller.Instance;
                    unmarshalledObject.InitialFileLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LoggingConfiguration", targetDepth))
                {
                    var unmarshaller = LoggingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LoggingConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PosixProfile", targetDepth))
                {
                    var unmarshaller = PosixProfileUnmarshaller.Instance;
                    unmarshalledObject.PosixProfile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Results", targetDepth))
                {
                    var unmarshaller = ExecutionResultsUnmarshaller.Instance;
                    unmarshalledObject.Results = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceMetadata", targetDepth))
                {
                    var unmarshaller = ServiceMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DescribedExecutionUnmarshaller _instance = new DescribedExecutionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribedExecutionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}