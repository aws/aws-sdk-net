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

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Grant Unmarshaller
     /// </summary>
    internal class GrantUnmarshaller : IUnmarshaller<S3Grant, XmlUnmarshallerContext>, IUnmarshaller<S3Grant, JsonUnmarshallerContext> 
    {
        public S3Grant Unmarshall(XmlUnmarshallerContext context) 
        {
            S3Grant grant = new S3Grant();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Grantee", targetDepth))
                    {
                        grant.Grantee = GranteeUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Permission", targetDepth))
                    {
                        grant.Permission = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return grant;
                }
            }
                        


            return grant;
        }

        public S3Grant Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static GrantUnmarshaller _instance;

        public static GrantUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GrantUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
