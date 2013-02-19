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
      /// ElasticIpUnmarshaller
      /// </summary>
      internal class ElasticIpUnmarshaller : IUnmarshaller<ElasticIp, XmlUnmarshallerContext>, IUnmarshaller<ElasticIp, JsonUnmarshallerContext>
      {
        ElasticIp IUnmarshaller<ElasticIp, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public ElasticIp Unmarshall(JsonUnmarshallerContext context)
        {
            ElasticIp elasticIp = new ElasticIp();
          
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("Ip", targetDepth))
              {
                elasticIp.Ip = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                elasticIp.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Region", targetDepth))
              {
                elasticIp.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return elasticIp;
                }
            }
          

            return elasticIp;
        }

        private static ElasticIpUnmarshaller instance;
        public static ElasticIpUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ElasticIpUnmarshaller();
            return instance;
        }
    }
}
  
