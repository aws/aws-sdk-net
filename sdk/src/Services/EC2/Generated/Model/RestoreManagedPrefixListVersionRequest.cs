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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreManagedPrefixListVersion operation.
    /// Restores the entries from a previous version of a managed prefix list to a new version
    /// of the prefix list.
    /// </summary>
    public partial class RestoreManagedPrefixListVersionRequest : AmazonEC2Request
    {
        private long? _currentVersion;
        private string _prefixListId;
        private long? _previousVersion;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The current version number for the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long CurrentVersion
        {
            get { return this._currentVersion.GetValueOrDefault(); }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of the prefix list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousVersion. 
        /// <para>
        /// The version to restore.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long PreviousVersion
        {
            get { return this._previousVersion.GetValueOrDefault(); }
            set { this._previousVersion = value; }
        }

        // Check to see if PreviousVersion property is set
        internal bool IsSetPreviousVersion()
        {
            return this._previousVersion.HasValue; 
        }

    }
}