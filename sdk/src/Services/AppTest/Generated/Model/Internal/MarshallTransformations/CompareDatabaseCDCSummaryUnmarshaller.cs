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
    /// Response Unmarshaller for CompareDatabaseCDCSummary Object
    /// </summary>  
    public class CompareDatabaseCDCSummaryUnmarshaller : IUnmarshaller<CompareDatabaseCDCSummary, XmlUnmarshallerContext>, IUnmarshaller<CompareDatabaseCDCSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CompareDatabaseCDCSummary IUnmarshaller<CompareDatabaseCDCSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CompareDatabaseCDCSummary Unmarshall(JsonUnmarshallerContext context)
        {
            CompareDatabaseCDCSummary unmarshalledObject = new CompareDatabaseCDCSummary();
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
                    var unmarshaller = CompareDatabaseCDCStepInputUnmarshaller.Instance;
                    unmarshalledObject.StepInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stepOutput", targetDepth))
                {
                    var unmarshaller = CompareDatabaseCDCStepOutputUnmarshaller.Instance;
                    unmarshalledObject.StepOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CompareDatabaseCDCSummaryUnmarshaller _instance = new CompareDatabaseCDCSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompareDatabaseCDCSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}