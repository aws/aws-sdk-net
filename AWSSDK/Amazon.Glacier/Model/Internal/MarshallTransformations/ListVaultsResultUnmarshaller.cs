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
      /// ListVaultsResultUnmarshaller 
      /// </summary> 
      internal class ListVaultsResultUnmarshaller : IUnmarshaller<ListVaultsResult, XmlUnmarshallerContext>, IUnmarshaller<ListVaultsResult, JsonUnmarshallerContext> 
      { 
        ListVaultsResult IUnmarshaller<ListVaultsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ListVaultsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            ListVaultsResult listVaultsResult = new ListVaultsResult();
          listVaultsResult.VaultList = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("VaultList", targetDepth)) 
              {
                listVaultsResult.VaultList = new List<DescribeVaultOutput>();
                        DescribeVaultOutputUnmarshaller unmarshaller = DescribeVaultOutputUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listVaultsResult.VaultList.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
              if (context.TestExpression("Marker", targetDepth)) 
              {
                listVaultsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return listVaultsResult; 
                } 
            } 
          
          
            return listVaultsResult; 
        } 
        
        private static ListVaultsResultUnmarshaller instance; 
        public static ListVaultsResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new ListVaultsResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
