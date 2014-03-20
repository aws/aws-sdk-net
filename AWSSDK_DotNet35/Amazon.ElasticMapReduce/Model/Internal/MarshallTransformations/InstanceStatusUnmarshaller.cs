/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// InstanceStatusUnmarshaller
      /// </summary>
      internal class InstanceStatusUnmarshaller : IUnmarshaller<InstanceStatus, XmlUnmarshallerContext>, IUnmarshaller<InstanceStatus, JsonUnmarshallerContext>
      {
        InstanceStatus IUnmarshaller<InstanceStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public InstanceStatus Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            InstanceStatus instanceStatus = new InstanceStatus();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("State", targetDepth))
              {
                instanceStatus.State = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("StateChangeReason", targetDepth))
              {
                instanceStatus.StateChangeReason = InstanceStateChangeReasonUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Timeline", targetDepth))
              {
                instanceStatus.Timeline = InstanceTimelineUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return instanceStatus;
        }

        private static InstanceStatusUnmarshaller instance;
        public static InstanceStatusUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InstanceStatusUnmarshaller();
            return instance;
        }
    }
}
  
