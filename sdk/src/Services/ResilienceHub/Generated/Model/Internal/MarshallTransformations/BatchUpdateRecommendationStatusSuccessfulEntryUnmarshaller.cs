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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchUpdateRecommendationStatusSuccessfulEntry Object
    /// </summary>  
    public class BatchUpdateRecommendationStatusSuccessfulEntryUnmarshaller : IUnmarshaller<BatchUpdateRecommendationStatusSuccessfulEntry, XmlUnmarshallerContext>, IUnmarshaller<BatchUpdateRecommendationStatusSuccessfulEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchUpdateRecommendationStatusSuccessfulEntry IUnmarshaller<BatchUpdateRecommendationStatusSuccessfulEntry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchUpdateRecommendationStatusSuccessfulEntry Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchUpdateRecommendationStatusSuccessfulEntry unmarshalledObject = new BatchUpdateRecommendationStatusSuccessfulEntry();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("entryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("excluded", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Excluded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("excludeReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExcludeReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("item", targetDepth))
                {
                    var unmarshaller = UpdateRecommendationStatusItemUnmarshaller.Instance;
                    unmarshalledObject.Item = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("referenceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReferenceId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchUpdateRecommendationStatusSuccessfulEntryUnmarshaller _instance = new BatchUpdateRecommendationStatusSuccessfulEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateRecommendationStatusSuccessfulEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}