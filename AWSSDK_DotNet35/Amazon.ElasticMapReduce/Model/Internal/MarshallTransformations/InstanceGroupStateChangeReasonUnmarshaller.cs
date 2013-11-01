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
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// InstanceGroupStateChangeReasonUnmarshaller
      /// </summary>
      internal class InstanceGroupStateChangeReasonUnmarshaller : IUnmarshaller<InstanceGroupStateChangeReason, XmlUnmarshallerContext>, IUnmarshaller<InstanceGroupStateChangeReason, JsonUnmarshallerContext>
      {
        InstanceGroupStateChangeReason IUnmarshaller<InstanceGroupStateChangeReason, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public InstanceGroupStateChangeReason Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            InstanceGroupStateChangeReason instanceGroupStateChangeReason = new InstanceGroupStateChangeReason();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Code", targetDepth))
              {
                context.Read();
                instanceGroupStateChangeReason.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Message", targetDepth))
              {
                context.Read();
                instanceGroupStateChangeReason.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return instanceGroupStateChangeReason;
                }
            }
          

            return instanceGroupStateChangeReason;
        }

        private static InstanceGroupStateChangeReasonUnmarshaller instance;
        public static InstanceGroupStateChangeReasonUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new InstanceGroupStateChangeReasonUnmarshaller();
            return instance;
        }
    }
}
  
