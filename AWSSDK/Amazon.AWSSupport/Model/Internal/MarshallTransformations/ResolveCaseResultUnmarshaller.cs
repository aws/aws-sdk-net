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
      /// ResolveCaseResultUnmarshaller
      /// </summary>
      internal class ResolveCaseResultUnmarshaller : IUnmarshaller<ResolveCaseResult, XmlUnmarshallerContext>, IUnmarshaller<ResolveCaseResult, JsonUnmarshallerContext>
      {
        ResolveCaseResult IUnmarshaller<ResolveCaseResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ResolveCaseResult Unmarshall(JsonUnmarshallerContext context)
        {
            ResolveCaseResult resolveCaseResult = new ResolveCaseResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("InitialCaseStatus", targetDepth))
              {
                resolveCaseResult.InitialCaseStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("FinalCaseStatus", targetDepth))
              {
                resolveCaseResult.FinalCaseStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return resolveCaseResult;
                }
            }
          

            return resolveCaseResult;
        }

        private static ResolveCaseResultUnmarshaller instance;
        public static ResolveCaseResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ResolveCaseResultUnmarshaller();
            return instance;
        }
    }
}
  
