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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ValidationMessage Unmarshaller
     /// </summary>
    internal class ValidationMessageUnmarshaller : IUnmarshaller<ValidationMessage, XmlUnmarshallerContext> 
    {
        public ValidationMessage Unmarshall(XmlUnmarshallerContext context) 
        {
            ValidationMessage validationMessage = new ValidationMessage();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Message", targetDepth))
                    {
                        validationMessage.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Severity", targetDepth))
                    {
                        validationMessage.Severity = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Namespace", targetDepth))
                    {
                        validationMessage.Namespace = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("OptionName", targetDepth))
                    {
                        validationMessage.OptionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return validationMessage;
                }
            }
                        


            return validationMessage;
        }

        private static ValidationMessageUnmarshaller instance;

        public static ValidationMessageUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ValidationMessageUnmarshaller();

            return instance;
        }
    }
}
    
