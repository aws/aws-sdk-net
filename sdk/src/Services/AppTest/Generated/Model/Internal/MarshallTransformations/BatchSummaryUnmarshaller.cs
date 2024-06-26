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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchSummary Object
    /// </summary>  
    public class BatchSummaryUnmarshaller : IUnmarshaller<BatchSummary, XmlUnmarshallerContext>, IUnmarshaller<BatchSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchSummary IUnmarshaller<BatchSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BatchSummary Unmarshall(JsonUnmarshallerContext context)
        {
            BatchSummary unmarshalledObject = new BatchSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("stepInput", targetDepth))
                {
                    var unmarshaller = BatchStepInputUnmarshaller.Instance;
                    unmarshalledObject.StepInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stepOutput", targetDepth))
                {
                    var unmarshaller = BatchStepOutputUnmarshaller.Instance;
                    unmarshalledObject.StepOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BatchSummaryUnmarshaller _instance = new BatchSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}