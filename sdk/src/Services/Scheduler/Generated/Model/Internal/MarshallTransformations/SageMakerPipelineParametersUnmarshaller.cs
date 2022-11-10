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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Scheduler.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Scheduler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SageMakerPipelineParameters Object
    /// </summary>  
    public class SageMakerPipelineParametersUnmarshaller : IUnmarshaller<SageMakerPipelineParameters, XmlUnmarshallerContext>, IUnmarshaller<SageMakerPipelineParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SageMakerPipelineParameters IUnmarshaller<SageMakerPipelineParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SageMakerPipelineParameters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SageMakerPipelineParameters unmarshalledObject = new SageMakerPipelineParameters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("PipelineParameterList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SageMakerPipelineParameter, SageMakerPipelineParameterUnmarshaller>(SageMakerPipelineParameterUnmarshaller.Instance);
                    unmarshalledObject.PipelineParameterList = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SageMakerPipelineParametersUnmarshaller _instance = new SageMakerPipelineParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SageMakerPipelineParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}