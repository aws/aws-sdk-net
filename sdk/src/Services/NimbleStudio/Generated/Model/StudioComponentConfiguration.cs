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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The configuration of the studio component, based on component type.
    /// </summary>
    public partial class StudioComponentConfiguration
    {
        private ActiveDirectoryConfiguration _activeDirectoryConfiguration;
        private ComputeFarmConfiguration _computeFarmConfiguration;
        private LicenseServiceConfiguration _licenseServiceConfiguration;
        private SharedFileSystemConfiguration _sharedFileSystemConfiguration;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfiguration. 
        /// <para>
        /// The configuration for a Directory Service for Microsoft Active Directory studio resource.
        /// </para>
        /// </summary>
        public ActiveDirectoryConfiguration ActiveDirectoryConfiguration
        {
            get { return this._activeDirectoryConfiguration; }
            set { this._activeDirectoryConfiguration = value; }
        }

        // Check to see if ActiveDirectoryConfiguration property is set
        internal bool IsSetActiveDirectoryConfiguration()
        {
            return this._activeDirectoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeFarmConfiguration. 
        /// <para>
        /// The configuration for a render farm that is associated with a studio resource.
        /// </para>
        /// </summary>
        public ComputeFarmConfiguration ComputeFarmConfiguration
        {
            get { return this._computeFarmConfiguration; }
            set { this._computeFarmConfiguration = value; }
        }

        // Check to see if ComputeFarmConfiguration property is set
        internal bool IsSetComputeFarmConfiguration()
        {
            return this._computeFarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseServiceConfiguration. 
        /// <para>
        /// The configuration for a license service that is associated with a studio resource.
        /// </para>
        /// </summary>
        public LicenseServiceConfiguration LicenseServiceConfiguration
        {
            get { return this._licenseServiceConfiguration; }
            set { this._licenseServiceConfiguration = value; }
        }

        // Check to see if LicenseServiceConfiguration property is set
        internal bool IsSetLicenseServiceConfiguration()
        {
            return this._licenseServiceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SharedFileSystemConfiguration. 
        /// <para>
        /// The configuration for a shared file storage system that is associated with a studio
        /// resource.
        /// </para>
        /// </summary>
        public SharedFileSystemConfiguration SharedFileSystemConfiguration
        {
            get { return this._sharedFileSystemConfiguration; }
            set { this._sharedFileSystemConfiguration = value; }
        }

        // Check to see if SharedFileSystemConfiguration property is set
        internal bool IsSetSharedFileSystemConfiguration()
        {
            return this._sharedFileSystemConfiguration != null;
        }

    }
}