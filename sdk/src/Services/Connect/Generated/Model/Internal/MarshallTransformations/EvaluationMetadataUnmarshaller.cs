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
    /// Response Unmarshaller for EvaluationMetadata Object
    /// </summary>  
    public class EvaluationMetadataUnmarshaller : IUnmarshaller<EvaluationMetadata, XmlUnmarshallerContext>, IUnmarshaller<EvaluationMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EvaluationMetadata IUnmarshaller<EvaluationMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EvaluationMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            EvaluationMetadata unmarshalledObject = new EvaluationMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Acknowledgement", targetDepth))
                {
                    var unmarshaller = EvaluationAcknowledgementUnmarshaller.Instance;
                    unmarshalledObject.Acknowledgement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoEvaluation", targetDepth))
                {
                    var unmarshaller = AutoEvaluationDetailsUnmarshaller.Instance;
                    unmarshalledObject.AutoEvaluation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CalibrationSessionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CalibrationSessionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContactAgentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContactAgentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContactId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContactId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContactParticipant", targetDepth))
                {
                    var unmarshaller = EvaluationContactParticipantUnmarshaller.Instance;
                    unmarshalledObject.ContactParticipant = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluatorArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluatorArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Review", targetDepth))
                {
                    var unmarshaller = EvaluationReviewMetadataUnmarshaller.Instance;
                    unmarshalledObject.Review = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SamplingJobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SamplingJobId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Score", targetDepth))
                {
                    var unmarshaller = EvaluationScoreUnmarshaller.Instance;
                    unmarshalledObject.Score = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EvaluationMetadataUnmarshaller _instance = new EvaluationMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluationMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}