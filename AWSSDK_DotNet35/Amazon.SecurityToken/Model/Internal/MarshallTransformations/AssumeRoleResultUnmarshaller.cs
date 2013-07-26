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

using Amazon.SecurityToken.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   AssumeRoleResult Unmarshaller
     /// </summary>
    internal class AssumeRoleResultUnmarshaller : IUnmarshaller<AssumeRoleResult, XmlUnmarshallerContext>, IUnmarshaller<AssumeRoleResult, JsonUnmarshallerContext> 
    {
        public AssumeRoleResult Unmarshall(XmlUnmarshallerContext context) 
        {
            AssumeRoleResult assumeRoleResult = new AssumeRoleResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Credentials", targetDepth))
                    {
                        assumeRoleResult.Credentials = CredentialsUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("AssumedRoleUser", targetDepth))
                    {
                        assumeRoleResult.AssumedRoleUser = AssumedRoleUserUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("PackedPolicySize", targetDepth))
                    {
                        assumeRoleResult.PackedPolicySize = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return assumeRoleResult;
                }
            }
                        


            return assumeRoleResult;
        }

        public AssumeRoleResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static AssumeRoleResultUnmarshaller instance;

        public static AssumeRoleResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new AssumeRoleResultUnmarshaller();

            return instance;
        }
    }
}
    
