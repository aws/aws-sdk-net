/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Redirect Unmarshaller
     /// </summary>
    internal class RoutingRuleRedirectUnmarshaller : IUnmarshaller<RoutingRuleRedirect, XmlUnmarshallerContext>, IUnmarshaller<RoutingRuleRedirect, JsonUnmarshallerContext> 
    {
        public RoutingRuleRedirect Unmarshall(XmlUnmarshallerContext context) 
        {
            RoutingRuleRedirect redirect = new RoutingRuleRedirect();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("HostName", targetDepth))
                    {
                        redirect.HostName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("HttpRedirectCode", targetDepth))
                    {
                        redirect.HttpRedirectCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Protocol", targetDepth))
                    {
                        redirect.Protocol = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReplaceKeyPrefixWith", targetDepth))
                    {
                        redirect.ReplaceKeyPrefixWith = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ReplaceKeyWith", targetDepth))
                    {
                        redirect.ReplaceKeyWith = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return redirect;
                }
            }
                        


            return redirect;
        }

        public RoutingRuleRedirect Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static RoutingRuleRedirectUnmarshaller _instance;

        public static RoutingRuleRedirectUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoutingRuleRedirectUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
