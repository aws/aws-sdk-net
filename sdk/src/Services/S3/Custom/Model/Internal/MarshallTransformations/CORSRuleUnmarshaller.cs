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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   CORSRule Unmarshaller
     /// </summary>
    public class CORSRuleUnmarshaller : IXmlUnmarshaller<CORSRule, XmlUnmarshallerContext>, IXmlUnmarshaller<CORSRule, JsonUnmarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public CORSRule Unmarshall(XmlUnmarshallerContext context) 
        {
            CORSRule cORSRule = new CORSRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowedMethod", targetDepth))
                    {
                        if (cORSRule.AllowedMethods == null)
                        {
                            cORSRule.AllowedMethods = new List<string>();
                        }

                        cORSRule.AllowedMethods.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("AllowedOrigin", targetDepth))
                    {
                        if (cORSRule.AllowedOrigins == null)
                        {
                            cORSRule.AllowedOrigins = new List<string>();
                        }

                        cORSRule.AllowedOrigins.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("ExposeHeader", targetDepth))
                    {
                        if (cORSRule.ExposeHeaders == null)
                        {
                            cORSRule.ExposeHeaders = new List<string>();
                        }

                        cORSRule.ExposeHeaders.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("AllowedHeader", targetDepth))
                    {
                        if (cORSRule.AllowedHeaders == null)
                        {
                            cORSRule.AllowedHeaders = new List<string>();
                        }

                        cORSRule.AllowedHeaders.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("MaxAgeSeconds", targetDepth))
                    {
                        cORSRule.MaxAgeSeconds = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ID", targetDepth))
                    {
                        cORSRule.Id = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    }

                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return cORSRule;
                }
            }
                        


            return cORSRule;
        }

        /// <summary>
        /// Not implemented and always returns null.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public CORSRule Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static CORSRuleUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static CORSRuleUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CORSRuleUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
