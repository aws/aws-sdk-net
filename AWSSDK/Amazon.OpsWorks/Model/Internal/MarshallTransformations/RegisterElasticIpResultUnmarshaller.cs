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
    using Amazon.OpsWorks.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// RegisterElasticIpResultUnmarshaller
      /// </summary>
      internal class RegisterElasticIpResultUnmarshaller : IUnmarshaller<RegisterElasticIpResult, XmlUnmarshallerContext>, IUnmarshaller<RegisterElasticIpResult, JsonUnmarshallerContext>
      {
        RegisterElasticIpResult IUnmarshaller<RegisterElasticIpResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public RegisterElasticIpResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            RegisterElasticIpResult registerElasticIpResult = new RegisterElasticIpResult();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("ElasticIp", targetDepth))
              {
                registerElasticIpResult.ElasticIp = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return registerElasticIpResult;
                }
            }
          

            return registerElasticIpResult;
        }

        private static RegisterElasticIpResultUnmarshaller instance;
        public static RegisterElasticIpResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new RegisterElasticIpResultUnmarshaller();
            return instance;
        }
    }
}
  
