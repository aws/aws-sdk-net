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

using Amazon.SQS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   BatchResultErrorEntry Unmarshaller
     /// </summary>
    internal class BatchResultErrorEntryUnmarshaller : IUnmarshaller<BatchResultErrorEntry, XmlUnmarshallerContext>, IUnmarshaller<BatchResultErrorEntry, JsonUnmarshallerContext> 
    {
        public BatchResultErrorEntry Unmarshall(XmlUnmarshallerContext context) 
        {
            BatchResultErrorEntry batchResultErrorEntry = new BatchResultErrorEntry();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Id", targetDepth))
                    {
                        batchResultErrorEntry.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("SenderFault", targetDepth))
                    {
                        batchResultErrorEntry.SenderFault = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Code", targetDepth))
                    {
                        batchResultErrorEntry.Code = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Message", targetDepth))
                    {
                        batchResultErrorEntry.Message = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return batchResultErrorEntry;
                }
            }
                        


            return batchResultErrorEntry;
        }

        public BatchResultErrorEntry Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static BatchResultErrorEntryUnmarshaller instance;

        public static BatchResultErrorEntryUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new BatchResultErrorEntryUnmarshaller();

            return instance;
        }
    }
}
    
