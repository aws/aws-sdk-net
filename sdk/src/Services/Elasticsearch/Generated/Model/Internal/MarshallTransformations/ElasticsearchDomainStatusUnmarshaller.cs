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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ElasticsearchDomainStatus Object
    /// </summary>  
    public class ElasticsearchDomainStatusUnmarshaller : IUnmarshaller<ElasticsearchDomainStatus, XmlUnmarshallerContext>, IUnmarshaller<ElasticsearchDomainStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ElasticsearchDomainStatus IUnmarshaller<ElasticsearchDomainStatus, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ElasticsearchDomainStatus Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ElasticsearchDomainStatus unmarshalledObject = new ElasticsearchDomainStatus();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessPolicies", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessPolicies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdvancedOptions", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.AdvancedOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CognitoOptions", targetDepth))
                {
                    var unmarshaller = CognitoOptionsUnmarshaller.Instance;
                    unmarshalledObject.CognitoOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Created", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Created = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Deleted", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Deleted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EBSOptions", targetDepth))
                {
                    var unmarshaller = EBSOptionsUnmarshaller.Instance;
                    unmarshalledObject.EBSOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElasticsearchClusterConfig", targetDepth))
                {
                    var unmarshaller = ElasticsearchClusterConfigUnmarshaller.Instance;
                    unmarshalledObject.ElasticsearchClusterConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElasticsearchVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElasticsearchVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionAtRestOptions", targetDepth))
                {
                    var unmarshaller = EncryptionAtRestOptionsUnmarshaller.Instance;
                    unmarshalledObject.EncryptionAtRestOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoints", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Endpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogPublishingOptions", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, LogPublishingOption, StringUnmarshaller, LogPublishingOptionUnmarshaller>(StringUnmarshaller.Instance, LogPublishingOptionUnmarshaller.Instance);
                    unmarshalledObject.LogPublishingOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Processing", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Processing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotOptions", targetDepth))
                {
                    var unmarshaller = SnapshotOptionsUnmarshaller.Instance;
                    unmarshalledObject.SnapshotOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VPCOptions", targetDepth))
                {
                    var unmarshaller = VPCDerivedInfoUnmarshaller.Instance;
                    unmarshalledObject.VPCOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ElasticsearchDomainStatusUnmarshaller _instance = new ElasticsearchDomainStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ElasticsearchDomainStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}