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
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DeleteTapeResultUnmarshaller
      /// </summary>
      internal class DeleteTapeResultUnmarshaller : IUnmarshaller<DeleteTapeResult, XmlUnmarshallerContext>, IUnmarshaller<DeleteTapeResult, JsonUnmarshallerContext>
      {
        DeleteTapeResult IUnmarshaller<DeleteTapeResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DeleteTapeResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            DeleteTapeResult deleteTapeResult = new DeleteTapeResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("TapeARN", targetDepth))
              {
                deleteTapeResult.TapeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return deleteTapeResult;
                }
            }
          

            return deleteTapeResult;
        }

        private static DeleteTapeResultUnmarshaller instance;
        public static DeleteTapeResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DeleteTapeResultUnmarshaller();
            return instance;
        }
    }
}
  
