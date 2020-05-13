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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobScopeTerm Object
    /// </summary>  
    public class JobScopeTermUnmarshaller : IUnmarshaller<JobScopeTerm, XmlUnmarshallerContext>, IUnmarshaller<JobScopeTerm, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobScopeTerm IUnmarshaller<JobScopeTerm, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public JobScopeTerm Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            JobScopeTerm unmarshalledObject = new JobScopeTerm();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("simpleScopeTerm", targetDepth))
                {
                    var unmarshaller = SimpleScopeTermUnmarshaller.Instance;
                    unmarshalledObject.SimpleScopeTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tagScopeTerm", targetDepth))
                {
                    var unmarshaller = TagScopeTermUnmarshaller.Instance;
                    unmarshalledObject.TagScopeTerm = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobScopeTermUnmarshaller _instance = new JobScopeTermUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobScopeTermUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}