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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   GetAccountSummaryResult Unmarshaller
     /// </summary>
    internal class GetAccountSummaryResultUnmarshaller : IUnmarshaller<GetAccountSummaryResult, XmlUnmarshallerContext> 
    {
        public GetAccountSummaryResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetAccountSummaryResult getAccountSummaryResult = new GetAccountSummaryResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("SummaryMap/entry", targetDepth))
                    {
                        KeyValueUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, int, StringUnmarshaller, IntUnmarshaller>(StringUnmarshaller.GetInstance(), IntUnmarshaller.GetInstance());
                        KeyValuePair<string, int> kvp = unmarshaller.Unmarshall(context);
                        getAccountSummaryResult.SummaryMap.Add(kvp.Key, kvp.Value);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getAccountSummaryResult;
                }
            }
                        


            return getAccountSummaryResult;
        }

        private static GetAccountSummaryResultUnmarshaller instance;

        public static GetAccountSummaryResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetAccountSummaryResultUnmarshaller();

            return instance;
        }
    }
}
    
