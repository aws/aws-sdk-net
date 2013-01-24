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
      /// DescribeVaultOutputUnmarshaller 
      /// </summary> 
      internal class DescribeVaultOutputUnmarshaller : IUnmarshaller<DescribeVaultOutput, XmlUnmarshallerContext>, IUnmarshaller<DescribeVaultOutput, JsonUnmarshallerContext> 
      { 
        DescribeVaultOutput IUnmarshaller<DescribeVaultOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeVaultOutput Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeVaultOutput describeVaultOutput = new DescribeVaultOutput();
                    
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
                describeVaultOutput.VaultARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VaultName", targetDepth)) 
              {
                describeVaultOutput.VaultName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("CreationDate", targetDepth)) 
              {
                describeVaultOutput.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("LastInventoryDate", targetDepth)) 
              {
                describeVaultOutput.LastInventoryDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("NumberOfArchives", targetDepth)) 
              {
                describeVaultOutput.NumberOfArchives = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("SizeInBytes", targetDepth)) 
              {
                describeVaultOutput.SizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeVaultOutput; 
                } 
            } 
          
          
            return describeVaultOutput; 
        } 
        
        private static DescribeVaultOutputUnmarshaller instance; 
        public static DescribeVaultOutputUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeVaultOutputUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
