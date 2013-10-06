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
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// ConnectionUnmarshaller 
      /// </summary> 
      internal class ConnectionUnmarshaller : IUnmarshaller<Connection, XmlUnmarshallerContext>, IUnmarshaller<Connection, JsonUnmarshallerContext> 
      { 
        Connection IUnmarshaller<Connection, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public Connection Unmarshall(JsonUnmarshallerContext context) 
        {
            Connection connection = new Connection();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("ConnectionId", targetDepth)) 
              {
                connection.ConnectionId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConnectionName", targetDepth)) 
              {
                connection.ConnectionName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("ConnectionState", targetDepth)) 
              {
                connection.ConnectionState = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Region", targetDepth)) 
              {
                connection.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Location", targetDepth)) 
              {
                connection.Location = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return connection; 
                } 
            } 
          
          
            return connection; 
        } 
        
        private static ConnectionUnmarshaller instance; 
        public static ConnectionUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new ConnectionUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
