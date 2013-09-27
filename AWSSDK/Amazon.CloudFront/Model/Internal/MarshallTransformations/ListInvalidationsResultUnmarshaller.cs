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
     ///   ListInvalidationsResult Unmarshaller
     /// </summary>
    internal class ListInvalidationsResultUnmarshaller : IUnmarshaller<ListInvalidationsResult, XmlUnmarshallerContext>, IUnmarshaller<ListInvalidationsResult, JsonUnmarshallerContext> 
    {
        public ListInvalidationsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListInvalidationsResult listInvalidationsResult = new ListInvalidationsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("InvalidationList", targetDepth))
                    {
                        listInvalidationsResult.InvalidationList = InvalidationListUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return listInvalidationsResult;
                }
            }
                        


            return listInvalidationsResult;
        }

        public ListInvalidationsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static ListInvalidationsResultUnmarshaller instance;

        public static ListInvalidationsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new ListInvalidationsResultUnmarshaller();

            return instance;
        }
    }
}
    
