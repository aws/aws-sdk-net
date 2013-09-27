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

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   OptionStatus Unmarshaller
     /// </summary>
    internal class OptionStatusUnmarshaller : IUnmarshaller<OptionStatus, XmlUnmarshallerContext>, IUnmarshaller<OptionStatus, JsonUnmarshallerContext> 
    {
        public OptionStatus Unmarshall(XmlUnmarshallerContext context) 
        {
            OptionStatus optionStatus = new OptionStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("CreationDate", targetDepth))
                    {
                        optionStatus.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UpdateDate", targetDepth))
                    {
                        optionStatus.UpdateDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("UpdateVersion", targetDepth))
                    {
                        optionStatus.UpdateVersion = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("State", targetDepth))
                    {
                        optionStatus.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PendingDeletion", targetDepth))
                    {
                        optionStatus.PendingDeletion = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return optionStatus;
                }
            }
                        


            return optionStatus;
        }

        public OptionStatus Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static OptionStatusUnmarshaller instance;

        public static OptionStatusUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new OptionStatusUnmarshaller();

            return instance;
        }
    }
}
    
