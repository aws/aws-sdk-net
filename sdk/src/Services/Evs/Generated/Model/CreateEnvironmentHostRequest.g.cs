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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironmentHost operation. Creates an ESX
    /// host and adds it to an Amazon EVS environment. <para> This action can only be used
    /// after the Amazon EVS environment is deployed. </para> <para> You can use the <c>dedicatedHostId</c>
    /// parameter to specify an Amazon EC2 Dedicated Host for ESX host creation. </para> <para>
    /// You can use the <c>placementGroupId</c> parameter to specify a cluster or partition
    /// placement group to launch EC2 instances into. </para> <note> <para> If you don't specify
    /// an ESX version when adding hosts using <c>CreateEnvironmentHost</c> action, Amazon
    /// EVS automatically uses the default ESX version for your environment's VCF version.
    /// To find the available ESX versions for a particular VCF version, use the <c>GetVersions</c>
    /// action. </para> <para> You cannot use the <c>dedicatedHostId</c> and <c>placementGroupId</c>
    /// parameters together in the same <c>CreateEnvironmentHost</c> action. This results
    /// in a <c>ValidationException</c> response. </para> </note>
    /// </summary>
    public partial class CreateEnvironmentHostRequest : AmazonEvsRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. <note> 
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
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique ID for the environment that the host is added to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EsxVersion. 
        /// <para>
        /// The ESX version to use for the host.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string EsxVersion { get; set; }

        /// <summary>
        /// Checks to see if the EsxVersion property is set.
        /// </summary>
        internal bool IsSetEsxVersion() => this.EsxVersion != null;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The host that is created and added to the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HostInfoForCreate Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;
    }
}
