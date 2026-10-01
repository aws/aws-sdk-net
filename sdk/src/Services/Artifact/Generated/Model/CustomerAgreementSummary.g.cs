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

namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Summary for customer-agreement resource.
    /// </summary>
    public partial class CustomerAgreementSummary
    {
        /// <summary>
        /// Gets and sets the property AcceptanceTerms. 
        /// <para>
        /// Terms required to accept the agreement resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> AcceptanceTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AcceptanceTerms property is set.
        /// </summary>
        internal bool IsSetAcceptanceTerms() => this.AcceptanceTerms != null && (this.AcceptanceTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AgreementArn. 
        /// <para>
        /// ARN of the agreement resource the customer-agreement resource represents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AgreementArn { get; set; }

        /// <summary>
        /// Checks to see if the AgreementArn property is set.
        /// </summary>
        internal bool IsSetAgreementArn() => this.AgreementArn != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the customer-agreement resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account Id that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EffectiveEnd. 
        /// <para>
        /// Timestamp indicating when the agreement was terminated.
        /// </para>
        /// </summary>
        public DateTime? EffectiveEnd { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveEnd property is set.
        /// </summary>
        internal bool IsSetEffectiveEnd() => this.EffectiveEnd.HasValue;

        /// <summary>
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        /// Timestamp indicating when the agreement became effective.
        /// </para>
        /// </summary>
        public DateTime? EffectiveStart { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveStart property is set.
        /// </summary>
        internal bool IsSetEffectiveStart() => this.EffectiveStart.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Identifier of the customer-agreement resource.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the customer-agreement resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationArn. 
        /// <para>
        /// ARN of the organization that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string OrganizationArn { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationArn property is set.
        /// </summary>
        internal bool IsSetOrganizationArn() => this.OrganizationArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the resource.
        /// </para>
        /// </summary>
        public CustomerAgreementState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TerminateTerms. 
        /// <para>
        /// Terms required to terminate the customer-agreement resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<string> TerminateTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TerminateTerms property is set.
        /// </summary>
        internal bool IsSetTerminateTerms() => this.TerminateTerms != null && (this.TerminateTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the customer-agreement resource.
        /// </para>
        /// </summary>
        public AgreementType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
