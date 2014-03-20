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
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// ClusterUnmarshaller
      /// </summary>
      internal class ClusterUnmarshaller : IUnmarshaller<Cluster, XmlUnmarshallerContext>, IUnmarshaller<Cluster, JsonUnmarshallerContext>
      {
        Cluster IUnmarshaller<Cluster, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Cluster Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Cluster cluster = new Cluster();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Id", targetDepth))
              {
                cluster.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Name", targetDepth))
              {
                cluster.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                cluster.Status = ClusterStatusUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2InstanceAttributes", targetDepth))
              {
                cluster.Ec2InstanceAttributes = Ec2InstanceAttributesUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("LogUri", targetDepth))
              {
                cluster.LogUri = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RequestedAmiVersion", targetDepth))
              {
                cluster.RequestedAmiVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RunningAmiVersion", targetDepth))
              {
                cluster.RunningAmiVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AutoTerminate", targetDepth))
              {
                cluster.AutoTerminate = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TerminationProtected", targetDepth))
              {
                cluster.TerminationProtected = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VisibleToAllUsers", targetDepth))
              {
                cluster.VisibleToAllUsers = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Applications", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<Application,ApplicationUnmarshaller>(
                    ApplicationUnmarshaller.GetInstance());                  
                cluster.Applications = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("Tags", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<Tag,TagUnmarshaller>(
                    TagUnmarshaller.GetInstance());                  
                cluster.Tags = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return cluster;
        }

        private static ClusterUnmarshaller instance;
        public static ClusterUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new ClusterUnmarshaller();
            return instance;
        }
    }
}
  
