/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ImportExport.Model.Transform
{
     /// <summary>
     ///   UpdateJobResult Unmarshaller
     /// </summary>
    internal class UpdateJobResultUnmarshaller : IUnmarshaller<UpdateJobResult, UnmarshallerContext> 
    {
        public UpdateJobResult Unmarshall(UnmarshallerContext context) 
        {
            UpdateJobResult updateJobResult = new UpdateJobResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Success", targetDepth))
                    {
                        updateJobResult.Success = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("WarningMessage", targetDepth))
                    {
                        updateJobResult.WarningMessage = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return updateJobResult;
                }
            }

            return updateJobResult;
        }

        private static UpdateJobResultUnmarshaller instance;

        public static UpdateJobResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new UpdateJobResultUnmarshaller();

            return instance;
        }
    }
}
    
