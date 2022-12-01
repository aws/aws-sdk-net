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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the GetComputeAuthToken operation.
    /// </summary>
    public partial class GetComputeAuthTokenResponse : AmazonWebServiceResponse
    {
        private string _authToken;
        private string _computeArn;
        private string _computeName;
        private DateTime? _expirationTimestamp;
        private string _fleetArn;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The authorization token that your game server uses to authenticate with GameLift.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AuthToken
        {
            get { return this._authToken; }
            set { this._authToken = value; }
        }

        // Check to see if AuthToken property is set
        internal bool IsSetAuthToken()
        {
            return this._authToken != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a GameLift compute resource and uniquely identifies it. ARNs are
        /// unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::compute/compute-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ComputeArn
        {
            get { return this._computeArn; }
            set { this._computeArn = value; }
        }

        // Check to see if ComputeArn property is set
        internal bool IsSetComputeArn()
        {
            return this._computeArn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// The name of the compute resource you are requesting the authorization token for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ComputeName
        {
            get { return this._computeName; }
            set { this._computeName = value; }
        }

        // Check to see if ComputeName property is set
        internal bool IsSetComputeName()
        {
            return this._computeName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationTimestamp. 
        /// <para>
        /// The amount of time until the authorization token is no longer valid. To continue using
        /// the compute resource for game server hosting, renew the authorization token by using
        /// this operation again.
        /// </para>
        /// </summary>
        public DateTime ExpirationTimestamp
        {
            get { return this._expirationTimestamp.GetValueOrDefault(); }
            set { this._expirationTimestamp = value; }
        }

        // Check to see if ExpirationTimestamp property is set
        internal bool IsSetExpirationTimestamp()
        {
            return this._expirationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a GameLift fleet resource and uniquely identifies it. ARNs are
        /// unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::fleet/fleet-a1234567-b8c9-0d1e-2fa3-b45c6d7e8912</code>.
        /// </para>
        /// </summary>
        public string FleetArn
        {
            get { return this._fleetArn; }
            set { this._fleetArn = value; }
        }

        // Check to see if FleetArn property is set
        internal bool IsSetFleetArn()
        {
            return this._fleetArn != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the compute is registered to.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

    }
}