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
    /// Updates the delegated administrator account with the values provided.
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
        private OrganizationDataSourceConfigurations _dataSources;
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Indicates whether to automatically enable member accounts in the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Describes which data sources will be updated.
        /// </para>
        /// </summary>
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
        /// The ID of the detector to update the delegated administrator for.
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

    }
}