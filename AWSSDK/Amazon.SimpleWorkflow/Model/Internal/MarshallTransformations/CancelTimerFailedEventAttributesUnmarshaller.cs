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
      /// CancelTimerFailedEventAttributesUnmarshaller 
      /// </summary> 
      internal class CancelTimerFailedEventAttributesUnmarshaller : IUnmarshaller<CancelTimerFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<CancelTimerFailedEventAttributes, JsonUnmarshallerContext> 
      { 
        CancelTimerFailedEventAttributes IUnmarshaller<CancelTimerFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public CancelTimerFailedEventAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          CancelTimerFailedEventAttributes cancelTimerFailedEventAttributes = new CancelTimerFailedEventAttributes();
          
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
                cancelTimerFailedEventAttributes.TimerId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Cause", targetDepth)) 
              {
                cancelTimerFailedEventAttributes.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DecisionTaskCompletedEventId", targetDepth)) 
              {
                cancelTimerFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return cancelTimerFailedEventAttributes; 
            } 
          } 
          return cancelTimerFailedEventAttributes; 
        } 
        
        private static CancelTimerFailedEventAttributesUnmarshaller instance; 
        public static CancelTimerFailedEventAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new CancelTimerFailedEventAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
