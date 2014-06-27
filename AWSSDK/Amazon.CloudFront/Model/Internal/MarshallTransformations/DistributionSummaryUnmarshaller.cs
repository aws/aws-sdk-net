/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DistributionSummary Object
    /// </summary>  
    public class DistributionSummaryUnmarshaller : IUnmarshaller<DistributionSummary, XmlUnmarshallerContext>
    {
        public DistributionSummary Unmarshall(XmlUnmarshallerContext context)
        {
            DistributionSummary unmarshalledObject = new DistributionSummary();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Aliases", targetDepth))
                    {
                        var unmarshaller = AliasesUnmarshaller.GetInstance();
                        unmarshalledObject.Aliases = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheBehaviors", targetDepth))
                    {
                        var unmarshaller = CacheBehaviorsUnmarshaller.GetInstance();
                        unmarshalledObject.CacheBehaviors = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Comment", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Comment = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomErrorResponses", targetDepth))
                    {
                        var unmarshaller = CustomErrorResponsesUnmarshaller.GetInstance();
                        unmarshalledObject.CustomErrorResponses = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultCacheBehavior", targetDepth))
                    {
                        var unmarshaller = DefaultCacheBehaviorUnmarshaller.GetInstance();
                        unmarshalledObject.DefaultCacheBehavior = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.GetInstance();
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastModifiedTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Origins", targetDepth))
                    {
                        var unmarshaller = OriginsUnmarshaller.GetInstance();
                        unmarshalledObject.Origins = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PriceClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.PriceClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Restrictions", targetDepth))
                    {
                        var unmarshaller = RestrictionsUnmarshaller.GetInstance();
                        unmarshalledObject.Restrictions = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ViewerCertificate", targetDepth))
                    {
                        var unmarshaller = ViewerCertificateUnmarshaller.GetInstance();
                        unmarshalledObject.ViewerCertificate = unmarshaller.Unmarshall(context);
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

        private static DistributionSummaryUnmarshaller instance;
        public static DistributionSummaryUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new DistributionSummaryUnmarshaller();
            }
            return instance;
        }

    }
}