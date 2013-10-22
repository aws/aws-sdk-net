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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// MarkerRecordedEventAttributesUnmarshaller
      /// </summary>
      internal class MarkerRecordedEventAttributesUnmarshaller : IUnmarshaller<MarkerRecordedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<MarkerRecordedEventAttributes, JsonUnmarshallerContext>
      {
        MarkerRecordedEventAttributes IUnmarshaller<MarkerRecordedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public MarkerRecordedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            MarkerRecordedEventAttributes markerRecordedEventAttributes = new MarkerRecordedEventAttributes();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("markerName", targetDepth))
              {
                context.Read();
                markerRecordedEventAttributes.MarkerName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("details", targetDepth))
              {
                context.Read();
                markerRecordedEventAttributes.Details = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
              {
                context.Read();
                markerRecordedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return markerRecordedEventAttributes;
                }
            }
          

            return markerRecordedEventAttributes;
        }

        private static MarkerRecordedEventAttributesUnmarshaller instance;
        public static MarkerRecordedEventAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new MarkerRecordedEventAttributesUnmarshaller();
            return instance;
        }
    }
}
  
