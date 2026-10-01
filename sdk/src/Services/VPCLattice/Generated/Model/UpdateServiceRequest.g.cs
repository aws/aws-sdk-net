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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateService operation. Updates the specified
    /// service.
    /// </summary>
    public partial class UpdateServiceRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of IAM policy.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: The resource does not use an IAM policy. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_IAM</c>: The resource uses an IAM policy. When this type is used, auth is
        /// enabled and an auth policy is required.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property IdleTimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, that a connection can remain idle (no data sent) before
        /// VPC Lattice closes it. The valid range is 60 to 600 seconds. If you don't specify
        /// a value, the default is 60 seconds. This setting does not change the maximum connection
        /// duration of 10 minutes; connections are still closed when they reach that limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 600)]
        public int? IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetIdleTimeoutSeconds() => this.IdleTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or ARN of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string ServiceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceIdentifier() => this.ServiceIdentifier != null;
    }
}
