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
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DescribeTrustedAdvisorCheckRefreshStatusesResultUnmarshaller
      /// </summary>
      internal class DescribeTrustedAdvisorCheckRefreshStatusesResultUnmarshaller : IUnmarshaller<DescribeTrustedAdvisorCheckRefreshStatusesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeTrustedAdvisorCheckRefreshStatusesResult, JsonUnmarshallerContext>
      {
        DescribeTrustedAdvisorCheckRefreshStatusesResult IUnmarshaller<DescribeTrustedAdvisorCheckRefreshStatusesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeTrustedAdvisorCheckRefreshStatusesResult Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTrustedAdvisorCheckRefreshStatusesResult describeTrustedAdvisorCheckRefreshStatusesResult = new DescribeTrustedAdvisorCheckRefreshStatusesResult();
          describeTrustedAdvisorCheckRefreshStatusesResult.Statuses = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Statuses", targetDepth))
              {
                describeTrustedAdvisorCheckRefreshStatusesResult.Statuses = new List<TrustedAdvisorCheckRefreshStatus>();
                        TrustedAdvisorCheckRefreshStatusUnmarshaller unmarshaller = TrustedAdvisorCheckRefreshStatusUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeTrustedAdvisorCheckRefreshStatusesResult.Statuses.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describeTrustedAdvisorCheckRefreshStatusesResult;
                }
            }
          

            return describeTrustedAdvisorCheckRefreshStatusesResult;
        }

        private static DescribeTrustedAdvisorCheckRefreshStatusesResultUnmarshaller instance;
        public static DescribeTrustedAdvisorCheckRefreshStatusesResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeTrustedAdvisorCheckRefreshStatusesResultUnmarshaller();
            return instance;
        }
    }
}
  
