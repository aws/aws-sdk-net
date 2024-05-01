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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object representing the Source Network recovery Lifecycle.
    /// </summary>
    public partial class RecoveryLifeCycle
    {
        private DateTime? _apiCallDateTime;
        private string _jobid;
        private RecoveryResult _lastRecoveryResult;

        /// <summary>
        /// Gets and sets the property ApiCallDateTime. 
        /// <para>
        /// The date and time the last Source Network recovery was initiated.
        /// </para>
        /// </summary>
        public DateTime? ApiCallDateTime
        {
            get { return this._apiCallDateTime; }
            set { this._apiCallDateTime = value; }
        }

        // Check to see if ApiCallDateTime property is set
        internal bool IsSetApiCallDateTime()
        {
            return this._apiCallDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The ID of the Job that was used to last recover the Source Network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=24, Max=24)]
        public string JobID
        {
            get { return this._jobid; }
            set { this._jobid = value; }
        }

        // Check to see if JobID property is set
        internal bool IsSetJobID()
        {
            return this._jobid != null;
        }

        /// <summary>
        /// Gets and sets the property LastRecoveryResult. 
        /// <para>
        /// The status of the last recovery status of this Source Network.
        /// </para>
        /// </summary>
        public RecoveryResult LastRecoveryResult
        {
            get { return this._lastRecoveryResult; }
            set { this._lastRecoveryResult = value; }
        }

        // Check to see if LastRecoveryResult property is set
        internal bool IsSetLastRecoveryResult()
        {
            return this._lastRecoveryResult != null;
        }

    }
}