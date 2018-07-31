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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSecurityProfile operation.
    /// Deletes a Device Defender security profile.
    /// </summary>
    public partial class DeleteSecurityProfileRequest : AmazonIoTRequest
    {
        private long? _expectedVersion;
        private string _securityProfileName;

        /// <summary>
        /// Gets and sets the property ExpectedVersion. 
        /// <para>
        /// The expected version of the security profile. A new version is generated whenever
        /// the security profile is updated. If you specify a value that is different than the
        /// actual version, a <code>VersionConflictException</code> is thrown.
        /// </para>
        /// </summary>
        public long ExpectedVersion
        {
            get { return this._expectedVersion.GetValueOrDefault(); }
            set { this._expectedVersion = value; }
        }

        // Check to see if ExpectedVersion property is set
        internal bool IsSetExpectedVersion()
        {
            return this._expectedVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name of the security profile to be deleted.
        /// </para>
        /// </summary>
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

    }
}