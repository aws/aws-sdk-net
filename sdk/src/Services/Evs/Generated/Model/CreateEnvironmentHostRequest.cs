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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironmentHost operation.
    /// Creates an ESXi host and adds it to an Amazon EVS environment. Amazon EVS supports
    /// 4-16 hosts per environment.
    /// 
    ///  
    /// <para>
    /// This action can only be used after the Amazon EVS environment is deployed.
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>dedicatedHostId</c> parameter to specify an Amazon EC2 Dedicated
    /// Host for ESXi host creation.
    /// </para>
    ///  
    /// <para>
    ///  You can use the <c>placementGroupId</c> parameter to specify a cluster or partition
    /// placement group to launch EC2 instances into.
    /// </para>
    ///  <note> 
    /// <para>
    /// You cannot use the <c>dedicatedHostId</c> and <c>placementGroupId</c> parameters together
    /// in the same <c>CreateEnvironmentHost</c> action. This results in a <c>ValidationException</c>
    /// response.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateEnvironmentHostRequest : AmazonEvsRequest
    {
        private string _clientToken;
        private string _environmentId;
        private HostInfoForCreate _host;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// <note> 
        /// <para>
        /// This parameter is not used in Amazon EVS currently. If you supply input for this parameter,
        /// it will have no effect.
        /// </para>
        ///  </note> 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the host creation request. If you do not specify a client token, a randomly generated
        /// token is used for the request to ensure idempotency.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment that the host is added to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The host that is created and added to the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HostInfoForCreate Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

    }
}