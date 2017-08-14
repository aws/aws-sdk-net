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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudHSMV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudHSMV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Cluster Object
    /// </summary>  
    public class ClusterUnmarshaller : IUnmarshaller<Cluster, XmlUnmarshallerContext>, IUnmarshaller<Cluster, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Cluster IUnmarshaller<Cluster, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Cluster Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Cluster unmarshalledObject = new Cluster();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BackupPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BackupPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Certificates", targetDepth))
                {
                    var unmarshaller = CertificatesUnmarshaller.Instance;
                    unmarshalledObject.Certificates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Hsms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Hsm, HsmUnmarshaller>(HsmUnmarshaller.Instance);
                    unmarshalledObject.Hsms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HsmType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HsmType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreCoPassword", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreCoPassword = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceBackupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceBackupId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetMapping", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.SubnetMapping = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ClusterUnmarshaller _instance = new ClusterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}