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
    using Amazon.Glacier.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// DescribeVaultResultUnmarshaller 
      /// </summary> 
      internal class DescribeVaultResultUnmarshaller : IUnmarshaller<DescribeVaultResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeVaultResult, JsonUnmarshallerContext> 
      { 
        DescribeVaultResult IUnmarshaller<DescribeVaultResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeVaultResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeVaultResult describeVaultResult = new DescribeVaultResult();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("VaultARN", targetDepth)) 
              {
                describeVaultResult.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VaultName", targetDepth)) 
              {
                describeVaultResult.VaultName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CreationDate", targetDepth)) 
              {
                describeVaultResult.CreationDate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("LastInventoryDate", targetDepth)) 
              {
                describeVaultResult.LastInventoryDate = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("NumberOfArchives", targetDepth)) 
              {
                describeVaultResult.NumberOfArchives = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("SizeInBytes", targetDepth)) 
              {
                describeVaultResult.SizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeVaultResult; 
                } 
            } 
          
          
            return describeVaultResult; 
        } 
        
        private static DescribeVaultResultUnmarshaller instance; 
        public static DescribeVaultResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeVaultResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
