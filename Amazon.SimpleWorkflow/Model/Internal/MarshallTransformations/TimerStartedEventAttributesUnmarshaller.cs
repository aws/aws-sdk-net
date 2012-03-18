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
    using Amazon.SimpleWorkflow.Model; 
    using Amazon.Runtime.Internal.Transform; 

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// TimerStartedEventAttributesUnmarshaller 
      /// </summary> 
      internal class TimerStartedEventAttributesUnmarshaller : IUnmarshaller<TimerStartedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<TimerStartedEventAttributes, JsonUnmarshallerContext> 
      { 
        TimerStartedEventAttributes IUnmarshaller<TimerStartedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public TimerStartedEventAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          TimerStartedEventAttributes timerStartedEventAttributes = new TimerStartedEventAttributes();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("TimerId", targetDepth)) 
              {
                timerStartedEventAttributes.TimerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Control", targetDepth)) 
              {
                timerStartedEventAttributes.Control = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("StartToFireTimeout", targetDepth)) 
              {
                timerStartedEventAttributes.StartToFireTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DecisionTaskCompletedEventId", targetDepth)) 
              {
                timerStartedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return timerStartedEventAttributes; 
            } 
          } 
          return timerStartedEventAttributes; 
        } 
        
        private static TimerStartedEventAttributesUnmarshaller instance; 
        public static TimerStartedEventAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new TimerStartedEventAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
