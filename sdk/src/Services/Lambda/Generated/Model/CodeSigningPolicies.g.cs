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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Code signing configuration <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-codesigning.html#config-codesigning-policies">policies</a>
    /// specify the validation failure action for signature mismatch or expiry.
    /// </summary>
    public partial class CodeSigningPolicies
    {
        /// <summary>
        /// Gets and sets the property UntrustedArtifactOnDeployment. 
        /// <para>
        /// Code signing configuration policy for deployment validation failure. If you set the
        /// policy to <c>Enforce</c>, Lambda blocks the deployment request if signature validation
        /// checks fail. If you set the policy to <c>Warn</c>, Lambda allows the deployment and
        /// issues a new Amazon CloudWatch metric (<c>SignatureValidationErrors</c>) and also
        /// stores the warning in the CloudTrail log.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>Warn</c> 
        /// </para>
        /// </summary>
        public CodeSigningPolicy UntrustedArtifactOnDeployment { get; set; }

        /// <summary>
        /// Checks to see if the UntrustedArtifactOnDeployment property is set.
        /// </summary>
        internal bool IsSetUntrustedArtifactOnDeployment() => this.UntrustedArtifactOnDeployment != null;
    }
}
