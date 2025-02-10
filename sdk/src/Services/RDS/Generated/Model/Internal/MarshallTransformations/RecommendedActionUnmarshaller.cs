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
    /// Response Unmarshaller for RecommendedAction Object
    /// </summary>  
    public class RecommendedActionUnmarshaller : IXmlUnmarshaller<RecommendedAction, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecommendedAction Unmarshall(XmlUnmarshallerContext context)
        {
            RecommendedAction unmarshalledObject = new RecommendedAction();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ActionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ActionId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ApplyModes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.ApplyModes == null)
                        {
                            unmarshalledObject.ApplyModes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ApplyModes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ContextAttributes/member", targetDepth))
                    {
                        var unmarshaller = ContextAttributeUnmarshaller.Instance;
                        if (unmarshalledObject.ContextAttributes == null)
                        {
                            unmarshalledObject.ContextAttributes = new List<ContextAttribute>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ContextAttributes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IssueDetails", targetDepth))
                    {
                        var unmarshaller = IssueDetailsUnmarshaller.Instance;
                        unmarshalledObject.IssueDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Operation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Operation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Parameters/member", targetDepth))
                    {
                        var unmarshaller = RecommendedActionParameterUnmarshaller.Instance;
                        if (unmarshalledObject.Parameters == null)
                        {
                            unmarshalledObject.Parameters = new List<RecommendedActionParameter>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Parameters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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

        private static RecommendedActionUnmarshaller _instance = new RecommendedActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecommendedActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}