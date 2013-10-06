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
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// AddCommunicationToCaseResultUnmarshaller
      /// </summary>
      internal class AddCommunicationToCaseResultUnmarshaller : IUnmarshaller<AddCommunicationToCaseResult, XmlUnmarshallerContext>, IUnmarshaller<AddCommunicationToCaseResult, JsonUnmarshallerContext>
      {
        AddCommunicationToCaseResult IUnmarshaller<AddCommunicationToCaseResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public AddCommunicationToCaseResult Unmarshall(JsonUnmarshallerContext context)
        {
            AddCommunicationToCaseResult addCommunicationToCaseResult = new AddCommunicationToCaseResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Result", targetDepth))
              {
                addCommunicationToCaseResult.Result = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return addCommunicationToCaseResult;
                }
            }
          

            return addCommunicationToCaseResult;
        }

        private static AddCommunicationToCaseResultUnmarshaller instance;
        public static AddCommunicationToCaseResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AddCommunicationToCaseResultUnmarshaller();
            return instance;
        }
    }
}
  
