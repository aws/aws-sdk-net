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

using Amazon.ImportExport.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ImportExport.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   CreateJobResult Unmarshaller
     /// </summary>
    internal class CreateJobResultUnmarshaller : IUnmarshaller<CreateJobResult, XmlUnmarshallerContext> 
    {
        public CreateJobResult Unmarshall(XmlUnmarshallerContext context) 
        {
            CreateJobResult createJobResult = new CreateJobResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("JobId", targetDepth))
                    {
                        createJobResult.JobId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("JobType", targetDepth))
                    {
                        createJobResult.JobType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AwsShippingAddress", targetDepth))
                    {
                        createJobResult.AwsShippingAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Signature", targetDepth))
                    {
                        createJobResult.Signature = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SignatureFileContents", targetDepth))
                    {
                        createJobResult.SignatureFileContents = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("WarningMessage", targetDepth))
                    {
                        createJobResult.WarningMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return createJobResult;
                }
            }
                        


            return createJobResult;
        }

        private static CreateJobResultUnmarshaller instance;

        public static CreateJobResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new CreateJobResultUnmarshaller();

            return instance;
        }
    }
}
    
