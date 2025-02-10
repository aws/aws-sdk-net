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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Recommendation Object
    /// </summary>  
    public class RecommendationUnmarshaller : IXmlUnmarshaller<Recommendation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Recommendation Unmarshall(XmlUnmarshallerContext context)
        {
            Recommendation unmarshalledObject = new Recommendation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ImpactRanking", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ImpactRanking = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NamespaceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NamespaceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Observation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Observation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RecommendationText", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RecommendationText = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RecommendationType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RecommendationType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RecommendedActions/RecommendedAction", targetDepth))
                    {
                        var unmarshaller = RecommendedActionUnmarshaller.Instance;
                        if (unmarshalledObject.RecommendedActions == null)
                        {
                            unmarshalledObject.RecommendedActions = new List<RecommendedAction>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.RecommendedActions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ReferenceLinks/ReferenceLink", targetDepth))
                    {
                        var unmarshaller = ReferenceLinkUnmarshaller.Instance;
                        if (unmarshalledObject.ReferenceLinks == null)
                        {
                            unmarshalledObject.ReferenceLinks = new List<ReferenceLink>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ReferenceLinks.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Title", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static RecommendationUnmarshaller _instance = new RecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}