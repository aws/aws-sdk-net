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
    /// Container for the parameters to the UpdateLicenseConfiguration operation.
    /// Modifies the attributes of an existing license configuration object. A license configuration
    /// is an abstraction of a customer license agreement that can be consumed and enforced
    /// by License Manager. Components include specifications for the license type (Instances,
    /// cores, sockets, VCPUs), tenancy (shared or Dedicated Host), host affinity (how long
    /// a VM is associated with a host), the number of licenses purchased and used.
    /// </summary>
    public partial class UpdateLicenseConfigurationRequest : AmazonLicenseManagerRequest
    {
        private string _description;
        private string _licenseConfigurationArn;
        private LicenseConfigurationStatus _licenseConfigurationStatus;
        private long? _licenseCount;
        private bool? _licenseCountHardLimit;
        private List<string> _licenseRules = new List<string>();
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// New human-friendly description of the license configuration.
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
        /// ARN for a license configuration.
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
        /// Gets and sets the property LicenseConfigurationStatus. 
        /// <para>
        /// New status of the license configuration (<code>ACTIVE</code> or <code>INACTIVE</code>).
        /// </para>
        /// </summary>
        public LicenseConfigurationStatus LicenseConfigurationStatus
        {
            get { return this._licenseConfigurationStatus; }
            set { this._licenseConfigurationStatus = value; }
        }

        // Check to see if LicenseConfigurationStatus property is set
        internal bool IsSetLicenseConfigurationStatus()
        {
            return this._licenseConfigurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseCount. 
        /// <para>
        /// New number of licenses managed by the license configuration.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// New name of the license configuration.
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

    }
}