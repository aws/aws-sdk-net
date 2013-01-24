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

using Amazon.SimpleEmail.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   GetIdentityVerificationAttributesResult Unmarshaller
     /// </summary>
    internal class GetIdentityVerificationAttributesResultUnmarshaller : IUnmarshaller<GetIdentityVerificationAttributesResult, XmlUnmarshallerContext>, IUnmarshaller<GetIdentityVerificationAttributesResult, JsonUnmarshallerContext> 
    {
        public GetIdentityVerificationAttributesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            GetIdentityVerificationAttributesResult getIdentityVerificationAttributesResult = new GetIdentityVerificationAttributesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("VerificationAttributes/entry", targetDepth))
                    {
                        KeyValueUnmarshaller<string, IdentityVerificationAttributes, StringUnmarshaller, IdentityVerificationAttributesUnmarshaller> unmarshaller = new KeyValueUnmarshaller<string, IdentityVerificationAttributes, StringUnmarshaller, IdentityVerificationAttributesUnmarshaller>(StringUnmarshaller.GetInstance(), IdentityVerificationAttributesUnmarshaller.GetInstance());
                        KeyValuePair<string, IdentityVerificationAttributes> kvp = unmarshaller.Unmarshall(context);
                        getIdentityVerificationAttributesResult.VerificationAttributes.Add(kvp.Key, kvp.Value);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return getIdentityVerificationAttributesResult;
                }
            }
                        


            return getIdentityVerificationAttributesResult;
        }

        public GetIdentityVerificationAttributesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GetIdentityVerificationAttributesResultUnmarshaller instance;

        public static GetIdentityVerificationAttributesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new GetIdentityVerificationAttributesResultUnmarshaller();

            return instance;
        }
    }
}
    
