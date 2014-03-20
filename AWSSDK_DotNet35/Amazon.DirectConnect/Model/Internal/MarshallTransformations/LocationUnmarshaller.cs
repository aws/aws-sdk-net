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
    using ThirdParty.Json.LitJson;
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// LocationUnmarshaller
      /// </summary>
      internal class LocationUnmarshaller : IUnmarshaller<Location, XmlUnmarshallerContext>, IUnmarshaller<Location, JsonUnmarshallerContext>
      {
        Location IUnmarshaller<Location, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Location Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Location location = new Location();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("locationCode", targetDepth))
              {
                location.LocationCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("locationName", targetDepth))
              {
                location.LocationName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return location;
        }

        private static LocationUnmarshaller instance;
        public static LocationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new LocationUnmarshaller();
            return instance;
        }
    }
}
  
