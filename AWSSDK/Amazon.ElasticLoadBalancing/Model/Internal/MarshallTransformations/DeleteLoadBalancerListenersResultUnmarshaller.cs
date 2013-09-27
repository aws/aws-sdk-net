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
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DeleteLoadBalancerListenersResult Unmarshaller
     /// </summary>
    internal class DeleteLoadBalancerListenersResultUnmarshaller : IUnmarshaller<DeleteLoadBalancerListenersResult, XmlUnmarshallerContext>, IUnmarshaller<DeleteLoadBalancerListenersResult, JsonUnmarshallerContext> 
    {
        public DeleteLoadBalancerListenersResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DeleteLoadBalancerListenersResult deleteLoadBalancerListenersResult = new DeleteLoadBalancerListenersResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return deleteLoadBalancerListenersResult;
                }
            }
                        


            return deleteLoadBalancerListenersResult;
        }

        public DeleteLoadBalancerListenersResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DeleteLoadBalancerListenersResultUnmarshaller instance;

        public static DeleteLoadBalancerListenersResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DeleteLoadBalancerListenersResultUnmarshaller();

            return instance;
        }
    }
}
    
