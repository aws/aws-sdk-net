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
     ///   GetStatusResult Unmarshaller
     /// </summary>
    internal class GetStatusResultUnmarshaller : IUnmarshaller<GetStatusResult, XmlUnmarshallerContext> 
    {
        public GetStatusResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetStatusResult getStatusResult = new GetStatusResult();
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
                        getStatusResult.JobId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("JobType", targetDepth))
                    {
                        getStatusResult.JobType = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AwsShippingAddress", targetDepth))
                    {
                        getStatusResult.AwsShippingAddress = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LocationCode", targetDepth))
                    {
                        getStatusResult.LocationCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LocationMessage", targetDepth))
                    {
                        getStatusResult.LocationMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ProgressCode", targetDepth))
                    {
                        getStatusResult.ProgressCode = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ProgressMessage", targetDepth))
                    {
                        getStatusResult.ProgressMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Carrier", targetDepth))
                    {
                        getStatusResult.Carrier = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("TrackingNumber", targetDepth))
                    {
                        getStatusResult.TrackingNumber = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LogBucket", targetDepth))
                    {
                        getStatusResult.LogBucket = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("LogKey", targetDepth))
                    {
                        getStatusResult.LogKey = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("ErrorCount", targetDepth))
                    {
                        getStatusResult.ErrorCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Signature", targetDepth))
                    {
                        getStatusResult.Signature = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("SignatureFileContents", targetDepth))
                    {
                        getStatusResult.SignatureFileContents = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CurrentManifest", targetDepth))
                    {
                        getStatusResult.CurrentManifest = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("CreationDate", targetDepth))
                    {
                        getStatusResult.CreationDate = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getStatusResult;
                }
            }
                        


            return getStatusResult;
        }

        private static GetStatusResultUnmarshaller instance;

        public static GetStatusResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetStatusResultUnmarshaller();

            return instance;
        }
    }
}
    
