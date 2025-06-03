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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The metadata for an Amazon EKS pod where an Amazon ECR image is in use.
    /// </summary>
    public partial class AwsEksMetadataDetails
    {
        private string _awsNamespace;
        private List<AwsEksWorkloadInfo> _workloadInfoList = AWSConfigs.InitializeCollections ? new List<AwsEksWorkloadInfo>() : null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace for an Amazon EKS cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadInfoList. 
        /// <para>
        /// The list of workloads.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AwsEksWorkloadInfo> WorkloadInfoList
        {
            get { return this._workloadInfoList; }
            set { this._workloadInfoList = value; }
        }

        // Check to see if WorkloadInfoList property is set
        internal bool IsSetWorkloadInfoList()
        {
            return this._workloadInfoList != null && (this._workloadInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}