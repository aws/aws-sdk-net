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
      /// DescribeCasesResultUnmarshaller
      /// </summary>
      internal class DescribeCasesResultUnmarshaller : IUnmarshaller<DescribeCasesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeCasesResult, JsonUnmarshallerContext>
      {
        DescribeCasesResult IUnmarshaller<DescribeCasesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeCasesResult Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeCasesResult describeCasesResult = new DescribeCasesResult();
          describeCasesResult.Cases = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Cases", targetDepth))
              {
                describeCasesResult.Cases = new List<CaseDetails>();
                        CaseDetailsUnmarshaller unmarshaller = CaseDetailsUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeCasesResult.Cases.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("NextToken", targetDepth))
              {
                describeCasesResult.NextToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describeCasesResult;
                }
            }
          

            return describeCasesResult;
        }

        private static DescribeCasesResultUnmarshaller instance;
        public static DescribeCasesResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeCasesResultUnmarshaller();
            return instance;
        }
    }
}
  
