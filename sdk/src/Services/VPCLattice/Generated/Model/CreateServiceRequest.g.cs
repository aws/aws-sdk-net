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
    /// Container for the parameters to the CreateService operation. Creates a service. A
    /// service is any software application that can run on instances containers, or serverless
    /// functions within an account or virtual private cloud (VPC). <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/services.html">Services</a>
    /// in the <i>Amazon VPC Lattice User Guide</i>. </para>
    /// </summary>
    public partial class CreateServiceRequest : AmazonVPCLatticeRequest
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token and parameters, the retry succeeds without performing any actions. If the parameters
        /// aren't identical, the retry fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service. The name must be unique within the account. The valid characters
        /// are a-z, 0-9, and hyphens (-). You can't use a hyphen as the first or last character,
        /// or immediately after another hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 40)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
