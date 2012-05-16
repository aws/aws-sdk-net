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
      /// VolumeiSCSIAttributesUnmarshaller 
      /// </summary> 
      internal class VolumeiSCSIAttributesUnmarshaller : IUnmarshaller<VolumeiSCSIAttributes, XmlUnmarshallerContext>, IUnmarshaller<VolumeiSCSIAttributes, JsonUnmarshallerContext> 
      { 
        VolumeiSCSIAttributes IUnmarshaller<VolumeiSCSIAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public VolumeiSCSIAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          VolumeiSCSIAttributes volumeiSCSIAttributes = new VolumeiSCSIAttributes();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("TargetARN", targetDepth)) 
              {
                volumeiSCSIAttributes.TargetARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("NetworkInterfaceId", targetDepth)) 
              {
                volumeiSCSIAttributes.NetworkInterfaceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("NetworkInterfacePort", targetDepth)) 
              {
                volumeiSCSIAttributes.NetworkInterfacePort = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("LunNumber", targetDepth)) 
              {
                volumeiSCSIAttributes.LunNumber = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ChapEnabled", targetDepth)) 
              {
                volumeiSCSIAttributes.ChapEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return volumeiSCSIAttributes; 
            } 
          } 
          return volumeiSCSIAttributes; 
        } 
        
        private static VolumeiSCSIAttributesUnmarshaller instance; 
        public static VolumeiSCSIAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new VolumeiSCSIAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
