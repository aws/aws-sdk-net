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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The per-resource auto-remediation for a single affected resource. Represents one AWS
    /// Systems Manager (SSM) runbook execution that targets the resource. Present only when
    /// the resource's check is backed by an SSM automation runbook.
    /// </summary>
    public partial class AutoRemediation
    {
        /// <summary>
        /// Gets and sets the property CliCommand. 
        /// <para>
        /// The AWS CLI command that triggers the same SSM runbook execution for this resource.
        /// You can copy and run this command as-is.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string CliCommand { get; set; }

        /// <summary>
        /// Checks to see if the CliCommand property is set.
        /// </summary>
        internal bool IsSetCliCommand() => this.CliCommand != null;

        /// <summary>
        /// Gets and sets the property DeepLink. 
        /// <para>
        /// A deep link to the SSM runbook execution page in the AWS Management Console for this
        /// resource, with the execution parameters prefilled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DeepLink { get; set; }

        /// <summary>
        /// Checks to see if the DeepLink property is set.
        /// </summary>
        internal bool IsSetDeepLink() => this.DeepLink != null;
    }
}
