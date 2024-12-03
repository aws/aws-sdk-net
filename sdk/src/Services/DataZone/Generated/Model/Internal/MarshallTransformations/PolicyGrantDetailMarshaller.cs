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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteObjectStart();

                var marshaller = AddToProjectMemberPoolPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.AddToProjectMemberPool, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateAssetType())
            {
                context.Writer.WritePropertyName("createAssetType");
                context.Writer.WriteObjectStart();

                var marshaller = CreateAssetTypePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateAssetType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateDomainUnit())
            {
                context.Writer.WritePropertyName("createDomainUnit");
                context.Writer.WriteObjectStart();

                var marshaller = CreateDomainUnitPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateDomainUnit, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateEnvironment())
            {
                context.Writer.WritePropertyName("createEnvironment");
                context.Writer.WriteObjectStart();

                var marshaller = UnitMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateEnvironment, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateEnvironmentFromBlueprint())
            {
                context.Writer.WritePropertyName("createEnvironmentFromBlueprint");
                context.Writer.WriteObjectStart();

                var marshaller = UnitMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateEnvironmentFromBlueprint, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateEnvironmentProfile())
            {
                context.Writer.WritePropertyName("createEnvironmentProfile");
                context.Writer.WriteObjectStart();

                var marshaller = CreateEnvironmentProfilePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateEnvironmentProfile, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateFormType())
            {
                context.Writer.WritePropertyName("createFormType");
                context.Writer.WriteObjectStart();

                var marshaller = CreateFormTypePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateFormType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateGlossary())
            {
                context.Writer.WritePropertyName("createGlossary");
                context.Writer.WriteObjectStart();

                var marshaller = CreateGlossaryPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateGlossary, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateProject())
            {
                context.Writer.WritePropertyName("createProject");
                context.Writer.WriteObjectStart();

                var marshaller = CreateProjectPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateProject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateProjectFromProjectProfile())
            {
                context.Writer.WritePropertyName("createProjectFromProjectProfile");
                context.Writer.WriteObjectStart();

                var marshaller = CreateProjectFromProjectProfilePolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateProjectFromProjectProfile, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDelegateCreateEnvironmentProfile())
            {
                context.Writer.WritePropertyName("delegateCreateEnvironmentProfile");
                context.Writer.WriteObjectStart();

                var marshaller = UnitMarshaller.Instance;
                marshaller.Marshall(requestObject.DelegateCreateEnvironmentProfile, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOverrideDomainUnitOwners())
            {
                context.Writer.WritePropertyName("overrideDomainUnitOwners");
                context.Writer.WriteObjectStart();

                var marshaller = OverrideDomainUnitOwnersPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideDomainUnitOwners, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOverrideProjectOwners())
            {
                context.Writer.WritePropertyName("overrideProjectOwners");
                context.Writer.WriteObjectStart();

                var marshaller = OverrideProjectOwnersPolicyGrantDetailMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideProjectOwners, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyGrantDetailMarshaller Instance = new PolicyGrantDetailMarshaller();

    }
}