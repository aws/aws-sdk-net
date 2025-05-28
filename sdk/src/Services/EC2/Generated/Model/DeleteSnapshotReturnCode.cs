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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The snapshot ID and its deletion result code.
    /// </summary>
    public partial class DeleteSnapshotReturnCode
    {
        private SnapshotReturnCodes _returnCode;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property ReturnCode. 
        /// <para>
        /// The result code from the snapshot deletion attempt. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>success</c> - The snapshot was successfully deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>skipped</c> - The snapshot was not deleted because it's associated with other
        /// AMIs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>missing-permissions</c> - The snapshot was not deleted because the role lacks
        /// <c>DeleteSnapshot</c> permissions. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/security_iam_service-with-iam.html">How
        /// Amazon EBS works with IAM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>internal-error</c> - The snapshot was not deleted due to a server error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>client-error</c> - The snapshot was not deleted due to a client configuration
        /// error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details about an error, check the <c>DeleteSnapshot</c> event in the CloudTrail
        /// event history. For more information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/tutorial-event-history.html">View
        /// event history</a> in the <i>Amazon Web Services CloudTrail User Guide</i>.
        /// </para>
        /// </summary>
        public SnapshotReturnCodes ReturnCode
        {
            get { return this._returnCode; }
            set { this._returnCode = value; }
        }

        // Check to see if ReturnCode property is set
        internal bool IsSetReturnCode()
        {
            return this._returnCode != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}