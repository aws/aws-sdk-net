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
    /// Container for the parameters to the GetTrustedAccessProgramAccountEnrollment operation.
    /// Gets the calling account's stored enrollment setting for a trusted access program.
    /// The account is derived from the authenticated caller. Use GetTrustedAccessProgram
    /// to retrieve the resolved participation status, including organization inheritance.
    /// If no enrollment is stored, returns inherit without timestamps.
    /// </summary>
    public partial class GetTrustedAccessProgramAccountEnrollmentRequest : AmazonBedrockRequest
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
    }
}
