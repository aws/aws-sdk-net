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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Job Object
    /// </summary>  
    public class JobUnmarshaller : IUnmarshaller<Job, XmlUnmarshallerContext>, IUnmarshaller<Job, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Job IUnmarshaller<Job, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Job Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Job unmarshalledObject = new Job();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatasetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatasetName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogSubscription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogSubscription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxRetries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxRetries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Outputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Output, OutputUnmarshaller>(OutputUnmarshaller.Instance);
                    unmarshalledObject.Outputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecipeReference", targetDepth))
                {
                    var unmarshaller = RecipeReferenceUnmarshaller.Instance;
                    unmarshalledObject.RecipeReference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Timeout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Timeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobUnmarshaller _instance = new JobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}