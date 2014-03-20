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
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// TrustedAdvisorResourceDetailUnmarshaller
      /// </summary>
      internal class TrustedAdvisorResourceDetailUnmarshaller : IUnmarshaller<TrustedAdvisorResourceDetail, XmlUnmarshallerContext>, IUnmarshaller<TrustedAdvisorResourceDetail, JsonUnmarshallerContext>
      {
        TrustedAdvisorResourceDetail IUnmarshaller<TrustedAdvisorResourceDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public TrustedAdvisorResourceDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            TrustedAdvisorResourceDetail trustedAdvisorResourceDetail = new TrustedAdvisorResourceDetail();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("status", targetDepth))
              {
                trustedAdvisorResourceDetail.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("region", targetDepth))
              {
                trustedAdvisorResourceDetail.Region = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("resourceId", targetDepth))
              {
                trustedAdvisorResourceDetail.ResourceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("isSuppressed", targetDepth))
              {
                trustedAdvisorResourceDetail.IsSuppressed = BoolUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("metadata", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                trustedAdvisorResourceDetail.Metadata = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
            }
          
            return trustedAdvisorResourceDetail;
        }

        private static TrustedAdvisorResourceDetailUnmarshaller instance;
        public static TrustedAdvisorResourceDetailUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new TrustedAdvisorResourceDetailUnmarshaller();
            return instance;
        }
    }
}
  
