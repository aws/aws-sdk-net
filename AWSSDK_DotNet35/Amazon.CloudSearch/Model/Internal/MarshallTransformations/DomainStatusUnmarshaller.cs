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

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DomainStatus Unmarshaller
     /// </summary>
    internal class DomainStatusUnmarshaller : IUnmarshaller<DomainStatus, XmlUnmarshallerContext>, IUnmarshaller<DomainStatus, JsonUnmarshallerContext> 
    {
        public DomainStatus Unmarshall(XmlUnmarshallerContext context) 
        {
            DomainStatus domainStatus = new DomainStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DomainId", targetDepth))
                    {
                        domainStatus.DomainId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        domainStatus.DomainName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Created", targetDepth))
                    {
                        domainStatus.Created = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Deleted", targetDepth))
                    {
                        domainStatus.Deleted = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NumSearchableDocs", targetDepth))
                    {
                        domainStatus.NumSearchableDocs = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("DocService", targetDepth))
                    {
                        domainStatus.DocService = ServiceEndpointUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SearchService", targetDepth))
                    {
                        domainStatus.SearchService = ServiceEndpointUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("RequiresIndexDocuments", targetDepth))
                    {
                        domainStatus.RequiresIndexDocuments = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Processing", targetDepth))
                    {
                        domainStatus.Processing = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SearchInstanceType", targetDepth))
                    {
                        domainStatus.SearchInstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SearchPartitionCount", targetDepth))
                    {
                        domainStatus.SearchPartitionCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SearchInstanceCount", targetDepth))
                    {
                        domainStatus.SearchInstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return domainStatus;
                }
            }
                        


            return domainStatus;
        }

        public DomainStatus Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DomainStatusUnmarshaller instance;

        public static DomainStatusUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DomainStatusUnmarshaller();

            return instance;
        }
    }
}
    
