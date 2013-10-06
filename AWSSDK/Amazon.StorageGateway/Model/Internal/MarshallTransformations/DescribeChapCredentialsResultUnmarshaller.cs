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
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// DescribeChapCredentialsResultUnmarshaller 
      /// </summary> 
      internal class DescribeChapCredentialsResultUnmarshaller : IUnmarshaller<DescribeChapCredentialsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeChapCredentialsResult, JsonUnmarshallerContext> 
      { 
        DescribeChapCredentialsResult IUnmarshaller<DescribeChapCredentialsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeChapCredentialsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeChapCredentialsResult describeChapCredentialsResult = new DescribeChapCredentialsResult();
          describeChapCredentialsResult.ChapCredentials = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("ChapCredentials", targetDepth)) 
              {
                describeChapCredentialsResult.ChapCredentials = new List<ChapInfo>();
                        ChapInfoUnmarshaller unmarshaller = ChapInfoUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeChapCredentialsResult.ChapCredentials.Add(unmarshaller.Unmarshall(context));
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
                    return describeChapCredentialsResult; 
                } 
            } 
          
          
            return describeChapCredentialsResult; 
        } 
        
        private static DescribeChapCredentialsResultUnmarshaller instance; 
        public static DescribeChapCredentialsResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeChapCredentialsResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
