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

/*
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RevisionLocation Object
    /// </summary>  
    public class RevisionLocationUnmarshaller : IUnmarshaller<RevisionLocation, XmlUnmarshallerContext>, IUnmarshaller<RevisionLocation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RevisionLocation IUnmarshaller<RevisionLocation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RevisionLocation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RevisionLocation unmarshalledObject = new RevisionLocation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("appSpecContent", targetDepth))
                {
                    var unmarshaller = AppSpecContentUnmarshaller.Instance;
                    unmarshalledObject.AppSpecContent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gitHubLocation", targetDepth))
                {
                    var unmarshaller = GitHubLocationUnmarshaller.Instance;
                    unmarshalledObject.GitHubLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revisionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RevisionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Location", targetDepth))
                {
                    var unmarshaller = S3LocationUnmarshaller.Instance;
                    unmarshalledObject.S3Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("string", targetDepth))
                {
                    var unmarshaller = RawStringUnmarshaller.Instance;
                    unmarshalledObject.String = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RevisionLocationUnmarshaller _instance = new RevisionLocationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RevisionLocationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}