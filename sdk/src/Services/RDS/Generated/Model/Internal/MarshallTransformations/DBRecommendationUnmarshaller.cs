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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBRecommendation Object
    /// </summary>  
    public class DBRecommendationUnmarshaller : IXmlUnmarshaller<DBRecommendation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBRecommendation Unmarshall(XmlUnmarshallerContext context)
        {
            DBRecommendation unmarshalledObject = new DBRecommendation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AdditionalInfo", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AdditionalInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Category", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Category = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Detection", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Detection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Impact", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Impact = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IssueDetails", targetDepth))
                    {
                        var unmarshaller = IssueDetailsUnmarshaller.Instance;
                        unmarshalledObject.IssueDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Links/member", targetDepth))
                    {
                        var unmarshaller = DocLinkUnmarshaller.Instance;
                        if (unmarshalledObject.Links == null)
                        {
                            unmarshalledObject.Links = new List<DocLink>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Links.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Reason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Reason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Recommendation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Recommendation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RecommendationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RecommendationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RecommendedActions/member", targetDepth))
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
                    if (context.TestExpression("ResourceArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Severity", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Source", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeDetection", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeDetection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeRecommendation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeRecommendation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("UpdatedTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdatedTime = unmarshaller.Unmarshall(context);
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

        private static DBRecommendationUnmarshaller _instance = new DBRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}