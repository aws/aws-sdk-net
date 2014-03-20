/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.Kinesis.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ListStreamsResultUnmarshaller
      /// </summary>
      internal class ListStreamsResultUnmarshaller : IUnmarshaller<ListStreamsResult, XmlUnmarshallerContext>, IUnmarshaller<ListStreamsResult, JsonUnmarshallerContext>
      {
        ListStreamsResult IUnmarshaller<ListStreamsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ListStreamsResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            ListStreamsResult listStreamsResult = new ListStreamsResult();
          listStreamsResult.StreamNames = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("StreamNames", targetDepth))
              {
                listStreamsResult.StreamNames = new List<String>();   
                if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                {
                  continue;
                }              

                  StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     listStreamsResult.StreamNames.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("HasMoreStreams", targetDepth))
              {
                listStreamsResult.HasMoreStreams = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return listStreamsResult;
                }
            }
          

            return listStreamsResult;
        }

        private static ListStreamsResultUnmarshaller instance;
        public static ListStreamsResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ListStreamsResultUnmarshaller();
            return instance;
        }
    }
}
  
