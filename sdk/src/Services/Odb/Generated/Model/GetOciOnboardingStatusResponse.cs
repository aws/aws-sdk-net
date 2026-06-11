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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private List<OciIamRole> _autonomousDatabaseOciIntegrationIamRoles = AWSConfigs.InitializeCollections ? new List<OciIamRole>() : null;
        private string _existingTenancyActivationLink;
        private string _linkedOciCompartmentId;
        private string _linkedOciTenancyId;
        private string _newTenancyActivationLink;
        private OciIdentityDomain _ociIdentityDomain;
        private OciOnboardingStatus _status;
        private List<SubscriptionError> _subscriptionErrors = AWSConfigs.InitializeCollections ? new List<SubscriptionError>() : null;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseOciIntegrationIamRoles. 
        /// <para>
        /// The list of Amazon Web Services Identity and Access Management (IAM) service roles
        /// used for Autonomous Database integration with Oracle Cloud Infrastructure (OCI).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<OciIamRole> AutonomousDatabaseOciIntegrationIamRoles
        {
            get { return this._autonomousDatabaseOciIntegrationIamRoles; }
            set { this._autonomousDatabaseOciIntegrationIamRoles = value; }
        }

        // Check to see if AutonomousDatabaseOciIntegrationIamRoles property is set
        internal bool IsSetAutonomousDatabaseOciIntegrationIamRoles()
        {
            return this._autonomousDatabaseOciIntegrationIamRoles != null && (this._autonomousDatabaseOciIntegrationIamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExistingTenancyActivationLink. 
        /// <para>
        /// The existing OCI tenancy activation link for your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string ExistingTenancyActivationLink
        {
            get { return this._existingTenancyActivationLink; }
            set { this._existingTenancyActivationLink = value; }
        }

        // Check to see if ExistingTenancyActivationLink property is set
        internal bool IsSetExistingTenancyActivationLink()
        {
            return this._existingTenancyActivationLink != null;
        }

        /// <summary>
        /// Gets and sets the property LinkedOciCompartmentId. 
        /// <para>
        /// The unique identifier of the Oracle Cloud Infrastructure (OCI) compartment that is
        /// linked to your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string LinkedOciCompartmentId
        {
            get { return this._linkedOciCompartmentId; }
            set { this._linkedOciCompartmentId = value; }
        }

        // Check to see if LinkedOciCompartmentId property is set
        internal bool IsSetLinkedOciCompartmentId()
        {
            return this._linkedOciCompartmentId != null;
        }

        /// <summary>
        /// Gets and sets the property LinkedOciTenancyId. 
        /// <para>
        /// The unique identifier of the Oracle Cloud Infrastructure (OCI) tenancy that is linked
        /// to your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string LinkedOciTenancyId
        {
            get { return this._linkedOciTenancyId; }
            set { this._linkedOciTenancyId = value; }
        }

        // Check to see if LinkedOciTenancyId property is set
        internal bool IsSetLinkedOciTenancyId()
        {
            return this._linkedOciTenancyId != null;
        }

        /// <summary>
        /// Gets and sets the property NewTenancyActivationLink. 
        /// <para>
        /// A new OCI tenancy activation link for your Amazon Web Services account.
        /// </para>
        /// </summary>
        public string NewTenancyActivationLink
        {
            get { return this._newTenancyActivationLink; }
            set { this._newTenancyActivationLink = value; }
        }

        // Check to see if NewTenancyActivationLink property is set
        internal bool IsSetNewTenancyActivationLink()
        {
            return this._newTenancyActivationLink != null;
        }

        /// <summary>
        /// Gets and sets the property OciIdentityDomain. 
        /// <para>
        /// The Oracle Cloud Infrastructure (OCI) identity domain information in the onboarding
        /// status response.
        /// </para>
        /// </summary>
        public OciIdentityDomain OciIdentityDomain
        {
            get { return this._ociIdentityDomain; }
            set { this._ociIdentityDomain = value; }
        }

        // Check to see if OciIdentityDomain property is set
        internal bool IsSetOciIdentityDomain()
        {
            return this._ociIdentityDomain != null;
        }

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public OciOnboardingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionErrors. 
        /// <para>
        /// The list of errors that occurred during the subscription process for your Amazon Web
        /// Services account, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubscriptionError> SubscriptionErrors
        {
            get { return this._subscriptionErrors; }
            set { this._subscriptionErrors = value; }
        }

        // Check to see if SubscriptionErrors property is set
        internal bool IsSetSubscriptionErrors()
        {
            return this._subscriptionErrors != null && (this._subscriptionErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}