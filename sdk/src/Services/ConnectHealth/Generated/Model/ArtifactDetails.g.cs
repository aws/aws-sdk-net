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

namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Details about a generated artifact including location and status
    /// </summary>
    public partial class ArtifactDetails
    {
        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for failure if the artifact generation failed
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property OutputLocation.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The generation status of the artifact
        /// </para>
        /// </summary>
        public PostStreamArtifactGenerationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
