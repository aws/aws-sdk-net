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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StepFunctions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InspectionData Object
    /// </summary>  
    public class InspectionDataUnmarshaller : IUnmarshaller<InspectionData, XmlUnmarshallerContext>, IUnmarshaller<InspectionData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InspectionData IUnmarshaller<InspectionData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InspectionData Unmarshall(JsonUnmarshallerContext context)
        {
            InspectionData unmarshalledObject = new InspectionData();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("afterArguments", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterArguments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterInputPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterInputPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterItemBatcher", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterItemBatcher = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterItemSelector", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterItemSelector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterItemsPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterItemsPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterItemsPointer", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterItemsPointer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterParameters", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterResultPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterResultPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("afterResultSelector", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AfterResultSelector = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorDetails", targetDepth))
                {
                    var unmarshaller = InspectionErrorDetailsUnmarshaller.Instance;
                    unmarshalledObject.ErrorDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxConcurrency", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxConcurrency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("request", targetDepth))
                {
                    var unmarshaller = InspectionDataRequestUnmarshaller.Instance;
                    unmarshalledObject.Request = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("response", targetDepth))
                {
                    var unmarshaller = InspectionDataResponseUnmarshaller.Instance;
                    unmarshalledObject.Response = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("result", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Result = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toleratedFailureCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ToleratedFailureCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("toleratedFailurePercentage", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.ToleratedFailurePercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("variables", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Variables = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InspectionDataUnmarshaller _instance = new InspectionDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InspectionDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}