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
    /// An object that defines which security controls are enabled in an Security Hub configuration
    /// policy. The enablement status of a control is aligned across all of the enabled standards
    /// in an account.
    /// </summary>
    public partial class SecurityControlsConfiguration
    {
        private List<string> _disabledSecurityControlIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _enabledSecurityControlIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<SecurityControlCustomParameter> _securityControlCustomParameters = AWSConfigs.InitializeCollections ? new List<SecurityControlCustomParameter>() : null;

        /// <summary>
        /// Gets and sets the property DisabledSecurityControlIdentifiers. 
        /// <para>
        ///  A list of security controls that are disabled in the configuration policy. Security
        /// Hub enables all other controls (including newly released controls) other than the
        /// listed controls. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DisabledSecurityControlIdentifiers
        {
            get { return this._disabledSecurityControlIdentifiers; }
            set { this._disabledSecurityControlIdentifiers = value; }
        }

        // Check to see if DisabledSecurityControlIdentifiers property is set
        internal bool IsSetDisabledSecurityControlIdentifiers()
        {
            return this._disabledSecurityControlIdentifiers != null && (this._disabledSecurityControlIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnabledSecurityControlIdentifiers. 
        /// <para>
        ///  A list of security controls that are enabled in the configuration policy. Security
        /// Hub disables all other controls (including newly released controls) other than the
        /// listed controls. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledSecurityControlIdentifiers
        {
            get { return this._enabledSecurityControlIdentifiers; }
            set { this._enabledSecurityControlIdentifiers = value; }
        }

        // Check to see if EnabledSecurityControlIdentifiers property is set
        internal bool IsSetEnabledSecurityControlIdentifiers()
        {
            return this._enabledSecurityControlIdentifiers != null && (this._enabledSecurityControlIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityControlCustomParameters. 
        /// <para>
        ///  A list of security controls and control parameter values that are included in a configuration
        /// policy. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityControlCustomParameter> SecurityControlCustomParameters
        {
            get { return this._securityControlCustomParameters; }
            set { this._securityControlCustomParameters = value; }
        }

        // Check to see if SecurityControlCustomParameters property is set
        internal bool IsSetSecurityControlCustomParameters()
        {
            return this._securityControlCustomParameters != null && (this._securityControlCustomParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}