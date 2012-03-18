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
      /// RequestCancelActivityTaskFailedEventAttributesUnmarshaller 
      /// </summary> 
      internal class RequestCancelActivityTaskFailedEventAttributesUnmarshaller : IUnmarshaller<RequestCancelActivityTaskFailedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<RequestCancelActivityTaskFailedEventAttributes, JsonUnmarshallerContext> 
      { 
        RequestCancelActivityTaskFailedEventAttributes IUnmarshaller<RequestCancelActivityTaskFailedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public RequestCancelActivityTaskFailedEventAttributes Unmarshall(JsonUnmarshallerContext context) 
        { 
          RequestCancelActivityTaskFailedEventAttributes requestCancelActivityTaskFailedEventAttributes = new RequestCancelActivityTaskFailedEventAttributes();
          
          int originalDepth = context.CurrentDepth;
          int targetDepth = originalDepth + 1;
          while (context.Read())
          {
            if ((context.IsKey) && (context.CurrentDepth == targetDepth))
            {
              context.Read();
              context.Read();
               
              if (context.TestExpression("ActivityId", targetDepth)) 
              {
                requestCancelActivityTaskFailedEventAttributes.ActivityId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Cause", targetDepth)) 
              {
                requestCancelActivityTaskFailedEventAttributes.Cause = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("DecisionTaskCompletedEventId", targetDepth)) 
              {
                requestCancelActivityTaskFailedEventAttributes.DecisionTaskCompletedEventId = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
            } 
            else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
            { 
              return requestCancelActivityTaskFailedEventAttributes; 
            } 
          } 
          return requestCancelActivityTaskFailedEventAttributes; 
        } 
        
        private static RequestCancelActivityTaskFailedEventAttributesUnmarshaller instance; 
        public static RequestCancelActivityTaskFailedEventAttributesUnmarshaller GetInstance() 
        { 
          if (instance == null) 
            instance = new RequestCancelActivityTaskFailedEventAttributesUnmarshaller(); 
          return instance;
        } 
      } 
    } 
  
