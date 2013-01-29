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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DomainInfosUnmarshaller
      /// </summary>
      internal class DomainInfosUnmarshaller : IUnmarshaller<DomainInfos, XmlUnmarshallerContext>, IUnmarshaller<DomainInfos, JsonUnmarshallerContext>
      {
        DomainInfos IUnmarshaller<DomainInfos, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DomainInfos Unmarshall(JsonUnmarshallerContext context)
        {
            DomainInfos domainInfos = new DomainInfos();
          domainInfos.Name = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("DomainInfos", targetDepth))
              {
                domainInfos.Name = new List<DomainInfo>();
                        DomainInfoUnmarshaller unmarshaller = DomainInfoUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     domainInfos.Name.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("NextPageToken", targetDepth))
              {
                domainInfos.NextPageToken = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return domainInfos;
                }
            }
          

            return domainInfos;
        }

        private static DomainInfosUnmarshaller instance;
        public static DomainInfosUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DomainInfosUnmarshaller();
            return instance;
        }
    }
}
  
