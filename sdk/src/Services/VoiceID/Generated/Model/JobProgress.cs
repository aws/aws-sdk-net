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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
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
namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Indicates the completion progress for a batch job.
    /// </summary>
    public partial class JobProgress
    {
        private int? _percentComplete;

        /// <summary>
        /// Gets and sets the property PercentComplete. 
        /// <para>
        /// Shows the completed percentage of enrollment or registration requests listed in the
        /// input file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }

        // Check to see if PercentComplete property is set
        internal bool IsSetPercentComplete()
        {
            return this._percentComplete.HasValue; 
        }

    }
}