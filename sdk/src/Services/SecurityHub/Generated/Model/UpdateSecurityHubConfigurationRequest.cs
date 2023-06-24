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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityHubConfiguration operation.
    /// Updates configuration options for Security Hub.
    /// </summary>
    public partial class UpdateSecurityHubConfigurationRequest : AmazonSecurityHubRequest
    {
        private bool? _autoEnableControls;
        private ControlFindingGenerator _controlFindingGenerator;

        /// <summary>
        /// Gets and sets the property AutoEnableControls. 
        /// <para>
        /// Whether to automatically enable new controls when they are added to standards that
        /// are enabled.
        /// </para>
        ///  
        /// <para>
        /// By default, this is set to <code>true</code>, and new controls are enabled automatically.
        /// To not automatically enable new controls, set this to <code>false</code>. 
        /// </para>
        /// </summary>
        public bool AutoEnableControls
        {
            get { return this._autoEnableControls.GetValueOrDefault(); }
            set { this._autoEnableControls = value; }
        }

        // Check to see if AutoEnableControls property is set
        internal bool IsSetAutoEnableControls()
        {
            return this._autoEnableControls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ControlFindingGenerator. 
        /// <para>
        /// Updates whether the calling account has consolidated control findings turned on. If
        /// the value for this field is set to <code>SECURITY_CONTROL</code>, Security Hub generates
        /// a single finding for a control check even when the check applies to multiple enabled
        /// standards.
        /// </para>
        ///  
        /// <para>
        /// If the value for this field is set to <code>STANDARD_CONTROL</code>, Security Hub
        /// generates separate findings for a control check when the check applies to multiple
        /// enabled standards.
        /// </para>
        ///  
        /// <para>
        /// For accounts that are part of an organization, this value can only be updated in the
        /// administrator account.
        /// </para>
        /// </summary>
        public ControlFindingGenerator ControlFindingGenerator
        {
            get { return this._controlFindingGenerator; }
            set { this._controlFindingGenerator = value; }
        }

        // Check to see if ControlFindingGenerator property is set
        internal bool IsSetControlFindingGenerator()
        {
            return this._controlFindingGenerator != null;
        }

    }
}