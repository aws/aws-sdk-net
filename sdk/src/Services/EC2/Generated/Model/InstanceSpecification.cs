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
    /// The instance details to specify which volumes should be snapshotted.
    /// </summary>
    public partial class InstanceSpecification
    {
        private bool? _excludeBootVolume;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ExcludeBootVolume. 
        /// <para>
        /// Excludes the root volume from being snapshotted.
        /// </para>
        /// </summary>
        public bool ExcludeBootVolume
        {
            get { return this._excludeBootVolume.GetValueOrDefault(); }
            set { this._excludeBootVolume = value; }
        }

        // Check to see if ExcludeBootVolume property is set
        internal bool IsSetExcludeBootVolume()
        {
            return this._excludeBootVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance to specify which volumes should be snapshotted.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}