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

/*
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Policies Object
    /// </summary>  
    public class PoliciesUnmarshaller : IUnmarshaller<Policies, XmlUnmarshallerContext>, IUnmarshaller<Policies, JsonUnmarshallerContext>
    {
        public Policies Unmarshall(XmlUnmarshallerContext context)
        {
            Policies unmarshalledObject = new Policies();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AppCookieStickinessPolicies/member", targetDepth))
                    {
                        var unmarshaller = AppCookieStickinessPolicyUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AppCookieStickinessPolicies.Add(item);
                        continue;
                    }
                    if (context.TestExpression("LBCookieStickinessPolicies/member", targetDepth))
                    {
                        var unmarshaller = LBCookieStickinessPolicyUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LBCookieStickinessPolicies.Add(item);
                        continue;
                    }
                    if (context.TestExpression("OtherPolicies/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.OtherPolicies.Add(item);
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

        public Policies Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static PoliciesUnmarshaller _instance = new PoliciesUnmarshaller();        

        public static PoliciesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}