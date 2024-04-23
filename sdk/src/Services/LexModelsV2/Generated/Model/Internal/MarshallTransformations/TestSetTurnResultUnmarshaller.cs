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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TestSetTurnResult Object
    /// </summary>  
    public class TestSetTurnResultUnmarshaller : IUnmarshaller<TestSetTurnResult, XmlUnmarshallerContext>, IUnmarshaller<TestSetTurnResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TestSetTurnResult IUnmarshaller<TestSetTurnResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TestSetTurnResult Unmarshall(JsonUnmarshallerContext context)
        {
            TestSetTurnResult unmarshalledObject = new TestSetTurnResult();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agent", targetDepth))
                {
                    var unmarshaller = AgentTurnResultUnmarshaller.Instance;
                    unmarshalledObject.Agent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("user", targetDepth))
                {
                    var unmarshaller = UserTurnResultUnmarshaller.Instance;
                    unmarshalledObject.User = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TestSetTurnResultUnmarshaller _instance = new TestSetTurnResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestSetTurnResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618