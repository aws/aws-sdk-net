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
      /// DecisionTaskCompletedEventAttributesUnmarshaller 
      /// </summary> 
      internal class DecisionTaskCompletedEventAttributesUnmarshaller : IUnmarshaller<DecisionTaskCompletedEventAttributes, UnmarshallerContext>, IUnmarshaller<DecisionTaskCompletedEventAttributes, JsonUnmarshallerContext> 
      { 
        DecisionTaskCompletedEventAttributes IUnmarshaller<DecisionTaskCompletedEventAttributes, UnmarshallerContext>.Unmarshall(UnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DecisionTaskCompletedEventAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          DecisionTaskCompletedEventAttributes decisionTaskCompletedEventAttributes = new DecisionTaskCompletedEventAttributes();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("ExecutionContext", targetDepth)) 
              {
                decisionTaskCompletedEventAttributes.ExecutionContext = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ScheduledEventId", targetDepth)) 
              {
                decisionTaskCompletedEventAttributes.ScheduledEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("StartedEventId", targetDepth)) 
              {
                decisionTaskCompletedEventAttributes.StartedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return decisionTaskCompletedEventAttributes; 
            } 
          } 
          return decisionTaskCompletedEventAttributes; 
        } 
        
        private static DecisionTaskCompletedEventAttributesUnmarshaller instance; 
        public static DecisionTaskCompletedEventAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new DecisionTaskCompletedEventAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
