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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOrganizationConfiguration operation.
    /// Configures the delegated administrator account with the provided values. You must
    /// provide the value for either <code>autoEnableOrganizationMembers</code> or <code>autoEnable</code>.
    /// 
    /// 
    ///  
    /// <para>
    /// There might be regional differences because some data sources might not be available
    /// in all the Amazon Web Services Regions where GuardDuty is presently supported. For
    /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
    /// and endpoints</a>.
    /// </para>
    /// </summary>
    public partial class UpdateOrganizationConfigurationRequest : AmazonGuardDutyRequest
    {
        private bool? _autoEnable;
        private AutoEnableMembers _autoEnableOrganizationMembers;
        private OrganizationDataSourceConfigurations _dataSources;
        private string _detectorId;
        private List<OrganizationFeatureConfiguration> _features = new List<OrganizationFeatureConfiguration>();

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Indicates whether to automatically enable member accounts in the organization.
        /// </para>
        ///  
        /// <para>
        /// Even though this is still supported, we recommend using <code>AutoEnableOrganizationMembers</code>
        /// to achieve the similar results.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use AutoEnableOrganizationMembers instead")]
        public bool AutoEnable
        {
            get { return this._autoEnable.GetValueOrDefault(); }
            set { this._autoEnable = value; }
        }

        // Check to see if AutoEnable property is set
        internal bool IsSetAutoEnable()
        {
            return this._autoEnable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoEnableOrganizationMembers. 
        /// <para>
        /// Indicates the auto-enablement configuration of GuardDuty for the member accounts in
        /// the organization. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEW</code>: Indicates that when a new account joins the organization, they
        /// will have GuardDuty enabled automatically. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALL</code>: Indicates that all accounts in the Amazon Web Services Organization
        /// have GuardDuty enabled automatically. This includes <code>NEW</code> accounts that
        /// join the organization and accounts that may have been suspended or removed from the
        /// organization in GuardDuty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NONE</code>: Indicates that GuardDuty will not be automatically enabled for
        /// any accounts in the organization. GuardDuty must be managed for each account individually
        /// by the administrator.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AutoEnableMembers AutoEnableOrganizationMembers
        {
            get { return this._autoEnableOrganizationMembers; }
            set { this._autoEnableOrganizationMembers = value; }
        }

        // Check to see if AutoEnableOrganizationMembers property is set
        internal bool IsSetAutoEnableOrganizationMembers()
        {
            return this._autoEnableOrganizationMembers != null;
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Describes which data sources will be updated.
        /// </para>
        /// </summary>
        [Obsolete("This parameter is deprecated, use Features instead")]
        public OrganizationDataSourceConfigurations DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector that configures the delegated administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// A list of features that will be configured for the organization.
        /// </para>
        /// </summary>
        public List<OrganizationFeatureConfiguration> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && this._features.Count > 0; 
        }

    }
}