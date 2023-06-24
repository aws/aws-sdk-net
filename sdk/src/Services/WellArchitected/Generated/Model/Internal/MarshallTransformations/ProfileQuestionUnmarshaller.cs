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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProfileQuestion Object
    /// </summary>  
    public class ProfileQuestionUnmarshaller : IUnmarshaller<ProfileQuestion, XmlUnmarshallerContext>, IUnmarshaller<ProfileQuestion, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProfileQuestion IUnmarshaller<ProfileQuestion, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProfileQuestion Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProfileQuestion unmarshalledObject = new ProfileQuestion();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MaxSelectedChoices", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxSelectedChoices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinSelectedChoices", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinSelectedChoices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionChoices", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProfileChoice, ProfileChoiceUnmarshaller>(ProfileChoiceUnmarshaller.Instance);
                    unmarshalledObject.QuestionChoices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QuestionTitle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QuestionTitle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SelectedChoiceIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SelectedChoiceIds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProfileQuestionUnmarshaller _instance = new ProfileQuestionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProfileQuestionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}