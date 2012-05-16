/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudFront.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Signer Unmarshaller
     /// </summary>
    internal class SignerUnmarshaller : IUnmarshaller<Signer, XmlUnmarshallerContext>, IUnmarshaller<Signer, JsonUnmarshallerContext> 
    {
        public Signer Unmarshall(XmlUnmarshallerContext context) 
        {
            Signer signer = new Signer();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("AwsAccountNumber", targetDepth))
                    {
                        signer.AwsAccountNumber = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("KeyPairIds", targetDepth))
                    {
                        signer.KeyPairIds = KeyPairIdsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return signer;
                }
            }
                        


            return signer;
        }

        public Signer Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static SignerUnmarshaller instance;

        public static SignerUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new SignerUnmarshaller();

            return instance;
        }
    }
}
    
