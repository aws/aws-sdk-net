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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkspaceDescription Object
    /// </summary>  
    public class WorkspaceDescriptionUnmarshaller : IJsonUnmarshaller<WorkspaceDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkspaceDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            WorkspaceDescription unmarshalledObject = new WorkspaceDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountAccessType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountAccessType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("authentication", targetDepth))
                {
                    var unmarshaller = AuthenticationSummaryUnmarshaller.Instance;
                    unmarshalledObject.Authentication = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("created", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.Created = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataSources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DataSources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endpoint", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Endpoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("freeTrialConsumed", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.FreeTrialConsumed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("freeTrialExpiration", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.FreeTrialExpiration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("grafanaToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GrafanaToken = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("grafanaVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GrafanaVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("licenseExpiration", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LicenseExpiration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("licenseType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("modified", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.Modified = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("networkAccessControl", targetDepth))
                {
                    var unmarshaller = NetworkAccessConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NetworkAccessControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notificationDestinations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotificationDestinations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("organizationalUnits", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.OrganizationalUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("organizationRoleName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OrganizationRoleName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("permissionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PermissionType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stackSetName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StackSetName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("vpcConfiguration", targetDepth))
                {
                    var unmarshaller = VpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VpcConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("workspaceRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkspaceRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkspaceDescriptionUnmarshaller _instance = new WorkspaceDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkspaceDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}