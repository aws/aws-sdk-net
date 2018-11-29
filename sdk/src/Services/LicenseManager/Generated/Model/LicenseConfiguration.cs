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
    /// A license configuration is an abstraction of a customer license agreement that can
    /// be consumed and enforced by License Manager. Components include specifications for
    /// the license type (licensing by instance, socket, CPU, or VCPU), tenancy (shared tenancy,
    /// Amazon EC2 Dedicated Instance, Amazon EC2 Dedicated Host, or any of these), host affinity
    /// (how long a VM must be associated with a host), the number of licenses purchased and
    /// used.
    /// </summary>
    public partial class LicenseConfiguration
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

        /// <summary>
        /// Gets and sets the property ConsumedLicenses. 
        /// <para>
        /// Number of licenses consumed. 
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
        /// List of summaries for licenses consumed by various resources.
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
        /// ARN of the <code>LicenseConfiguration</code> object.
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
        /// Unique ID of the <code>LicenseConfiguration</code> object.
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
        /// Number of licenses managed by the license configuration.
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
        /// Dimension to use to track license inventory.
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
        /// Array of configured License Manager rules.
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
        /// List of summaries for managed resources.
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
        /// Account ID of the license configuration's owner.
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
        /// Status of the license configuration.
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

    }
}