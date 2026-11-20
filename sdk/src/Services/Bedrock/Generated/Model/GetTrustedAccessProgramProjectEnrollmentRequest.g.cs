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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the GetTrustedAccessProgramProjectEnrollment operation.
    /// Gets a named project's stored enrollment setting for a trusted access program. The
    /// project must exist in this Region and be owned by the calling account. Archived projects
    /// remain readable until they expire. Use GetTrustedAccessProgram with projectIdentifier
    /// to retrieve resolved participation, including account and organization inheritance.
    /// If no enrollment is stored, returns inherit without timestamps.
    /// </summary>
    public partial class GetTrustedAccessProgramProjectEnrollmentRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ProgramIdentifier. 
        /// <para>
        /// The identifier of the trusted access program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 115)]
        public string ProgramIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProgramIdentifier property is set.
        /// </summary>
        internal bool IsSetProgramIdentifier() => this.ProgramIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The id or ARN of the named Bedrock project. The default project is not supported;
        /// use GetTrustedAccessProgramAccountEnrollment for account-level enrollment. An ARN
        /// from another account, Region, or partition returns ValidationException. A project
        /// that does not exist in the calling account returns ResourceNotFoundException.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;
    }
}
