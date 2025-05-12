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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PolicyGrantDetail Object
    /// </summary>  
    public class PolicyGrantDetailUnmarshaller : IJsonUnmarshaller<PolicyGrantDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PolicyGrantDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PolicyGrantDetail unmarshalledObject = new PolicyGrantDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("addToProjectMemberPool", targetDepth))
                {
                    var unmarshaller = AddToProjectMemberPoolPolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.AddToProjectMemberPool = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createAssetType", targetDepth))
                {
                    var unmarshaller = CreateAssetTypePolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.CreateAssetType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createDomainUnit", targetDepth))
                {
                    var unmarshaller = CreateDomainUnitPolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.CreateDomainUnit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createEnvironment", targetDepth))
                {
                    var unmarshaller = UnitUnmarshaller.Instance;
                    unmarshalledObject.CreateEnvironment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createEnvironmentFromBlueprint", targetDepth))
                {
                    var unmarshaller = UnitUnmarshaller.Instance;
                    unmarshalledObject.CreateEnvironmentFromBlueprint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createEnvironmentProfile", targetDepth))
                {
                    var unmarshaller = CreateEnvironmentProfilePolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.CreateEnvironmentProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createFormType", targetDepth))
                {
                    var unmarshaller = CreateFormTypePolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.CreateFormType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createGlossary", targetDepth))
                {
                    var unmarshaller = CreateGlossaryPolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.CreateGlossary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createProject", targetDepth))
                {
                    var unmarshaller = CreateProjectPolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.CreateProject = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createProjectFromProjectProfile", targetDepth))
                {
                    var unmarshaller = CreateProjectFromProjectProfilePolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.CreateProjectFromProjectProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("delegateCreateEnvironmentProfile", targetDepth))
                {
                    var unmarshaller = UnitUnmarshaller.Instance;
                    unmarshalledObject.DelegateCreateEnvironmentProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("overrideDomainUnitOwners", targetDepth))
                {
                    var unmarshaller = OverrideDomainUnitOwnersPolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.OverrideDomainUnitOwners = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("overrideProjectOwners", targetDepth))
                {
                    var unmarshaller = OverrideProjectOwnersPolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.OverrideProjectOwners = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("useAssetType", targetDepth))
                {
                    var unmarshaller = UseAssetTypePolicyGrantDetailUnmarshaller.Instance;
                    unmarshalledObject.UseAssetType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PolicyGrantDetailUnmarshaller _instance = new PolicyGrantDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PolicyGrantDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}