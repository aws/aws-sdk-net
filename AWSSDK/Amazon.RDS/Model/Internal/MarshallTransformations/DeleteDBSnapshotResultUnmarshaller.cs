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

using Amazon.Runtime.Internal.Transform;    
    
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Result Unmarshaller for DeleteDBSnapshot operation
    /// </summary>
    internal class DeleteDBSnapshotResultUnmarshaller : IUnmarshaller<DeleteDBSnapshotResult, XmlUnmarshallerContext> {

        public DeleteDBSnapshotResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DeleteDBSnapshotResult result = new DeleteDBSnapshotResult();
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBSnapshot", targetDepth))
                    {
                        result.DBSnapshot = DBSnapshotUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return result;
                }
            }
                       


            return result;
        }
        
        private static DeleteDBSnapshotResultUnmarshaller instance;
        
        public static DeleteDBSnapshotResultUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new DeleteDBSnapshotResultUnmarshaller();
            }
            return instance;
        }        
    }
}    
    
