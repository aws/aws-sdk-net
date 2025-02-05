/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.RedshiftServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Namespace Object
    /// </summary>  
    public class NamespaceUnmarshaller : IJsonUnmarshaller<Namespace, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Namespace Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Namespace unmarshalledObject = new Namespace();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("adminPasswordSecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdminPasswordSecretArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("adminPasswordSecretKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdminPasswordSecretKmsKeyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("adminUsername", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdminUsername = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("creationDate", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dbName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DbName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("defaultIamRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultIamRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iamRoles", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IamRoles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logExports", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LogExports = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("namespaceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NamespaceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("namespaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NamespaceId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("namespaceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NamespaceName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NamespaceUnmarshaller _instance = new NamespaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NamespaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}