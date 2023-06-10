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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkloadShare operation.
    /// Create a workload share.
    /// 
    ///  
    /// <para>
    /// The owner of a workload can share it with other Amazon Web Services accounts and users
    /// in the same Amazon Web Services Region. Shared access to a workload is not removed
    /// until the workload invitation is deleted.
    /// </para>
    ///  
    /// <para>
    /// If you share a workload with an organization or OU, all accounts in the organization
    /// or OU are granted access to the workload.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/workloads-sharing.html">Sharing
    /// a workload</a> in the <i>Well-Architected Tool User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateWorkloadShareRequest : AmazonWellArchitectedRequest
    {
        private string _clientRequestToken;
        private PermissionType _permissionType;
        private string _sharedWith;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionType.
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionType PermissionType
        {
            get { return this._permissionType; }
            set { this._permissionType = value; }
        }

        // Check to see if PermissionType property is set
        internal bool IsSetPermissionType()
        {
            return this._permissionType != null;
        }

        /// <summary>
        /// Gets and sets the property SharedWith.
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=2048)]
        public string SharedWith
        {
            get { return this._sharedWith; }
            set { this._sharedWith = value; }
        }

        // Check to see if SharedWith property is set
        internal bool IsSetSharedWith()
        {
            return this._sharedWith != null;
        }

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

    }
}