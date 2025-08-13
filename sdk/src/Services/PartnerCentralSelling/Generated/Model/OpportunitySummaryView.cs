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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
        private Customer _customer;
        private LifeCycleForView _lifecycle;
        private List<Contact> _opportunityTeam = AWSConfigs.InitializeCollections ? new List<Contact>() : null;
        private OpportunityType _opportunityType;
        private List<string> _primaryNeedsFromAws = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProjectView _project;
        private RelatedEntityIdentifiers _relatedEntityIdentifiers;

        /// <summary>
        /// Gets and sets the property Customer.
        /// </summary>
        public Customer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        // Check to see if Customer property is set
        internal bool IsSetCustomer()
        {
            return this._customer != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        ///  Contains information about the opportunity's lifecycle, including its current stage,
        /// status, and important dates such as creation and last modification times. 
        /// </para>
        /// </summary>
        public LifeCycleForView Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property OpportunityTeam. 
        /// <para>
        ///  Represents the internal team handling the opportunity. Specify the members involved
        /// in collaborating on an opportunity within the partner's organization. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<Contact> OpportunityTeam
        {
            get { return this._opportunityTeam; }
            set { this._opportunityTeam = value; }
        }

        // Check to see if OpportunityTeam property is set
        internal bool IsSetOpportunityTeam()
        {
            return this._opportunityTeam != null && (this._opportunityTeam.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OpportunityType. 
        /// <para>
        ///  Specifies the opportunity type. 
        /// </para>
        /// </summary>
        public OpportunityType OpportunityType
        {
            get { return this._opportunityType; }
            set { this._opportunityType = value; }
        }

        // Check to see if OpportunityType property is set
        internal bool IsSetOpportunityType()
        {
            return this._opportunityType != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryNeedsFromAws. 
        /// <para>
        ///  Identifies the type of support the partner needs from AWS. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PrimaryNeedsFromAws
        {
            get { return this._primaryNeedsFromAws; }
            set { this._primaryNeedsFromAws = value; }
        }

        // Check to see if PrimaryNeedsFromAws property is set
        internal bool IsSetPrimaryNeedsFromAws()
        {
            return this._primaryNeedsFromAws != null && (this._primaryNeedsFromAws.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        ///  Contains summary information about the project associated with the opportunity, including
        /// project name, description, timeline, and other relevant details. 
        /// </para>
        /// </summary>
        public ProjectView Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedEntityIdentifiers.
        /// </summary>
        public RelatedEntityIdentifiers RelatedEntityIdentifiers
        {
            get { return this._relatedEntityIdentifiers; }
            set { this._relatedEntityIdentifiers = value; }
        }

        // Check to see if RelatedEntityIdentifiers property is set
        internal bool IsSetRelatedEntityIdentifiers()
        {
            return this._relatedEntityIdentifiers != null;
        }

    }
}