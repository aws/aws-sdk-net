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
    using ThirdParty.Json.LitJson;
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TapeUnmarshaller
      /// </summary>
      internal class TapeUnmarshaller : IUnmarshaller<Tape, XmlUnmarshallerContext>, IUnmarshaller<Tape, JsonUnmarshallerContext>
      {
        Tape IUnmarshaller<Tape, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Tape Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            Tape tape = new Tape();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("TapeARN", targetDepth))
              {
                context.Read();
                tape.TapeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TapeBarcode", targetDepth))
              {
                context.Read();
                tape.TapeBarcode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TapeSizeInBytes", targetDepth))
              {
                context.Read();
                tape.TapeSizeInBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TapeStatus", targetDepth))
              {
                context.Read();
                tape.TapeStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VTLDevice", targetDepth))
              {
                context.Read();
                tape.VTLDevice = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Progress", targetDepth))
              {
                context.Read();
                tape.Progress = DoubleUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return tape;
                }
            }
          

            return tape;
        }

        private static TapeUnmarshaller instance;
        public static TapeUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TapeUnmarshaller();
            return instance;
        }
    }
}
  
