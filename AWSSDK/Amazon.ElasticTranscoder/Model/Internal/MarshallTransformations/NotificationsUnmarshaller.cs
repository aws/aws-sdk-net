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
    using Amazon.ElasticTranscoder.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// NotificationsUnmarshaller
      /// </summary>
      internal class NotificationsUnmarshaller : IUnmarshaller<Notifications, XmlUnmarshallerContext>, IUnmarshaller<Notifications, JsonUnmarshallerContext>
      {
        Notifications IUnmarshaller<Notifications, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Notifications Unmarshall(JsonUnmarshallerContext context)
        {
            Notifications notifications = new Notifications();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Progressing", targetDepth))
              {
                notifications.Progressing = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Completed", targetDepth))
              {
                notifications.Completed = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Warning", targetDepth))
              {
                notifications.Warning = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Error", targetDepth))
              {
                notifications.Error = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return notifications;
                }
            }
          

            return notifications;
        }

        private static NotificationsUnmarshaller instance;
        public static NotificationsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new NotificationsUnmarshaller();
            return instance;
        }
    }
}
  
