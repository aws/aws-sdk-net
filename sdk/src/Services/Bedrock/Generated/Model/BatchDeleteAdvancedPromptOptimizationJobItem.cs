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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Successfully deleted advanced prompt optimization job.
    /// </summary>
    public partial class BatchDeleteAdvancedPromptOptimizationJobItem
    {
        private string _jobIdentifier;
        private AdvancedPromptOptimizationJobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property JobIdentifier. 
        /// <para>
        /// Identifier of the deleted job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string JobIdentifier
        {
            get { return this._jobIdentifier; }
            set { this._jobIdentifier = value; }
        }

        // Check to see if JobIdentifier property is set
        internal bool IsSetJobIdentifier()
        {
            return this._jobIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Status of the deleted job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AdvancedPromptOptimizationJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

    }
}