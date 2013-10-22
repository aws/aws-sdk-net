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
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ProvisionedThroughputDescriptionUnmarshaller
      /// </summary>
      internal class ProvisionedThroughputDescriptionUnmarshaller : IUnmarshaller<ProvisionedThroughputDescription, XmlUnmarshallerContext>, IUnmarshaller<ProvisionedThroughputDescription, JsonUnmarshallerContext>
      {
        ProvisionedThroughputDescription IUnmarshaller<ProvisionedThroughputDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ProvisionedThroughputDescription Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            ProvisionedThroughputDescription provisionedThroughputDescription = new ProvisionedThroughputDescription();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("LastIncreaseDateTime", targetDepth))
              {
                context.Read();
                provisionedThroughputDescription.LastIncreaseDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LastDecreaseDateTime", targetDepth))
              {
                context.Read();
                provisionedThroughputDescription.LastDecreaseDateTime = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("NumberOfDecreasesToday", targetDepth))
              {
                context.Read();
                provisionedThroughputDescription.NumberOfDecreasesToday = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ReadCapacityUnits", targetDepth))
              {
                context.Read();
                provisionedThroughputDescription.ReadCapacityUnits = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("WriteCapacityUnits", targetDepth))
              {
                context.Read();
                provisionedThroughputDescription.WriteCapacityUnits = LongUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return provisionedThroughputDescription;
                }
            }
          

            return provisionedThroughputDescription;
        }

        private static ProvisionedThroughputDescriptionUnmarshaller instance;
        public static ProvisionedThroughputDescriptionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ProvisionedThroughputDescriptionUnmarshaller();
            return instance;
        }
    }
}
  
