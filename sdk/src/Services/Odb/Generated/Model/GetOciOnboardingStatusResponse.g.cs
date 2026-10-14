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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the GetOciOnboardingStatus operation.
    /// </summary>
    public partial class GetOciOnboardingStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutonomousDatabaseOciIntegrationIamRoles. 
        /// <para>
        /// The list of Amazon Web Services Identity and Access Management (IAM) service roles
        /// used for Autonomous Database integration with Oracle Cloud Infrastructure (OCI).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<OciIamRole> AutonomousDatabaseOciIntegrationIamRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<OciIamRole>() : null;

        /// <summary>
        /// Checks to see if the AutonomousDatabaseOciIntegrationIamRoles property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseOciIntegrationIamRoles() => this.AutonomousDatabaseOciIntegrationIamRoles != null && (this.AutonomousDatabaseOciIntegrationIamRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExistingTenancyActivationLink. 
        /// <para>
        /// The existing OCI tenancy activation link for your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string ExistingTenancyActivationLink { get; set; }

        /// <summary>
        /// Checks to see if the ExistingTenancyActivationLink property is set.
        /// </summary>
        internal bool IsSetExistingTenancyActivationLink() => this.ExistingTenancyActivationLink != null;

        /// <summary>
        /// Gets and sets the property LinkedOciCompartmentId. 
        /// <para>
        /// The unique identifier of the Oracle Cloud Infrastructure (OCI) compartment that is
        /// linked to your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string LinkedOciCompartmentId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedOciCompartmentId property is set.
        /// </summary>
        internal bool IsSetLinkedOciCompartmentId() => this.LinkedOciCompartmentId != null;

        /// <summary>
        /// Gets and sets the property LinkedOciTenancyId. 
        /// <para>
        /// The unique identifier of the Oracle Cloud Infrastructure (OCI) tenancy that is linked
        /// to your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string LinkedOciTenancyId { get; set; }

        /// <summary>
        /// Checks to see if the LinkedOciTenancyId property is set.
        /// </summary>
        internal bool IsSetLinkedOciTenancyId() => this.LinkedOciTenancyId != null;

        /// <summary>
        /// Gets and sets the property NewTenancyActivationLink. 
        /// <para>
        /// A new OCI tenancy activation link for your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string NewTenancyActivationLink { get; set; }

        /// <summary>
        /// Checks to see if the NewTenancyActivationLink property is set.
        /// </summary>
        internal bool IsSetNewTenancyActivationLink() => this.NewTenancyActivationLink != null;

        /// <summary>
        /// Gets and sets the property OciIdentityDomain. 
        /// <para>
        /// The Oracle Cloud Infrastructure (OCI) identity domain information in the onboarding
        /// status response.
        /// </para>
        /// </summary>
        public OciIdentityDomain OciIdentityDomain { get; set; }

        /// <summary>
        /// Checks to see if the OciIdentityDomain property is set.
        /// </summary>
        internal bool IsSetOciIdentityDomain() => this.OciIdentityDomain != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public OciOnboardingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubscriptionErrors. 
        /// <para>
        /// The list of errors that occurred during the subscription process for your Amazon Web
        /// Services account, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubscriptionError> SubscriptionErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<SubscriptionError>() : null;

        /// <summary>
        /// Checks to see if the SubscriptionErrors property is set.
        /// </summary>
        internal bool IsSetSubscriptionErrors() => this.SubscriptionErrors != null && (this.SubscriptionErrors.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
