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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains information about when the canary was created and modified.
    /// </summary>
    public partial class CanaryTimeline
    {
        private DateTime? _created;
        private DateTime? _lastModified;
        private DateTime? _lastStarted;
        private DateTime? _lastStopped;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time the canary was created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time the canary was most recently modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStarted. 
        /// <para>
        /// The date and time that the canary's most recent run started.
        /// </para>
        /// </summary>
        public DateTime? LastStarted
        {
            get { return this._lastStarted; }
            set { this._lastStarted = value; }
        }

        // Check to see if LastStarted property is set
        internal bool IsSetLastStarted()
        {
            return this._lastStarted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastStopped. 
        /// <para>
        /// The date and time that the canary's most recent run ended.
        /// </para>
        /// </summary>
        public DateTime? LastStopped
        {
            get { return this._lastStopped; }
            set { this._lastStopped = value; }
        }

        // Check to see if LastStopped property is set
        internal bool IsSetLastStopped()
        {
            return this._lastStopped.HasValue; 
        }

    }
}