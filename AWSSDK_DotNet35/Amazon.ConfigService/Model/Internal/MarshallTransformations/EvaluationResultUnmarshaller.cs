/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EvaluationResult Object
    /// </summary>  
    public class EvaluationResultUnmarshaller : IUnmarshaller<EvaluationResult, XmlUnmarshallerContext>, IUnmarshaller<EvaluationResult, JsonUnmarshallerContext>
    {
        EvaluationResult IUnmarshaller<EvaluationResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public EvaluationResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EvaluationResult unmarshalledObject = new EvaluationResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Annotation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Annotation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComplianceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComplianceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConfigRuleInvokedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ConfigRuleInvokedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationResultIdentifier", targetDepth))
                {
                    var unmarshaller = EvaluationResultIdentifierUnmarshaller.Instance;
                    unmarshalledObject.EvaluationResultIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultRecordedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ResultRecordedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResultToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResultToken = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EvaluationResultUnmarshaller _instance = new EvaluationResultUnmarshaller();        

        public static EvaluationResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}