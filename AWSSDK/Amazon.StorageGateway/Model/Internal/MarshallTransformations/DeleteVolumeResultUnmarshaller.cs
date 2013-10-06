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
      /// DeleteVolumeResultUnmarshaller 
      /// </summary> 
      internal class DeleteVolumeResultUnmarshaller : IUnmarshaller<DeleteVolumeResult, XmlUnmarshallerContext>, IUnmarshaller<DeleteVolumeResult, JsonUnmarshallerContext> 
      { 
        DeleteVolumeResult IUnmarshaller<DeleteVolumeResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DeleteVolumeResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DeleteVolumeResult deleteVolumeResult = new DeleteVolumeResult();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("VolumeARN", targetDepth)) 
              {
                deleteVolumeResult.VolumeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return deleteVolumeResult; 
                } 
            } 
          
          
            return deleteVolumeResult; 
        } 
        
        private static DeleteVolumeResultUnmarshaller instance; 
        public static DeleteVolumeResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DeleteVolumeResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
