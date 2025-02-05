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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Commit Object
    /// </summary>  
    public class CommitUnmarshaller : IJsonUnmarshaller<Commit, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Commit Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Commit unmarshalledObject = new Commit();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("additionalData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdditionalData = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("author", targetDepth))
                {
                    var unmarshaller = UserInfoUnmarshaller.Instance;
                    unmarshalledObject.Author = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("commitId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CommitId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("committer", targetDepth))
                {
                    var unmarshaller = UserInfoUnmarshaller.Instance;
                    unmarshalledObject.Committer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Message = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parents", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Parents = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("treeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TreeId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CommitUnmarshaller _instance = new CommitUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CommitUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}