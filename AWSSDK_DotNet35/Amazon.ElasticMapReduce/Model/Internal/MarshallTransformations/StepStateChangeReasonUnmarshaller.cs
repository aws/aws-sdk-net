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
      /// StepStateChangeReasonUnmarshaller
      /// </summary>
      internal class StepStateChangeReasonUnmarshaller : IUnmarshaller<StepStateChangeReason, XmlUnmarshallerContext>, IUnmarshaller<StepStateChangeReason, JsonUnmarshallerContext>
      {
        StepStateChangeReason IUnmarshaller<StepStateChangeReason, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StepStateChangeReason Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            StepStateChangeReason stepStateChangeReason = new StepStateChangeReason();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("Code", targetDepth))
              {
                context.Read();
                stepStateChangeReason.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Message", targetDepth))
              {
                context.Read();
                stepStateChangeReason.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return stepStateChangeReason;
                }
            }
          

            return stepStateChangeReason;
        }

        private static StepStateChangeReasonUnmarshaller instance;
        public static StepStateChangeReasonUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StepStateChangeReasonUnmarshaller();
            return instance;
        }
    }
}
  
