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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a custom configuration for a System Integrity Protection (SIP) modification
    /// task.
    /// </summary>
    public partial class MacSystemIntegrityProtectionConfigurationRequest
    {
        private MacSystemIntegrityProtectionSettingStatus _appleInternal;
        private MacSystemIntegrityProtectionSettingStatus _baseSystem;
        private MacSystemIntegrityProtectionSettingStatus _debuggingRestrictions;
        private MacSystemIntegrityProtectionSettingStatus _dTraceRestrictions;
        private MacSystemIntegrityProtectionSettingStatus _filesystemProtections;
        private MacSystemIntegrityProtectionSettingStatus _kextSigning;
        private MacSystemIntegrityProtectionSettingStatus _nvramProtections;

        /// <summary>
        /// Gets and sets the property AppleInternal. 
        /// <para>
        /// Enables or disables Apple Internal.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus AppleInternal
        {
            get { return this._appleInternal; }
            set { this._appleInternal = value; }
        }

        // Check to see if AppleInternal property is set
        internal bool IsSetAppleInternal()
        {
            return this._appleInternal != null;
        }

        /// <summary>
        /// Gets and sets the property BaseSystem. 
        /// <para>
        /// Enables or disables Base System.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus BaseSystem
        {
            get { return this._baseSystem; }
            set { this._baseSystem = value; }
        }

        // Check to see if BaseSystem property is set
        internal bool IsSetBaseSystem()
        {
            return this._baseSystem != null;
        }

        /// <summary>
        /// Gets and sets the property DebuggingRestrictions. 
        /// <para>
        /// Enables or disables Debugging Restrictions.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus DebuggingRestrictions
        {
            get { return this._debuggingRestrictions; }
            set { this._debuggingRestrictions = value; }
        }

        // Check to see if DebuggingRestrictions property is set
        internal bool IsSetDebuggingRestrictions()
        {
            return this._debuggingRestrictions != null;
        }

        /// <summary>
        /// Gets and sets the property DTraceRestrictions. 
        /// <para>
        /// Enables or disables Dtrace Restrictions.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus DTraceRestrictions
        {
            get { return this._dTraceRestrictions; }
            set { this._dTraceRestrictions = value; }
        }

        // Check to see if DTraceRestrictions property is set
        internal bool IsSetDTraceRestrictions()
        {
            return this._dTraceRestrictions != null;
        }

        /// <summary>
        /// Gets and sets the property FilesystemProtections. 
        /// <para>
        /// Enables or disables Filesystem Protections.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus FilesystemProtections
        {
            get { return this._filesystemProtections; }
            set { this._filesystemProtections = value; }
        }

        // Check to see if FilesystemProtections property is set
        internal bool IsSetFilesystemProtections()
        {
            return this._filesystemProtections != null;
        }

        /// <summary>
        /// Gets and sets the property KextSigning. 
        /// <para>
        /// Enables or disables Kext Signing.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus KextSigning
        {
            get { return this._kextSigning; }
            set { this._kextSigning = value; }
        }

        // Check to see if KextSigning property is set
        internal bool IsSetKextSigning()
        {
            return this._kextSigning != null;
        }

        /// <summary>
        /// Gets and sets the property NvramProtections. 
        /// <para>
        /// Enables or disables Nvram Protections.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus NvramProtections
        {
            get { return this._nvramProtections; }
            set { this._nvramProtections = value; }
        }

        // Check to see if NvramProtections property is set
        internal bool IsSetNvramProtections()
        {
            return this._nvramProtections != null;
        }

    }
}