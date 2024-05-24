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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFargateProfile operation.
    /// Deletes an Fargate profile.
    /// 
    ///  
    /// <para>
    /// When you delete a Fargate profile, any <c>Pod</c> running on Fargate that was created
    /// with the profile is deleted. If the <c>Pod</c> matches another Fargate profile, then
    /// it is scheduled on Fargate with that profile. If it no longer matches any Fargate
    /// profiles, then it's not scheduled on Fargate and may remain in a pending state.
    /// </para>
    ///  
    /// <para>
    /// Only one Fargate profile in a cluster can be in the <c>DELETING</c> status at a time.
    /// You must wait for a Fargate profile to finish deleting before you can delete any other
    /// profiles in that cluster.
    /// </para>
    /// </summary>
    public partial class DeleteFargateProfileRequest : AmazonEKSRequest
    {
        private string _clusterName;
        private string _fargateProfileName;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property FargateProfileName. 
        /// <para>
        /// The name of the Fargate profile to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FargateProfileName
        {
            get { return this._fargateProfileName; }
            set { this._fargateProfileName = value; }
        }

        // Check to see if FargateProfileName property is set
        internal bool IsSetFargateProfileName()
        {
            return this._fargateProfileName != null;
        }

    }
}