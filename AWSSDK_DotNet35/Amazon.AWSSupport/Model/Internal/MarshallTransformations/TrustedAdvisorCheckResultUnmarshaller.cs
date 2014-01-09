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
    using System;
    using System.Collections.Generic;
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TrustedAdvisorCheckResultUnmarshaller
      /// </summary>
      internal class TrustedAdvisorCheckResultUnmarshaller : IUnmarshaller<TrustedAdvisorCheckResult, XmlUnmarshallerContext>, IUnmarshaller<TrustedAdvisorCheckResult, JsonUnmarshallerContext>
      {
        TrustedAdvisorCheckResult IUnmarshaller<TrustedAdvisorCheckResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TrustedAdvisorCheckResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            TrustedAdvisorCheckResult trustedAdvisorCheckResult = new TrustedAdvisorCheckResult();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("checkId", targetDepth))
              {
                context.Read();
                trustedAdvisorCheckResult.CheckId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timestamp", targetDepth))
              {
                context.Read();
                trustedAdvisorCheckResult.Timestamp = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("status", targetDepth))
              {
                context.Read();
                trustedAdvisorCheckResult.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("resourcesSummary", targetDepth))
              {
                context.Read();
                trustedAdvisorCheckResult.ResourcesSummary = TrustedAdvisorResourcesSummaryUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("categorySpecificSummary", targetDepth))
              {
                context.Read();
                trustedAdvisorCheckResult.CategorySpecificSummary = TrustedAdvisorCategorySpecificSummaryUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("flaggedResources", targetDepth))
              {
                context.Read();
                
                if (context.CurrentTokenType == JsonToken.Null)
                {
                    trustedAdvisorCheckResult.FlaggedResources = null;
                    continue;
                }
                  trustedAdvisorCheckResult.FlaggedResources = new List<TrustedAdvisorResourceDetail>();
                  TrustedAdvisorResourceDetailUnmarshaller unmarshaller = TrustedAdvisorResourceDetailUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   trustedAdvisorCheckResult.FlaggedResources.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return trustedAdvisorCheckResult;
                }
            }
          

            return trustedAdvisorCheckResult;
        }

        private static TrustedAdvisorCheckResultUnmarshaller instance;
        public static TrustedAdvisorCheckResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TrustedAdvisorCheckResultUnmarshaller();
            return instance;
        }
    }
}
  
