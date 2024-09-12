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
    /// This structure contains information about the most recent run of a single canary.
    /// </summary>
    public partial class CanaryLastRun
    {
        private string _canaryName;
        private CanaryRun _lastRun;

        /// <summary>
        /// Gets and sets the property CanaryName. 
        /// <para>
        /// The name of the canary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CanaryName
        {
            get { return this._canaryName; }
            set { this._canaryName = value; }
        }

        // Check to see if CanaryName property is set
        internal bool IsSetCanaryName()
        {
            return this._canaryName != null;
        }

        /// <summary>
        /// Gets and sets the property LastRun. 
        /// <para>
        /// The results from this canary's most recent run.
        /// </para>
        /// </summary>
        public CanaryRun LastRun
        {
            get { return this._lastRun; }
            set { this._lastRun = value; }
        }

        // Check to see if LastRun property is set
        internal bool IsSetLastRun()
        {
            return this._lastRun != null;
        }

    }
}