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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides a comprehensive view of an opportunity summary, including lifecycle information,
    /// team details, opportunity type, primary needs from AWS, and associated project information.
    /// </summary>
    public partial class OpportunitySummaryView
    {
        /// <summary>
        /// Gets and sets the property Customer.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        ///  Contains information about the opportunity's lifecycle, including its current stage,
        /// status, and important dates such as creation and last modification times. 
        /// </para>
        /// </summary>
        public LifeCycleForView Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property OpportunityTeam. 
        /// <para>
        ///  Represents the internal team handling the opportunity. Specify the members involved
        /// in collaborating on an opportunity within the partner's organization. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<Contact> OpportunityTeam { get; set; } = AWSConfigs.InitializeCollections ? new List<Contact>() : null;

        /// <summary>
        /// Checks to see if the OpportunityTeam property is set.
        /// </summary>
        internal bool IsSetOpportunityTeam() => this.OpportunityTeam != null && (this.OpportunityTeam.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OpportunityType. 
        /// <para>
        ///  Specifies the opportunity type. 
        /// </para>
        /// </summary>
        public OpportunityType OpportunityType { get; set; }

        /// <summary>
        /// Checks to see if the OpportunityType property is set.
        /// </summary>
        internal bool IsSetOpportunityType() => this.OpportunityType != null;

        /// <summary>
        /// Gets and sets the property PrimaryNeedsFromAws. 
        /// <para>
        ///  Identifies the type of support the partner needs from AWS. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrimaryNeedsFromAws { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrimaryNeedsFromAws property is set.
        /// </summary>
        internal bool IsSetPrimaryNeedsFromAws() => this.PrimaryNeedsFromAws != null && (this.PrimaryNeedsFromAws.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        ///  Contains summary information about the project associated with the opportunity, including
        /// project name, description, timeline, and other relevant details. 
        /// </para>
        /// </summary>
        public ProjectView Project { get; set; }

        /// <summary>
        /// Checks to see if the Project property is set.
        /// </summary>
        internal bool IsSetProject() => this.Project != null;

        /// <summary>
        /// Gets and sets the property RelatedEntityIdentifiers.
        /// </summary>
        public RelatedEntityIdentifiers RelatedEntityIdentifiers { get; set; }

        /// <summary>
        /// Checks to see if the RelatedEntityIdentifiers property is set.
        /// </summary>
        internal bool IsSetRelatedEntityIdentifiers() => this.RelatedEntityIdentifiers != null;
    }
}
