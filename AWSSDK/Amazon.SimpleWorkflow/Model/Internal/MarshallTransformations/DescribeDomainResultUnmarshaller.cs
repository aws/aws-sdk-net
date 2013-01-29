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
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Result Unmarshaller for DescribeDomain operation
      /// </summary>
      internal class DescribeDomainResultUnmarshaller : IUnmarshaller<DescribeDomainResult, JsonUnmarshallerContext>
      {
        public DescribeDomainResult Unmarshall(JsonUnmarshallerContext context)
        {
          DescribeDomainResult result = new DescribeDomainResult();
          result.DomainDetail = DomainDetailUnmarshaller.GetInstance().Unmarshall(context);
          return result;
        }

        private static DescribeDomainResultUnmarshaller instance;
        public static DescribeDomainResultUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new DescribeDomainResultUnmarshaller();
          }
          return instance;
        }
      }
    }
  
