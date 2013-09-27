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
     ///   IdentityDkimAttributes Unmarshaller
     /// </summary>
    internal class IdentityDkimAttributesUnmarshaller : IUnmarshaller<IdentityDkimAttributes, XmlUnmarshallerContext>, IUnmarshaller<IdentityDkimAttributes, JsonUnmarshallerContext> 
    {
        public IdentityDkimAttributes Unmarshall(XmlUnmarshallerContext context) 
        {
            IdentityDkimAttributes identityDkimAttributes = new IdentityDkimAttributes();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("DkimEnabled", targetDepth))
                    {
                        identityDkimAttributes.DkimEnabled = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DkimVerificationStatus", targetDepth))
                    {
                        identityDkimAttributes.DkimVerificationStatus = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("DkimTokens/member", targetDepth))
                    {
                        identityDkimAttributes.DkimTokens.Add(StringUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return identityDkimAttributes;
                }
            }
                        


            return identityDkimAttributes;
        }

        public IdentityDkimAttributes Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static IdentityDkimAttributesUnmarshaller instance;

        public static IdentityDkimAttributesUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new IdentityDkimAttributesUnmarshaller();

            return instance;
        }
    }
}
    
