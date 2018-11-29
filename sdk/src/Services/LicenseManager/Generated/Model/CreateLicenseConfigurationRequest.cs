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
    /// Container for the parameters to the CreateLicenseConfiguration operation.
    /// Creates a new license configuration object. A license configuration is an abstraction
    /// of a customer license agreement that can be consumed and enforced by License Manager.
    /// Components include specifications for the license type (licensing by instance, socket,
    /// CPU, or VCPU), tenancy (shared tenancy, Amazon EC2 Dedicated Instance, Amazon EC2
    /// Dedicated Host, or any of these), host affinity (how long a VM must be associated
    /// with a host), the number of licenses purchased and used.
    /// </summary>
    public partial class CreateLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
        private string _description;
        private long? _licenseCount;
        private bool? _licenseCountHardLimit;
        private LicenseCountingType _licenseCountingType;
        private List<string> _licenseRules = new List<string>();
        private string _name;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-friendly description of the license configuration.
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
        /// Flag indicating whether hard or soft license enforcement is used. Exceeding a hard
        /// limit results in the blocked deployment of new instances.
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
        /// Dimension to use to track the license inventory.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the resources during launch. You can only tag instances and volumes
        /// on launch. The specified tags are applied to all instances or volumes that are created
        /// during launch. To tag a resource after it has been created, see CreateTags .
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