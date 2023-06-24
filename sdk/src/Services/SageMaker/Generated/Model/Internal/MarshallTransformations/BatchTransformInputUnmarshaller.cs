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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchTransformInput Object
    /// </summary>  
    public class BatchTransformInputUnmarshaller : IUnmarshaller<BatchTransformInput, XmlUnmarshallerContext>, IUnmarshaller<BatchTransformInput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchTransformInput IUnmarshaller<BatchTransformInput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchTransformInput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchTransformInput unmarshalledObject = new BatchTransformInput();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DataCapturedDestinationS3Uri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataCapturedDestinationS3Uri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetFormat", targetDepth))
                {
                    var unmarshaller = MonitoringDatasetFormatUnmarshaller.Instance;
                    unmarshalledObject.DatasetFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTimeOffset", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndTimeOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeaturesAttribute", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FeaturesAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InferenceAttribute", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InferenceAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProbabilityAttribute", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProbabilityAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProbabilityThresholdAttribute", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ProbabilityThresholdAttribute = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3DataDistributionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3DataDistributionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3InputMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3InputMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTimeOffset", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartTimeOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchTransformInputUnmarshaller _instance = new BatchTransformInputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchTransformInputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}