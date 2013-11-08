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
    using Amazon.Glacier.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.Glacier.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// PartListElementUnmarshaller
      /// </summary>
      internal class PartListElementUnmarshaller : IUnmarshaller<PartListElement, XmlUnmarshallerContext>, IUnmarshaller<PartListElement, JsonUnmarshallerContext>
      {
        PartListElement IUnmarshaller<PartListElement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public PartListElement Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            PartListElement partListElement = new PartListElement();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("RangeInBytes", targetDepth))
              {
                context.Read();
                partListElement.RangeInBytes = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SHA256TreeHash", targetDepth))
              {
                context.Read();
                partListElement.SHA256TreeHash = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return partListElement;
                }
            }
          

            return partListElement;
        }

        private static PartListElementUnmarshaller instance;
        public static PartListElementUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new PartListElementUnmarshaller();
            return instance;
        }
    }
}
  
