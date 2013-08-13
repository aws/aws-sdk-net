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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// AddInstanceGroupsResultUnmarshaller
      /// </summary>
      internal class AddInstanceGroupsResultUnmarshaller : IUnmarshaller<AddInstanceGroupsResult, XmlUnmarshallerContext>, IUnmarshaller<AddInstanceGroupsResult, JsonUnmarshallerContext>
      {
        AddInstanceGroupsResult IUnmarshaller<AddInstanceGroupsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public AddInstanceGroupsResult Unmarshall(JsonUnmarshallerContext context)
        {
            AddInstanceGroupsResult addInstanceGroupsResult = new AddInstanceGroupsResult();
          addInstanceGroupsResult.InstanceGroupIds = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("JobFlowId", targetDepth))
              {
                addInstanceGroupsResult.JobFlowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("InstanceGroupIds", targetDepth))
              {
                addInstanceGroupsResult.InstanceGroupIds = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     addInstanceGroupsResult.InstanceGroupIds.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return addInstanceGroupsResult;
                }
            }
          

            return addInstanceGroupsResult;
        }

        private static AddInstanceGroupsResultUnmarshaller instance;
        public static AddInstanceGroupsResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AddInstanceGroupsResultUnmarshaller();
            return instance;
        }
    }
}
  
