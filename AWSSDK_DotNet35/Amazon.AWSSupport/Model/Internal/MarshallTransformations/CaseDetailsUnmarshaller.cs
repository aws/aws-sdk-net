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
      /// CaseDetailsUnmarshaller
      /// </summary>
      internal class CaseDetailsUnmarshaller : IUnmarshaller<CaseDetails, XmlUnmarshallerContext>, IUnmarshaller<CaseDetails, JsonUnmarshallerContext>
      {
        CaseDetails IUnmarshaller<CaseDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public CaseDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            CaseDetails caseDetails = new CaseDetails();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("caseId", targetDepth))
              {
                caseDetails.CaseId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("displayId", targetDepth))
              {
                caseDetails.DisplayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("subject", targetDepth))
              {
                caseDetails.Subject = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("status", targetDepth))
              {
                caseDetails.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("serviceCode", targetDepth))
              {
                caseDetails.ServiceCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("categoryCode", targetDepth))
              {
                caseDetails.CategoryCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("severityCode", targetDepth))
              {
                caseDetails.SeverityCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("submittedBy", targetDepth))
              {
                caseDetails.SubmittedBy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timeCreated", targetDepth))
              {
                caseDetails.TimeCreated = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("recentCommunications", targetDepth))
              {
                caseDetails.RecentCommunications = RecentCaseCommunicationsUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ccEmailAddresses", targetDepth))
              {
                
                var unmarshaller = new ListUnmarshaller<String,StringUnmarshaller>(
                    StringUnmarshaller.GetInstance());                  
                caseDetails.CcEmailAddresses = unmarshaller.Unmarshall(context);
                
                continue;
              }
  
              if (context.TestExpression("language", targetDepth))
              {
                caseDetails.Language = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return caseDetails;
        }

        private static CaseDetailsUnmarshaller instance;
        public static CaseDetailsUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new CaseDetailsUnmarshaller();
            return instance;
        }
    }
}
  
