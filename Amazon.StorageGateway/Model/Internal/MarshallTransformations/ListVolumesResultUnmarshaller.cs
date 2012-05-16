/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.StorageGateway.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// ListVolumesResultUnmarshaller 
      /// </summary> 
      internal class ListVolumesResultUnmarshaller : IUnmarshaller<ListVolumesResult, XmlUnmarshallerContext>, IUnmarshaller<ListVolumesResult, JsonUnmarshallerContext> 
      { 
        ListVolumesResult IUnmarshaller<ListVolumesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public ListVolumesResult Unmarshall(JsonUnmarshallerContext context) 
        { 
          ListVolumesResult listVolumesResult = new ListVolumesResult();
          listVolumesResult.VolumeInfos = null; 
                        
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("GatewayARN", targetDepth)) 
              {
                listVolumesResult.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Marker", targetDepth)) 
              {
                listVolumesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("VolumeInfos", targetDepth)) 
              {
                listVolumesResult.VolumeInfos = new List<VolumeInfo>();
                        VolumeInfoUnmarshaller unmarshaller = VolumeInfoUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listVolumesResult.VolumeInfos.Add(unmarshaller.Unmarshall(context));
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
              return listVolumesResult; 
            } 
          } 
          return listVolumesResult; 
        } 
        
        private static ListVolumesResultUnmarshaller instance; 
        public static ListVolumesResultUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new ListVolumesResultUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
