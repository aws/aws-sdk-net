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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ForwardedValues Unmarshaller
     /// </summary>
    internal class ForwardedValuesUnmarshaller : IUnmarshaller<ForwardedValues, XmlUnmarshallerContext>, IUnmarshaller<ForwardedValues, JsonUnmarshallerContext> 
    {
        public ForwardedValues Unmarshall(XmlUnmarshallerContext context) 
        {
            ForwardedValues forwardedValues = new ForwardedValues();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("QueryString", targetDepth))
                    {
                        forwardedValues.QueryString = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Cookies", targetDepth))
                    {
                        forwardedValues.Cookies = CookiePreferenceUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return forwardedValues;
                }
            }
                        


            return forwardedValues;
        }

        public ForwardedValues Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ForwardedValuesUnmarshaller instance;

        public static ForwardedValuesUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ForwardedValuesUnmarshaller();

            return instance;
        }
    }
}
    
