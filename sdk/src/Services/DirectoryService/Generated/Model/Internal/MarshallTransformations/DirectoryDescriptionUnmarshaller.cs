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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DirectoryDescription Object
    /// </summary>  
    public class DirectoryDescriptionUnmarshaller : IUnmarshaller<DirectoryDescription, XmlUnmarshallerContext>, IUnmarshaller<DirectoryDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DirectoryDescription IUnmarshaller<DirectoryDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DirectoryDescription Unmarshall(JsonUnmarshallerContext context)
        {
            DirectoryDescription unmarshalledObject = new DirectoryDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccessUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Alias", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Alias = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConnectSettings", targetDepth))
                {
                    var unmarshaller = DirectoryConnectSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ConnectSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DesiredNumberOfDomainControllers", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DesiredNumberOfDomainControllers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DirectoryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DirectoryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DnsIpAddrs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DnsIpAddrs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Edition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Edition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HybridSettings", targetDepth))
                {
                    var unmarshaller = HybridSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.HybridSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LaunchTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LaunchTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OsVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OsVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerDirectoryDescription", targetDepth))
                {
                    var unmarshaller = OwnerDirectoryDescriptionUnmarshaller.Instance;
                    unmarshalledObject.OwnerDirectoryDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RadiusSettings", targetDepth))
                {
                    var unmarshaller = RadiusSettingsUnmarshaller.Instance;
                    unmarshalledObject.RadiusSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RadiusStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RadiusStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegionsInfo", targetDepth))
                {
                    var unmarshaller = RegionsInfoUnmarshaller.Instance;
                    unmarshalledObject.RegionsInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareMethod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareMethod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareNotes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareNotes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShareStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShortName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShortName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Size", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Size = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SsoEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SsoEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Stage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Stage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StageLastUpdatedDateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StageLastUpdatedDateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StageReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StageReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcSettings", targetDepth))
                {
                    var unmarshaller = DirectoryVpcSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.VpcSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DirectoryDescriptionUnmarshaller _instance = new DirectoryDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DirectoryDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}