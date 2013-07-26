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

using Amazon.SimpleDB.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DomainMetadataResult Unmarshaller
     /// </summary>
    internal class DomainMetadataResultUnmarshaller : IUnmarshaller<DomainMetadataResult, XmlUnmarshallerContext>, IUnmarshaller<DomainMetadataResult, JsonUnmarshallerContext> 
    {
        public DomainMetadataResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DomainMetadataResult domainMetadataResult = new DomainMetadataResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("ItemCount", targetDepth))
                    {
                        domainMetadataResult.ItemCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ItemNamesSizeBytes", targetDepth))
                    {
                        domainMetadataResult.ItemNamesSizeBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AttributeNameCount", targetDepth))
                    {
                        domainMetadataResult.AttributeNameCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AttributeNamesSizeBytes", targetDepth))
                    {
                        domainMetadataResult.AttributeNamesSizeBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AttributeValueCount", targetDepth))
                    {
                        domainMetadataResult.AttributeValueCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AttributeValuesSizeBytes", targetDepth))
                    {
                        domainMetadataResult.AttributeValuesSizeBytes = LongUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        domainMetadataResult.Timestamp = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return domainMetadataResult;
                }
            }
                        


            return domainMetadataResult;
        }

        public DomainMetadataResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DomainMetadataResultUnmarshaller instance;

        public static DomainMetadataResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DomainMetadataResultUnmarshaller();

            return instance;
        }
    }
}
    
