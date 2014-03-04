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
    using Amazon.CloudTrail.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// StopLoggingResultUnmarshaller
      /// </summary>
      internal class StopLoggingResultUnmarshaller : IUnmarshaller<StopLoggingResult, XmlUnmarshallerContext>, IUnmarshaller<StopLoggingResult, JsonUnmarshallerContext>
      {
        StopLoggingResult IUnmarshaller<StopLoggingResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public StopLoggingResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            StopLoggingResult stopLoggingResult = new StopLoggingResult();
          

            return stopLoggingResult;
        }

        private static StopLoggingResultUnmarshaller instance;
        public static StopLoggingResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new StopLoggingResultUnmarshaller();
            return instance;
        }
    }
}
  
