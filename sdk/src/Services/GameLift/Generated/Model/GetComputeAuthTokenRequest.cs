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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the GetComputeAuthToken operation.
    /// Requests an authentication token from Amazon GameLift for a compute resource in an
    /// Amazon GameLift Anywhere fleet or container fleet. Game servers that are running on
    /// the compute use this token to communicate with the Amazon GameLift service, such as
    /// when calling the Amazon GameLift server SDK action <c>InitSDK()</c>. Authentication
    /// tokens are valid for a limited time span, so you need to request a fresh token before
    /// the current token expires.
    /// 
    ///  
    /// <para>
    /// Use this operation based on the fleet compute type:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <c>EC2</c> fleets, auth token retrieval and refresh is handled automatically.
    /// All game servers that are running on all fleet instances have access to a valid auth
    /// token.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <c>ANYWHERE</c> and <c>CONTAINER</c> fleets, if you're using the Amazon GameLift
    /// Agent, auth token retrieval and refresh is handled automatically for any container
    /// or Anywhere compute where the Agent is running. If you're not using the Agent, create
    /// a mechanism to retrieve and refresh auth tokens for computes that are running game
    /// server processes. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-anywhere.html">Create
    /// an Anywhere fleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-testing.html">Test
    /// your integration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk.html">Server
    /// SDK reference guides</a> (for version 5.x)
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetComputeAuthTokenRequest : AmazonGameLiftRequest
    {
        private string _computeName;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// The name of the compute resource you are requesting the authentication token for.
        /// For an Anywhere fleet compute, use the registered compute name. For an EC2 fleet instance,
        /// use the instance ID. For a container fleet, use the compute name (for example, <c>a123b456c789012d3e4567f8a901b23c/1a234b56-7cd8-9e0f-a1b2-c34d567ef8a9</c>)
        /// or the compute ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet that the compute is registered to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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