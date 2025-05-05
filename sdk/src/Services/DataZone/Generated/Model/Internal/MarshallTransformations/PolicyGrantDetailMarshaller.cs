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
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PolicyGrantDetail Marshaller
    /// </summary>
    public class PolicyGrantDetailMarshaller : IRequestMarshaller<PolicyGrantDetail, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PolicyGrantDetail requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddToProjectMemberPool())
            {
                context.Writer.WritePropertyName("addToProjectMemberPool");
                context.Writer.WriteStartObject();

                var marshaller = AddToProjectMemberPoolPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.AddToProjectMemberPool, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateAssetType())
            {
                context.Writer.WritePropertyName("createAssetType");
                context.Writer.WriteStartObject();

                var marshaller = CreateAssetTypePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateAssetType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateDomainUnit())
            {
                context.Writer.WritePropertyName("createDomainUnit");
                context.Writer.WriteStartObject();

                var marshaller = CreateDomainUnitPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateDomainUnit, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateEnvironment())
            {
                context.Writer.WritePropertyName("createEnvironment");
                context.Writer.WriteStartObject();

                var marshaller = UnitMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateEnvironment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateEnvironmentFromBlueprint())
            {
                context.Writer.WritePropertyName("createEnvironmentFromBlueprint");
                context.Writer.WriteStartObject();

                var marshaller = UnitMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateEnvironmentFromBlueprint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateEnvironmentProfile())
            {
                context.Writer.WritePropertyName("createEnvironmentProfile");
                context.Writer.WriteStartObject();

                var marshaller = CreateEnvironmentProfilePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateEnvironmentProfile, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateFormType())
            {
                context.Writer.WritePropertyName("createFormType");
                context.Writer.WriteStartObject();

                var marshaller = CreateFormTypePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateFormType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateGlossary())
            {
                context.Writer.WritePropertyName("createGlossary");
                context.Writer.WriteStartObject();

                var marshaller = CreateGlossaryPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateGlossary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateProject())
            {
                context.Writer.WritePropertyName("createProject");
                context.Writer.WriteStartObject();

                var marshaller = CreateProjectPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateProject, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreateProjectFromProjectProfile())
            {
                context.Writer.WritePropertyName("createProjectFromProjectProfile");
                context.Writer.WriteStartObject();

                var marshaller = CreateProjectFromProjectProfilePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateProjectFromProjectProfile, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDelegateCreateEnvironmentProfile())
            {
                context.Writer.WritePropertyName("delegateCreateEnvironmentProfile");
                context.Writer.WriteStartObject();

                var marshaller = UnitMarshaller.Instance;
                marshaller.Marshall(requestObject.DelegateCreateEnvironmentProfile, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOverrideDomainUnitOwners())
            {
                context.Writer.WritePropertyName("overrideDomainUnitOwners");
                context.Writer.WriteStartObject();

                var marshaller = OverrideDomainUnitOwnersPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideDomainUnitOwners, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOverrideProjectOwners())
            {
                context.Writer.WritePropertyName("overrideProjectOwners");
                context.Writer.WriteStartObject();

                var marshaller = OverrideProjectOwnersPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideProjectOwners, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUseAssetType())
            {
                context.Writer.WritePropertyName("useAssetType");
                context.Writer.WriteStartObject();

                var marshaller = UseAssetTypePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.UseAssetType, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyGrantDetailMarshaller Instance = new PolicyGrantDetailMarshaller();

    }
}