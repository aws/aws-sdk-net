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
using System.Collections.Generic;

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   SuggesterStatus Unmarshaller
     /// </summary>
    internal class SuggesterStatusUnmarshaller : IUnmarshaller<SuggesterStatus, XmlUnmarshallerContext>, IUnmarshaller<SuggesterStatus, JsonUnmarshallerContext> 
    {
        public SuggesterStatus Unmarshall(XmlUnmarshallerContext context) 
        {
            SuggesterStatus suggesterStatus = new SuggesterStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Options", targetDepth))
                    {
                        suggesterStatus.Options = SuggesterUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Status", targetDepth))
                    {
                        suggesterStatus.Status = OptionStatusUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return suggesterStatus;
                }
            }
                        


            return suggesterStatus;
        }

        public SuggesterStatus Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SuggesterStatusUnmarshaller instance;

        public static SuggesterStatusUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SuggesterStatusUnmarshaller();

            return instance;
        }
    }
}
    
