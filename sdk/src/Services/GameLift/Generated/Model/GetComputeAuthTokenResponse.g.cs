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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the GetComputeAuthToken operation.
    /// </summary>
    public partial class GetComputeAuthTokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// A valid temporary authentication token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to an Amazon GameLift Servers compute resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::compute/compute-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ComputeArn { get; set; }

        /// <summary>
        /// Checks to see if the ComputeArn property is set.
        /// </summary>
        internal bool IsSetComputeArn() => this.ComputeArn != null;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// The name of the compute resource that the authentication token is issued to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ComputeName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeName property is set.
        /// </summary>
        internal bool IsSetComputeName() => this.ComputeName != null;

        /// <summary>
        /// Gets and sets the property ExpirationTimestamp. 
        /// <para>
        /// The amount of time until the authentication token is no longer valid.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTimestamp property is set.
        /// </summary>
        internal bool IsSetExpirationTimestamp() => this.ExpirationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers fleet resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetArn { get; set; }

        /// <summary>
        /// Checks to see if the FleetArn property is set.
        /// </summary>
        internal bool IsSetFleetArn() => this.FleetArn != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the compute is registered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;
    }
}
