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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// DescribeVirtualInterfacesResultUnmarshaller 
      /// </summary> 
      internal class DescribeVirtualInterfacesResultUnmarshaller : IUnmarshaller<DescribeVirtualInterfacesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeVirtualInterfacesResult, JsonUnmarshallerContext> 
      { 
        DescribeVirtualInterfacesResult IUnmarshaller<DescribeVirtualInterfacesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeVirtualInterfacesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeVirtualInterfacesResult describeVirtualInterfacesResult = new DescribeVirtualInterfacesResult();
          describeVirtualInterfacesResult.VirtualInterfaces = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("VirtualInterfaces", targetDepth)) 
              {
                describeVirtualInterfacesResult.VirtualInterfaces = new List<VirtualInterface>();
                        VirtualInterfaceUnmarshaller unmarshaller = VirtualInterfaceUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeVirtualInterfacesResult.VirtualInterfaces.Add(unmarshaller.Unmarshall(context));
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
                    return describeVirtualInterfacesResult; 
                } 
            } 
          
          
            return describeVirtualInterfacesResult; 
        } 
        
        private static DescribeVirtualInterfacesResultUnmarshaller instance; 
        public static DescribeVirtualInterfacesResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeVirtualInterfacesResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
