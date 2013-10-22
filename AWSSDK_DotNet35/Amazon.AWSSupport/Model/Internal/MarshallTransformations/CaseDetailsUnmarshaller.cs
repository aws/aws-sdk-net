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
            if (context.CurrentTokenType == JsonToken.Null)
                return null;

            CaseDetails caseDetails = new CaseDetails();

        
        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
              
              if (context.TestExpression("caseId", targetDepth))
              {
                context.Read();
                caseDetails.CaseId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("displayId", targetDepth))
              {
                context.Read();
                caseDetails.DisplayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("subject", targetDepth))
              {
                context.Read();
                caseDetails.Subject = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("status", targetDepth))
              {
                context.Read();
                caseDetails.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("serviceCode", targetDepth))
              {
                context.Read();
                caseDetails.ServiceCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("categoryCode", targetDepth))
              {
                context.Read();
                caseDetails.CategoryCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("severityCode", targetDepth))
              {
                context.Read();
                caseDetails.SeverityCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("submittedBy", targetDepth))
              {
                context.Read();
                caseDetails.SubmittedBy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("timeCreated", targetDepth))
              {
                context.Read();
                caseDetails.TimeCreated = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("recentCommunications", targetDepth))
              {
                context.Read();
                caseDetails.RecentCommunications = RecentCaseCommunicationsUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ccEmailAddresses", targetDepth))
              {
                context.Read();
                caseDetails.CcEmailAddresses = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  JsonToken token = context.CurrentTokenType;                
                  if (token == JsonToken.ArrayStart)
                  {
                    continue;
                  }
                  if (token == JsonToken.ArrayEnd)
                  {
                    break;
                  }
                   caseDetails.CcEmailAddresses.Add(unmarshaller.Unmarshall(context));
                }
                continue;
              }
  
              if (context.TestExpression("language", targetDepth))
              {
                context.Read();
                caseDetails.Language = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                if (context.CurrentDepth <= originalDepth)
                {
                    return caseDetails;
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
  
