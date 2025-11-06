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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EvaluationFormItemEnablementExpression Object
    /// </summary>  
    public class EvaluationFormItemEnablementExpressionUnmarshaller : IUnmarshaller<EvaluationFormItemEnablementExpression, XmlUnmarshallerContext>, IUnmarshaller<EvaluationFormItemEnablementExpression, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EvaluationFormItemEnablementExpression IUnmarshaller<EvaluationFormItemEnablementExpression, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EvaluationFormItemEnablementExpression Unmarshall(JsonUnmarshallerContext context)
        {
            EvaluationFormItemEnablementExpression unmarshalledObject = new EvaluationFormItemEnablementExpression();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Comparator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Comparator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Source", targetDepth))
                {
                    var unmarshaller = EvaluationFormItemEnablementSourceUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Values", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EvaluationFormItemEnablementSourceValue, EvaluationFormItemEnablementSourceValueUnmarshaller>(EvaluationFormItemEnablementSourceValueUnmarshaller.Instance);
                    unmarshalledObject.Values = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EvaluationFormItemEnablementExpressionUnmarshaller _instance = new EvaluationFormItemEnablementExpressionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationFormItemEnablementExpressionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}