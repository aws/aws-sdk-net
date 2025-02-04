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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkInsightsAnalysis Object
    /// </summary>  
    public class NetworkInsightsAnalysisUnmarshaller : IXmlUnmarshaller<NetworkInsightsAnalysis, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkInsightsAnalysis Unmarshall(XmlUnmarshallerContext context)
        {
            NetworkInsightsAnalysis unmarshalledObject = new NetworkInsightsAnalysis();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("additionalAccountSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.AdditionalAccounts == null)
                        {
                            unmarshalledObject.AdditionalAccounts = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AdditionalAccounts.Add(item);
                        continue;
                    }
                    if (context.TestExpression("alternatePathHintSet/item", targetDepth))
                    {
                        var unmarshaller = AlternatePathHintUnmarshaller.Instance;
                        if (unmarshalledObject.AlternatePathHints == null)
                        {
                            unmarshalledObject.AlternatePathHints = new List<AlternatePathHint>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AlternatePathHints.Add(item);
                        continue;
                    }
                    if (context.TestExpression("explanationSet/item", targetDepth))
                    {
                        var unmarshaller = ExplanationUnmarshaller.Instance;
                        if (unmarshalledObject.Explanations == null)
                        {
                            unmarshalledObject.Explanations = new List<Explanation>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Explanations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("filterInArnSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.FilterInArns == null)
                        {
                            unmarshalledObject.FilterInArns = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.FilterInArns.Add(item);
                        continue;
                    }
                    if (context.TestExpression("forwardPathComponentSet/item", targetDepth))
                    {
                        var unmarshaller = PathComponentUnmarshaller.Instance;
                        if (unmarshalledObject.ForwardPathComponents == null)
                        {
                            unmarshalledObject.ForwardPathComponents = new List<PathComponent>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ForwardPathComponents.Add(item);
                        continue;
                    }
                    if (context.TestExpression("networkInsightsAnalysisArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInsightsAnalysisArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInsightsAnalysisId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInsightsAnalysisId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkInsightsPathId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NetworkInsightsPathId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkPathFound", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.NetworkPathFound = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("returnPathComponentSet/item", targetDepth))
                    {
                        var unmarshaller = PathComponentUnmarshaller.Instance;
                        if (unmarshalledObject.ReturnPathComponents == null)
                        {
                            unmarshalledObject.ReturnPathComponents = new List<PathComponent>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ReturnPathComponents.Add(item);
                        continue;
                    }
                    if (context.TestExpression("startDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.StartDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("suggestedAccountSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.SuggestedAccounts == null)
                        {
                            unmarshalledObject.SuggestedAccounts = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.SuggestedAccounts.Add(item);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("warningMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.WarningMessage = unmarshaller.Unmarshall(context);
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

        private static NetworkInsightsAnalysisUnmarshaller _instance = new NetworkInsightsAnalysisUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkInsightsAnalysisUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}