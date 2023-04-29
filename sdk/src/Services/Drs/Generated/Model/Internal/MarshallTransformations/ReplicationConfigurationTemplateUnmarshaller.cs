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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Drs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Drs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReplicationConfigurationTemplate Object
    /// </summary>  
    public class ReplicationConfigurationTemplateUnmarshaller : IUnmarshaller<ReplicationConfigurationTemplate, XmlUnmarshallerContext>, IUnmarshaller<ReplicationConfigurationTemplate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReplicationConfigurationTemplate IUnmarshaller<ReplicationConfigurationTemplate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReplicationConfigurationTemplate Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReplicationConfigurationTemplate unmarshalledObject = new ReplicationConfigurationTemplate();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("associateDefaultSecurityGroup", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AssociateDefaultSecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoReplicateNewDisks", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AutoReplicateNewDisks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bandwidthThrottling", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.BandwidthThrottling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createPublicIP", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CreatePublicIP = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataPlaneRouting", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataPlaneRouting = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultLargeStagingDiskType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultLargeStagingDiskType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebsEncryption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsEncryption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebsEncryptionKeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsEncryptionKeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pitPolicy", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PITPolicyRule, PITPolicyRuleUnmarshaller>(PITPolicyRuleUnmarshaller.Instance);
                    unmarshalledObject.PitPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationConfigurationTemplateID", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationConfigurationTemplateID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationServerInstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReplicationServerInstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationServersSecurityGroupsIDs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ReplicationServersSecurityGroupsIDs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stagingAreaSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StagingAreaSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stagingAreaTags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.StagingAreaTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("useDedicatedReplicationServer", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseDedicatedReplicationServer = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReplicationConfigurationTemplateUnmarshaller _instance = new ReplicationConfigurationTemplateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReplicationConfigurationTemplateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}