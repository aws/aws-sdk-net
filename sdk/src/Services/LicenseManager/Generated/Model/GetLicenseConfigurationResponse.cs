/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the GetLicenseConfiguration operation.
    /// </summary>
    public partial class GetLicenseConfigurationResponse : AmazonWebServiceResponse
    {
        private long? _consumedLicenses;
        private List<ConsumedLicenseSummary> _consumedLicenseSummaryList = new List<ConsumedLicenseSummary>();
        private string _description;
        private string _licenseConfigurationArn;
        private string _licenseConfigurationId;
        private long? _licenseCount;
        private bool? _licenseCountHardLimit;
        private LicenseCountingType _licenseCountingType;
        private List<string> _licenseRules = new List<string>();
        private List<ManagedResourceSummary> _managedResourceSummaryList = new List<ManagedResourceSummary>();
        private string _name;
        private string _ownerAccountId;
        private string _status;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ConsumedLicenses. 
        /// <para>
        /// Number of licenses assigned to resources.
        /// </para>
        /// </summary>
        public long ConsumedLicenses
        {
            get { return this._consumedLicenses.GetValueOrDefault(); }
            set { this._consumedLicenses = value; }
        }

        // Check to see if ConsumedLicenses property is set
        internal bool IsSetConsumedLicenses()
        {
            return this._consumedLicenses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumedLicenseSummaryList. 
        /// <para>
        /// List of summaries for consumed licenses used by various resources.
        /// </para>
        /// </summary>
        public List<ConsumedLicenseSummary> ConsumedLicenseSummaryList
        {
            get { return this._consumedLicenseSummaryList; }
            set { this._consumedLicenseSummaryList = value; }
        }

        // Check to see if ConsumedLicenseSummaryList property is set
        internal bool IsSetConsumedLicenseSummaryList()
        {
            return this._consumedLicenseSummaryList != null && this._consumedLicenseSummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the license configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LicenseConfigurationArn. 
        /// <para>
        /// ARN of the license configuration requested.
        /// </para>
        /// </summary>
        public string LicenseConfigurationArn
        {
            get { return this._licenseConfigurationArn; }
            set { this._licenseConfigurationArn = value; }
        }

        // Check to see if LicenseConfigurationArn property is set
        internal bool IsSetLicenseConfigurationArn()
        {
            return this._licenseConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConfigurationId. 
        /// <para>
        /// Unique ID for the license configuration.
        /// </para>
        /// </summary>
        public string LicenseConfigurationId
        {
            get { return this._licenseConfigurationId; }
            set { this._licenseConfigurationId = value; }
        }

        // Check to see if LicenseConfigurationId property is set
        internal bool IsSetLicenseConfigurationId()
        {
            return this._licenseConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// Number of available licenses.
        /// </para>
        /// </summary>
        public long LicenseCount
        {
            get { return this._licenseCount.GetValueOrDefault(); }
            set { this._licenseCount = value; }
        }

        // Check to see if LicenseCount property is set
        internal bool IsSetLicenseCount()
        {
            return this._licenseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseCountHardLimit. 
        /// <para>
        /// Sets the number of available licenses as a hard limit.
        /// </para>
        /// </summary>
        public bool LicenseCountHardLimit
        {
            get { return this._licenseCountHardLimit.GetValueOrDefault(); }
            set { this._licenseCountHardLimit = value; }
        }

        // Check to see if LicenseCountHardLimit property is set
        internal bool IsSetLicenseCountHardLimit()
        {
            return this._licenseCountHardLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseCountingType. 
        /// <para>
        /// Dimension on which the licenses are counted (for example, instances, cores, sockets,
        /// or VCPUs).
        /// </para>
        /// </summary>
        public LicenseCountingType LicenseCountingType
        {
            get { return this._licenseCountingType; }
            set { this._licenseCountingType = value; }
        }

        // Check to see if LicenseCountingType property is set
        internal bool IsSetLicenseCountingType()
        {
            return this._licenseCountingType != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseRules. 
        /// <para>
        /// List of flexible text strings designating license rules.
        /// </para>
        /// </summary>
        public List<string> LicenseRules
        {
            get { return this._licenseRules; }
            set { this._licenseRules = value; }
        }

        // Check to see if LicenseRules property is set
        internal bool IsSetLicenseRules()
        {
            return this._licenseRules != null && this._licenseRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ManagedResourceSummaryList. 
        /// <para>
        /// List of summaries of managed resources.
        /// </para>
        /// </summary>
        public List<ManagedResourceSummary> ManagedResourceSummaryList
        {
            get { return this._managedResourceSummaryList; }
            set { this._managedResourceSummaryList = value; }
        }

        // Check to see if ManagedResourceSummaryList property is set
        internal bool IsSetManagedResourceSummaryList()
        {
            return this._managedResourceSummaryList != null && this._managedResourceSummaryList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the license configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// Owner account ID for the license configuration.
        /// </para>
        /// </summary>
        public string OwnerAccountId
        {
            get { return this._ownerAccountId; }
            set { this._ownerAccountId = value; }
        }

        // Check to see if OwnerAccountId property is set
        internal bool IsSetOwnerAccountId()
        {
            return this._ownerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// License configuration status (active, etc.).
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags attached to the license configuration.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}