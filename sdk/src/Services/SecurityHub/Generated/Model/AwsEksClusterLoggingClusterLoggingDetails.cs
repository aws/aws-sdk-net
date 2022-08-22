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
    /// Details for a cluster logging configuration.
    /// </summary>
    public partial class AwsEksClusterLoggingClusterLoggingDetails
    {
        private bool? _enabled;
        private List<string> _types = new List<string>();

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the logging types that are listed in <code>Types</code> are enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// A list of logging types. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>api</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>audit</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>authenticator</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>controllerManager</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>scheduler</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && this._types.Count > 0; 
        }

    }
}