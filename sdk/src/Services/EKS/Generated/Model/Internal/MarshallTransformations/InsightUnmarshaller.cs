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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Insight Object
    /// </summary>  
    public class InsightUnmarshaller : IUnmarshaller<Insight, XmlUnmarshallerContext>, IUnmarshaller<Insight, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Insight IUnmarshaller<Insight, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Insight Unmarshall(JsonUnmarshallerContext context)
        {
            Insight unmarshalledObject = new Insight();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("additionalInfo", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.AdditionalInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("category", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Category = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("categorySpecificSummary", targetDepth))
                {
                    var unmarshaller = InsightCategorySpecificSummaryUnmarshaller.Instance;
                    unmarshalledObject.CategorySpecificSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("insightStatus", targetDepth))
                {
                    var unmarshaller = InsightStatusUnmarshaller.Instance;
                    unmarshalledObject.InsightStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kubernetesVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KubernetesVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastRefreshTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastRefreshTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastTransitionTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastTransitionTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Recommendation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InsightResourceDetail, InsightResourceDetailUnmarshaller>(InsightResourceDetailUnmarshaller.Instance);
                    unmarshalledObject.Resources = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InsightUnmarshaller _instance = new InsightUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InsightUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}