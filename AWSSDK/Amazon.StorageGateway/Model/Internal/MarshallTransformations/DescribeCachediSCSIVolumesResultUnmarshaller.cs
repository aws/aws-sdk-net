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
      /// DescribeCachediSCSIVolumesResultUnmarshaller 
      /// </summary> 
      internal class DescribeCachediSCSIVolumesResultUnmarshaller : IUnmarshaller<DescribeCachediSCSIVolumesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeCachediSCSIVolumesResult, JsonUnmarshallerContext> 
      { 
        DescribeCachediSCSIVolumesResult IUnmarshaller<DescribeCachediSCSIVolumesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeCachediSCSIVolumesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeCachediSCSIVolumesResult describeCachediSCSIVolumesResult = new DescribeCachediSCSIVolumesResult();
          describeCachediSCSIVolumesResult.CachediSCSIVolumes = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("CachediSCSIVolumes", targetDepth)) 
              {
                describeCachediSCSIVolumesResult.CachediSCSIVolumes = new List<CachediSCSIVolume>();
                        CachediSCSIVolumeUnmarshaller unmarshaller = CachediSCSIVolumeUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeCachediSCSIVolumesResult.CachediSCSIVolumes.Add(unmarshaller.Unmarshall(context));
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
                    return describeCachediSCSIVolumesResult; 
                } 
            } 
          
          
            return describeCachediSCSIVolumesResult; 
        } 
        
        private static DescribeCachediSCSIVolumesResultUnmarshaller instance; 
        public static DescribeCachediSCSIVolumesResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeCachediSCSIVolumesResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
