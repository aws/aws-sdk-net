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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An object that defines how Security Hub is configured. The configuration policy includes
    /// whether Security Hub is enabled or disabled, a list of enabled security standards,
    /// a list of enabled or disabled security controls, and a list of custom parameter values
    /// for specified controls. If you provide a list of security controls that are enabled
    /// in the configuration policy, Security Hub disables all other controls (including newly
    /// released controls). If you provide a list of security controls that are disabled in
    /// the configuration policy, Security Hub enables all other controls (including newly
    /// released controls).
    /// </summary>
    public partial class SecurityHubPolicy
    {
        private List<string> _enabledStandardIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SecurityControlsConfiguration _securityControlsConfiguration;
        private bool? _serviceEnabled;

        /// <summary>
        /// Gets and sets the property EnabledStandardIdentifiers. 
        /// <para>
        ///  A list that defines which security standards are enabled in the configuration policy.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledStandardIdentifiers
        {
            get { return this._enabledStandardIdentifiers; }
            set { this._enabledStandardIdentifiers = value; }
        }

        // Check to see if EnabledStandardIdentifiers property is set
        internal bool IsSetEnabledStandardIdentifiers()
        {
            return this._enabledStandardIdentifiers != null && (this._enabledStandardIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityControlsConfiguration. 
        /// <para>
        ///  An object that defines which security controls are enabled in the configuration policy.
        /// The enablement status of a control is aligned across all of the enabled standards
        /// in an account. 
        /// </para>
        /// </summary>
        public SecurityControlsConfiguration SecurityControlsConfiguration
        {
            get { return this._securityControlsConfiguration; }
            set { this._securityControlsConfiguration = value; }
        }

        // Check to see if SecurityControlsConfiguration property is set
        internal bool IsSetSecurityControlsConfiguration()
        {
            return this._securityControlsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceEnabled. 
        /// <para>
        ///  Indicates whether Security Hub is enabled in the policy. 
        /// </para>
        /// </summary>
        public bool? ServiceEnabled
        {
            get { return this._serviceEnabled; }
            set { this._serviceEnabled = value; }
        }

        // Check to see if ServiceEnabled property is set
        internal bool IsSetServiceEnabled()
        {
            return this._serviceEnabled.HasValue; 
        }

    }
}