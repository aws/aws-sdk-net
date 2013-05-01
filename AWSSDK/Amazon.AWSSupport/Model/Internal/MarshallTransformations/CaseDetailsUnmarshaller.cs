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
            CaseDetails caseDetails = new CaseDetails();
          caseDetails.CcEmailAddresses = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("CaseId", targetDepth))
              {
                caseDetails.CaseId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("DisplayId", targetDepth))
              {
                caseDetails.DisplayId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Subject", targetDepth))
              {
                caseDetails.Subject = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Status", targetDepth))
              {
                caseDetails.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("ServiceCode", targetDepth))
              {
                caseDetails.ServiceCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CategoryCode", targetDepth))
              {
                caseDetails.CategoryCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SeverityCode", targetDepth))
              {
                caseDetails.SeverityCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("SubmittedBy", targetDepth))
              {
                caseDetails.SubmittedBy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("TimeCreated", targetDepth))
              {
                caseDetails.TimeCreated = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("RecentCommunications", targetDepth))
              {
                caseDetails.RecentCommunications = RecentCaseCommunicationsUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("CcEmailAddresses", targetDepth))
              {
                caseDetails.CcEmailAddresses = new List<String>();
                        StringUnmarshaller unmarshaller = StringUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     caseDetails.CcEmailAddresses.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("Language", targetDepth))
              {
                caseDetails.Language = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
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
  
