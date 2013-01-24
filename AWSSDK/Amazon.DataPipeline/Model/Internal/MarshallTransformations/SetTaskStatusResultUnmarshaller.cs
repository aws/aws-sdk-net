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
    using Amazon.DataPipeline.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// SetTaskStatusResultUnmarshaller
      /// </summary>
      internal class SetTaskStatusResultUnmarshaller : IUnmarshaller<SetTaskStatusResult, XmlUnmarshallerContext>, IUnmarshaller<SetTaskStatusResult, JsonUnmarshallerContext>
      {
        SetTaskStatusResult IUnmarshaller<SetTaskStatusResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public SetTaskStatusResult Unmarshall(JsonUnmarshallerContext context)
        {
            SetTaskStatusResult setTaskStatusResult = new SetTaskStatusResult();
          

            return setTaskStatusResult;
        }

        private static SetTaskStatusResultUnmarshaller instance;
        public static SetTaskStatusResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new SetTaskStatusResultUnmarshaller();
            return instance;
        }
    }
}
  
