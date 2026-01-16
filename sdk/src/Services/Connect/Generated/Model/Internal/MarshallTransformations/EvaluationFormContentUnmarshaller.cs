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
    /// Response Unmarshaller for EvaluationFormContent Object
    /// </summary>  
    public class EvaluationFormContentUnmarshaller : IUnmarshaller<EvaluationFormContent, XmlUnmarshallerContext>, IUnmarshaller<EvaluationFormContent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EvaluationFormContent IUnmarshaller<EvaluationFormContent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EvaluationFormContent Unmarshall(JsonUnmarshallerContext context)
        {
            EvaluationFormContent unmarshalledObject = new EvaluationFormContent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AutoEvaluationConfiguration", targetDepth))
                {
                    var unmarshaller = EvaluationFormAutoEvaluationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AutoEvaluationConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationFormArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationFormArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationFormId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationFormId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationFormVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvaluationFormVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Items", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EvaluationFormItem, EvaluationFormItemUnmarshaller>(EvaluationFormItemUnmarshaller.Instance);
                    unmarshalledObject.Items = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LanguageConfiguration", targetDepth))
                {
                    var unmarshaller = EvaluationFormLanguageConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LanguageConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReviewConfiguration", targetDepth))
                {
                    var unmarshaller = EvaluationReviewConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ReviewConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScoringStrategy", targetDepth))
                {
                    var unmarshaller = EvaluationFormScoringStrategyUnmarshaller.Instance;
                    unmarshalledObject.ScoringStrategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetConfiguration", targetDepth))
                {
                    var unmarshaller = EvaluationFormTargetConfigurationUnmarshaller.Instance;
                    unmarshalledObject.TargetConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EvaluationFormContentUnmarshaller _instance = new EvaluationFormContentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationFormContentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}