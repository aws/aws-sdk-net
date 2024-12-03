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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// A complex type that specifies multitrack input configuration.
    /// </summary>
    public partial class MultitrackInputConfiguration
    {
        private bool? _enabled;
        private MultitrackMaximumResolution _maximumResolution;
        private MultitrackPolicy _policy;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether multitrack input is enabled. Can be set to <c>true</c> only if channel
        /// type is <c>STANDARD</c>. Setting <c>enabled</c> to <c>true</c> with any other channel
        /// type will cause an exception. If <c>true</c>, then <c>policy</c>, <c>maximumResolution</c>,
        /// and <c>containerFormat</c> are required, and <c>containerFormat</c> must be set to
        /// <c>FRAGMENTED_MP4</c>. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumResolution. 
        /// <para>
        /// Maximum resolution for multitrack input. Required if <c>enabled</c> is <c>true</c>.
        /// </para>
        /// </summary>
        public MultitrackMaximumResolution MaximumResolution
        {
            get { return this._maximumResolution; }
            set { this._maximumResolution = value; }
        }

        // Check to see if MaximumResolution property is set
        internal bool IsSetMaximumResolution()
        {
            return this._maximumResolution != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Indicates whether multitrack input is allowed or required. Required if <c>enabled</c>
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        public MultitrackPolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}