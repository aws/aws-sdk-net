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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AppleInternal. 
        /// <para>
        /// Enables or disables Apple Internal.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus AppleInternal { get; set; }

        /// <summary>
        /// Checks to see if the AppleInternal property is set.
        /// </summary>
        internal bool IsSetAppleInternal() => this.AppleInternal != null;

        /// <summary>
        /// Gets and sets the property BaseSystem. 
        /// <para>
        /// Enables or disables Base System.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus BaseSystem { get; set; }

        /// <summary>
        /// Checks to see if the BaseSystem property is set.
        /// </summary>
        internal bool IsSetBaseSystem() => this.BaseSystem != null;

        /// <summary>
        /// Gets and sets the property DTraceRestrictions. 
        /// <para>
        /// Enables or disables Dtrace Restrictions.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus DTraceRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the DTraceRestrictions property is set.
        /// </summary>
        internal bool IsSetDTraceRestrictions() => this.DTraceRestrictions != null;

        /// <summary>
        /// Gets and sets the property DebuggingRestrictions. 
        /// <para>
        /// Enables or disables Debugging Restrictions.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus DebuggingRestrictions { get; set; }

        /// <summary>
        /// Checks to see if the DebuggingRestrictions property is set.
        /// </summary>
        internal bool IsSetDebuggingRestrictions() => this.DebuggingRestrictions != null;

        /// <summary>
        /// Gets and sets the property FilesystemProtections. 
        /// <para>
        /// Enables or disables Filesystem Protections.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus FilesystemProtections { get; set; }

        /// <summary>
        /// Checks to see if the FilesystemProtections property is set.
        /// </summary>
        internal bool IsSetFilesystemProtections() => this.FilesystemProtections != null;

        /// <summary>
        /// Gets and sets the property KextSigning. 
        /// <para>
        /// Enables or disables Kext Signing.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus KextSigning { get; set; }

        /// <summary>
        /// Checks to see if the KextSigning property is set.
        /// </summary>
        internal bool IsSetKextSigning() => this.KextSigning != null;

        /// <summary>
        /// Gets and sets the property NvramProtections. 
        /// <para>
        /// Enables or disables Nvram Protections.
        /// </para>
        /// </summary>
        public MacSystemIntegrityProtectionSettingStatus NvramProtections { get; set; }

        /// <summary>
        /// Checks to see if the NvramProtections property is set.
        /// </summary>
        internal bool IsSetNvramProtections() => this.NvramProtections != null;
    }
}
