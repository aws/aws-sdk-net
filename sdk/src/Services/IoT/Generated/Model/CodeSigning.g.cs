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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes the method to use when code signing a file.
    /// </summary>
    public partial class CodeSigning
    {
        /// <summary>
        /// Gets and sets the property AwsSignerJobId. 
        /// <para>
        /// The ID of the <c>AWSSignerJob</c> which was created to sign the file.
        /// </para>
        /// </summary>
        public string AwsSignerJobId { get; set; }

        /// <summary>
        /// Checks to see if the AwsSignerJobId property is set.
        /// </summary>
        internal bool IsSetAwsSignerJobId() => this.AwsSignerJobId != null;

        /// <summary>
        /// Gets and sets the property CustomCodeSigning. 
        /// <para>
        /// A custom method for code signing a file.
        /// </para>
        /// </summary>
        public CustomCodeSigning CustomCodeSigning { get; set; }

        /// <summary>
        /// Checks to see if the CustomCodeSigning property is set.
        /// </summary>
        internal bool IsSetCustomCodeSigning() => this.CustomCodeSigning != null;

        /// <summary>
        /// Gets and sets the property StartSigningJobParameter. 
        /// <para>
        /// Describes the code-signing job.
        /// </para>
        /// </summary>
        public StartSigningJobParameter StartSigningJobParameter { get; set; }

        /// <summary>
        /// Checks to see if the StartSigningJobParameter property is set.
        /// </summary>
        internal bool IsSetStartSigningJobParameter() => this.StartSigningJobParameter != null;
    }
}
