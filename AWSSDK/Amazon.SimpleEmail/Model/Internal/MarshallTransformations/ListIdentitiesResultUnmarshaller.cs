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

using Amazon.SimpleEmail.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   ListIdentitiesResult Unmarshaller
     /// </summary>
    internal class ListIdentitiesResultUnmarshaller : IUnmarshaller<ListIdentitiesResult, XmlUnmarshallerContext>, IUnmarshaller<ListIdentitiesResult, JsonUnmarshallerContext> 
    {
        public ListIdentitiesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListIdentitiesResult listIdentitiesResult = new ListIdentitiesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Identities/member", targetDepth))
                    {
                        listIdentitiesResult.Identities.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("NextToken", targetDepth))
                    {
                        listIdentitiesResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listIdentitiesResult;
                }
            }
                        


            return listIdentitiesResult;
        }

        public ListIdentitiesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListIdentitiesResultUnmarshaller instance;

        public static ListIdentitiesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListIdentitiesResultUnmarshaller();

            return instance;
        }
    }
}
    
