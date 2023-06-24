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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// A key-value pair you set that identifies a property of the authenticating instance.
    /// </summary>
    public partial class InstanceProperty
    {
        private bool? _failed;
        private Dictionary<string, string> _properties = new Dictionary<string, string>();
        private DateTime? _seenAt;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Indicates whether the temporary credential request was successful. 
        /// </para>
        /// </summary>
        public bool Failed
        {
            get { return this._failed.GetValueOrDefault(); }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A list of instanceProperty objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SeenAt. 
        /// <para>
        /// The ISO-8601 time stamp of when the certificate was last used in a temporary credential
        /// request.
        /// </para>
        /// </summary>
        public DateTime SeenAt
        {
            get { return this._seenAt.GetValueOrDefault(); }
            set { this._seenAt = value; }
        }

        // Check to see if SeenAt property is set
        internal bool IsSetSeenAt()
        {
            return this._seenAt.HasValue; 
        }

    }
}