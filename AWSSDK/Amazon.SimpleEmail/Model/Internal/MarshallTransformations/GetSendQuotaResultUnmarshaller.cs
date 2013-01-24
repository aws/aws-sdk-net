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
     ///   GetSendQuotaResult Unmarshaller
     /// </summary>
    internal class GetSendQuotaResultUnmarshaller : IUnmarshaller<GetSendQuotaResult, XmlUnmarshallerContext>, IUnmarshaller<GetSendQuotaResult, JsonUnmarshallerContext> 
    {
        public GetSendQuotaResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetSendQuotaResult getSendQuotaResult = new GetSendQuotaResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Max24HourSend", targetDepth))
                    {
                        getSendQuotaResult.Max24HourSend = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("MaxSendRate", targetDepth))
                    {
                        getSendQuotaResult.MaxSendRate = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SentLast24Hours", targetDepth))
                    {
                        getSendQuotaResult.SentLast24Hours = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getSendQuotaResult;
                }
            }
                        


            return getSendQuotaResult;
        }

        public GetSendQuotaResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetSendQuotaResultUnmarshaller instance;

        public static GetSendQuotaResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetSendQuotaResultUnmarshaller();

            return instance;
        }
    }
}
    
