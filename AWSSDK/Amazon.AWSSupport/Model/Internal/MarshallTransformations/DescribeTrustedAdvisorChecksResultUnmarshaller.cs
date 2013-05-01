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
      /// DescribeTrustedAdvisorChecksResultUnmarshaller
      /// </summary>
      internal class DescribeTrustedAdvisorChecksResultUnmarshaller : IUnmarshaller<DescribeTrustedAdvisorChecksResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeTrustedAdvisorChecksResult, JsonUnmarshallerContext>
      {
        DescribeTrustedAdvisorChecksResult IUnmarshaller<DescribeTrustedAdvisorChecksResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeTrustedAdvisorChecksResult Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeTrustedAdvisorChecksResult describeTrustedAdvisorChecksResult = new DescribeTrustedAdvisorChecksResult();
          describeTrustedAdvisorChecksResult.Checks = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Checks", targetDepth))
              {
                describeTrustedAdvisorChecksResult.Checks = new List<TrustedAdvisorCheckDescription>();
                        TrustedAdvisorCheckDescriptionUnmarshaller unmarshaller = TrustedAdvisorCheckDescriptionUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeTrustedAdvisorChecksResult.Checks.Add(unmarshaller.Unmarshall(context));
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
                    return describeTrustedAdvisorChecksResult;
                }
            }
          

            return describeTrustedAdvisorChecksResult;
        }

        private static DescribeTrustedAdvisorChecksResultUnmarshaller instance;
        public static DescribeTrustedAdvisorChecksResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeTrustedAdvisorChecksResultUnmarshaller();
            return instance;
        }
    }
}
  
