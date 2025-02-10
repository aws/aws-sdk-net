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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ElasticsearchDomainStatus Object
    /// </summary>  
    public class ElasticsearchDomainStatusUnmarshaller : IJsonUnmarshaller<ElasticsearchDomainStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ElasticsearchDomainStatus Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ElasticsearchDomainStatus unmarshalledObject = new ElasticsearchDomainStatus();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AccessPolicies", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessPolicies = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AdvancedOptions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.AdvancedOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AdvancedSecurityOptions", targetDepth))
                {
                    var unmarshaller = AdvancedSecurityOptionsUnmarshaller.Instance;
                    unmarshalledObject.AdvancedSecurityOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ARN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AutoTuneOptions", targetDepth))
                {
                    var unmarshaller = AutoTuneOptionsOutputUnmarshaller.Instance;
                    unmarshalledObject.AutoTuneOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ChangeProgressDetails", targetDepth))
                {
                    var unmarshaller = ChangeProgressDetailsUnmarshaller.Instance;
                    unmarshalledObject.ChangeProgressDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CognitoOptions", targetDepth))
                {
                    var unmarshaller = CognitoOptionsUnmarshaller.Instance;
                    unmarshalledObject.CognitoOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Created", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Created = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Deleted", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Deleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DomainEndpointOptions", targetDepth))
                {
                    var unmarshaller = DomainEndpointOptionsUnmarshaller.Instance;
                    unmarshalledObject.DomainEndpointOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DomainId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DomainName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DomainProcessingStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DomainProcessingStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EBSOptions", targetDepth))
                {
                    var unmarshaller = EBSOptionsUnmarshaller.Instance;
                    unmarshalledObject.EBSOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ElasticsearchClusterConfig", targetDepth))
                {
                    var unmarshaller = ElasticsearchClusterConfigUnmarshaller.Instance;
                    unmarshalledObject.ElasticsearchClusterConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ElasticsearchVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ElasticsearchVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EncryptionAtRestOptions", targetDepth))
                {
                    var unmarshaller = EncryptionAtRestOptionsUnmarshaller.Instance;
                    unmarshalledObject.EncryptionAtRestOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Endpoints", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Endpoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LogPublishingOptions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, LogPublishingOption, StringUnmarshaller, LogPublishingOptionUnmarshaller>(StringUnmarshaller.Instance, LogPublishingOptionUnmarshaller.Instance);
                    unmarshalledObject.LogPublishingOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ModifyingProperties", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ModifyingProperties, ModifyingPropertiesUnmarshaller>(ModifyingPropertiesUnmarshaller.Instance);
                    unmarshalledObject.ModifyingProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NodeToNodeEncryptionOptions", targetDepth))
                {
                    var unmarshaller = NodeToNodeEncryptionOptionsUnmarshaller.Instance;
                    unmarshalledObject.NodeToNodeEncryptionOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Processing", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Processing = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceSoftwareOptions", targetDepth))
                {
                    var unmarshaller = ServiceSoftwareOptionsUnmarshaller.Instance;
                    unmarshalledObject.ServiceSoftwareOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SnapshotOptions", targetDepth))
                {
                    var unmarshaller = SnapshotOptionsUnmarshaller.Instance;
                    unmarshalledObject.SnapshotOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpgradeProcessing", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UpgradeProcessing = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VPCOptions", targetDepth))
                {
                    var unmarshaller = VPCDerivedInfoUnmarshaller.Instance;
                    unmarshalledObject.VPCOptions = unmarshaller.Unmarshall(context, ref reader);
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