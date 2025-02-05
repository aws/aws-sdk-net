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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobResource Object
    /// </summary>  
    public class JobResourceUnmarshaller : IJsonUnmarshaller<JobResource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public JobResource Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            JobResource unmarshalledObject = new JobResource();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Ec2AmiResources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Ec2AmiResource, Ec2AmiResourceUnmarshaller>(Ec2AmiResourceUnmarshaller.Instance);
                    unmarshalledObject.Ec2AmiResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LambdaResources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LambdaResource, LambdaResourceUnmarshaller>(LambdaResourceUnmarshaller.Instance);
                    unmarshalledObject.LambdaResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Resources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<S3Resource, S3ResourceUnmarshaller>(S3ResourceUnmarshaller.Instance);
                    unmarshalledObject.S3Resources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JobResourceUnmarshaller _instance = new JobResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}