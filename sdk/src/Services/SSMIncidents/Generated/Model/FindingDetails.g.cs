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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Extended textual information about the finding.
    /// </summary>
    public partial class FindingDetails
    {
        /// <summary>
        /// Gets and sets the property CloudFormationStackUpdate. 
        /// <para>
        /// Information about the CloudFormation stack creation or update associated with the
        /// finding.
        /// </para>
        /// </summary>
        public CloudFormationStackUpdate CloudFormationStackUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CloudFormationStackUpdate property is set.
        /// </summary>
        internal bool IsSetCloudFormationStackUpdate() => this.CloudFormationStackUpdate != null;

        /// <summary>
        /// Gets and sets the property CodeDeployDeployment. 
        /// <para>
        /// Information about the CodeDeploy deployment associated with the finding.
        /// </para>
        /// </summary>
        public CodeDeployDeployment CodeDeployDeployment { get; set; }

        /// <summary>
        /// Checks to see if the CodeDeployDeployment property is set.
        /// </summary>
        internal bool IsSetCodeDeployDeployment() => this.CodeDeployDeployment != null;
    }
}
