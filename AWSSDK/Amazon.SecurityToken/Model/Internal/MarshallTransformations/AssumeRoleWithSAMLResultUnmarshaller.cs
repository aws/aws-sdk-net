/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityToken.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssumeRoleWithSAML Object
    /// </summary>  
    public class AssumeRoleWithSAMLResultUnmarshaller : IUnmarshaller<AssumeRoleWithSAMLResult, XmlUnmarshallerContext>
    {
        public AssumeRoleWithSAMLResult Unmarshall(XmlUnmarshallerContext context) 
        {
            AssumeRoleWithSAMLResult result = new AssumeRoleWithSAMLResult();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AssumedRoleUser", targetDepth))
                    {
                        var unmarshaller = AssumedRoleUserUnmarshaller.GetInstance();
                        result.AssumedRoleUser = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Audience", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Audience = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Credentials", targetDepth))
                    {
                        var unmarshaller = CredentialsUnmarshaller.GetInstance();
                        result.Credentials = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Issuer", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Issuer = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NameQualifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.NameQualifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PackedPolicySize", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        result.PackedPolicySize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Subject", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Subject = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SubjectType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.SubjectType = unmarshaller.Unmarshall(context);
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


        private static AssumeRoleWithSAMLResultUnmarshaller instance;
        public static AssumeRoleWithSAMLResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new AssumeRoleWithSAMLResultUnmarshaller();
            }
            return instance;
        }

    }
}