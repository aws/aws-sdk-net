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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIngestConfiguration operation. Updates a
    /// specified IngestConfiguration. Only the stage ARN attached to the IngestConfiguration
    /// can be updated. An IngestConfiguration that is active cannot be updated.
    /// </summary>
    public partial class UpdateIngestConfigurationRequest : AmazonIVSRealTimeRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the IngestConfiguration, for which the related stage ARN needs to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property RedundantIngest. 
        /// <para>
        /// Indicates whether redundant ingest is enabled for the ingest configuration. Default:
        /// <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? RedundantIngest { get; set; }

        /// <summary>
        /// Checks to see if the RedundantIngest property is set.
        /// </summary>
        internal bool IsSetRedundantIngest() => this.RedundantIngest.HasValue;

        /// <summary>
        /// Gets and sets the property StageArn. 
        /// <para>
        /// Stage ARN that needs to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string StageArn { get; set; }

        /// <summary>
        /// Checks to see if the StageArn property is set.
        /// </summary>
        internal bool IsSetStageArn() => this.StageArn != null;
    }
}
