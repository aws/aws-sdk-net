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

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IntentLevelSlotResolutionTestResults Object
    /// </summary>  
    public class IntentLevelSlotResolutionTestResultsUnmarshaller : IUnmarshaller<IntentLevelSlotResolutionTestResults, XmlUnmarshallerContext>, IUnmarshaller<IntentLevelSlotResolutionTestResults, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IntentLevelSlotResolutionTestResults IUnmarshaller<IntentLevelSlotResolutionTestResults, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IntentLevelSlotResolutionTestResults Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            IntentLevelSlotResolutionTestResults unmarshalledObject = new IntentLevelSlotResolutionTestResults();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("items", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IntentLevelSlotResolutionTestResultItem, IntentLevelSlotResolutionTestResultItemUnmarshaller>(IntentLevelSlotResolutionTestResultItemUnmarshaller.Instance);
                    unmarshalledObject.Items = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static IntentLevelSlotResolutionTestResultsUnmarshaller _instance = new IntentLevelSlotResolutionTestResultsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IntentLevelSlotResolutionTestResultsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}