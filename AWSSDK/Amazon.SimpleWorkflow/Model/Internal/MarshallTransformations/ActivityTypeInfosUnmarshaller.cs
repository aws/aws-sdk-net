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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ActivityTypeInfosUnmarshaller
      /// </summary>
      internal class ActivityTypeInfosUnmarshaller : IUnmarshaller<ActivityTypeInfos, XmlUnmarshallerContext>, IUnmarshaller<ActivityTypeInfos, JsonUnmarshallerContext>
      {
        ActivityTypeInfos IUnmarshaller<ActivityTypeInfos, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ActivityTypeInfos Unmarshall(JsonUnmarshallerContext context)
        {
            ActivityTypeInfos activityTypeInfos = new ActivityTypeInfos();
          activityTypeInfos.TypeInfos = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("TypeInfos", targetDepth))
              {
                activityTypeInfos.TypeInfos = new List<ActivityTypeInfo>();
                        ActivityTypeInfoUnmarshaller unmarshaller = ActivityTypeInfoUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     activityTypeInfos.TypeInfos.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("NextPageToken", targetDepth))
              {
                activityTypeInfos.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return activityTypeInfos;
                }
            }
          

            return activityTypeInfos;
        }

        private static ActivityTypeInfosUnmarshaller instance;
        public static ActivityTypeInfosUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ActivityTypeInfosUnmarshaller();
            return instance;
        }
    }
}
  
