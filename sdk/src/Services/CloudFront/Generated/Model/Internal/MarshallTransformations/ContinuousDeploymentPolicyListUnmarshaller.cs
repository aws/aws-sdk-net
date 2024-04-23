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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ContinuousDeploymentPolicyList Object
    /// </summary>  
    public class ContinuousDeploymentPolicyListUnmarshaller : IUnmarshaller<ContinuousDeploymentPolicyList, XmlUnmarshallerContext>, IUnmarshaller<ContinuousDeploymentPolicyList, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ContinuousDeploymentPolicyList Unmarshall(XmlUnmarshallerContext context)
        {
            ContinuousDeploymentPolicyList unmarshalledObject = new ContinuousDeploymentPolicyList();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Items/ContinuousDeploymentPolicySummary", targetDepth))
                    {
                        if (unmarshalledObject.Items == null)
                        {
                            unmarshalledObject.Items = new List<ContinuousDeploymentPolicySummary>();
                        }
                        var unmarshaller = ContinuousDeploymentPolicySummaryUnmarshaller.Instance;
                        unmarshalledObject.Items.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxItems = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextMarker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.NextMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Quantity", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Quantity = unmarshaller.Unmarshall(context);
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
        
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ContinuousDeploymentPolicyList Unmarshall(JsonUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        private static ContinuousDeploymentPolicyListUnmarshaller _instance = new ContinuousDeploymentPolicyListUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ContinuousDeploymentPolicyListUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618