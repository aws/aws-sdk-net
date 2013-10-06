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
      /// CancelJobResultUnmarshaller
      /// </summary>
      internal class CancelJobResultUnmarshaller : IUnmarshaller<CancelJobResult, XmlUnmarshallerContext>, IUnmarshaller<CancelJobResult, JsonUnmarshallerContext>
      {
        CancelJobResult IUnmarshaller<CancelJobResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CancelJobResult Unmarshall(JsonUnmarshallerContext context)
        {
            CancelJobResult cancelJobResult = new CancelJobResult();
          

            return cancelJobResult;
        }

        private static CancelJobResultUnmarshaller instance;
        public static CancelJobResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CancelJobResultUnmarshaller();
            return instance;
        }
    }
}
  
