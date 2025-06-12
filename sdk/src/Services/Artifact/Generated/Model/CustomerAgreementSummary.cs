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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Summary for customer-agreement resource.
    /// </summary>
    public partial class CustomerAgreementSummary
    {
        private List<string> _acceptanceTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _agreementArn;
        private string _arn;
        private string _awsAccountId;
        private string _description;
        private DateTime? _effectiveEnd;
        private DateTime? _effectiveStart;
        private string _id;
        private string _name;
        private string _organizationArn;
        private CustomerAgreementState _state;
        private List<string> _terminateTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AgreementType _type;

        /// <summary>
        /// Gets and sets the property AcceptanceTerms. 
        /// <para>
        /// Terms required to accept the agreement resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> AcceptanceTerms
        {
            get { return this._acceptanceTerms; }
            set { this._acceptanceTerms = value; }
        }

        // Check to see if AcceptanceTerms property is set
        internal bool IsSetAcceptanceTerms()
        {
            return this._acceptanceTerms != null && (this._acceptanceTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgreementArn. 
        /// <para>
        /// ARN of the agreement resource the customer-agreement resource represents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AgreementArn
        {
            get { return this._agreementArn; }
            set { this._agreementArn = value; }
        }

        // Check to see if AgreementArn property is set
        internal bool IsSetAgreementArn()
        {
            return this._agreementArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the customer-agreement resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account Id that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveEnd. 
        /// <para>
        /// Timestamp indicating when the agreement was terminated.
        /// </para>
        /// </summary>
        public DateTime? EffectiveEnd
        {
            get { return this._effectiveEnd; }
            set { this._effectiveEnd = value; }
        }

        // Check to see if EffectiveEnd property is set
        internal bool IsSetEffectiveEnd()
        {
            return this._effectiveEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        /// Timestamp indicating when the agreement became effective.
        /// </para>
        /// </summary>
        public DateTime? EffectiveStart
        {
            get { return this._effectiveStart; }
            set { this._effectiveStart = value; }
        }

        // Check to see if EffectiveStart property is set
        internal bool IsSetEffectiveStart()
        {
            return this._effectiveStart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Identifier of the customer-agreement resource.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the customer-agreement resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationArn. 
        /// <para>
        /// ARN of the organization that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string OrganizationArn
        {
            get { return this._organizationArn; }
            set { this._organizationArn = value; }
        }

        // Check to see if OrganizationArn property is set
        internal bool IsSetOrganizationArn()
        {
            return this._organizationArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the resource.
        /// </para>
        /// </summary>
        public CustomerAgreementState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TerminateTerms. 
        /// <para>
        /// Terms required to terminate the customer-agreement resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> TerminateTerms
        {
            get { return this._terminateTerms; }
            set { this._terminateTerms = value; }
        }

        // Check to see if TerminateTerms property is set
        internal bool IsSetTerminateTerms()
        {
            return this._terminateTerms != null && (this._terminateTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the customer-agreement resource.
        /// </para>
        /// </summary>
        public AgreementType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}