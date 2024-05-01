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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// An Identity and Access Management (IAM) role that can be used by the associated Amazon
    /// Redshift cluster to access other Amazon Web Services services.
    /// </summary>
    public partial class ClusterIamRole
    {
        private string _applyStatus;
        private string _iamRoleArn;

        /// <summary>
        /// Gets and sets the property ApplyStatus. 
        /// <para>
        /// A value that describes the status of the IAM role's association with an Amazon Redshift
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// The following are possible statuses and descriptions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>in-sync</c>: The role is available for use by the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>adding</c>: The role is in the process of being associated with the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>removing</c>: The role is in the process of being disassociated with the cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ApplyStatus
        {
            get { return this._applyStatus; }
            set { this._applyStatus = value; }
        }

        // Check to see if ApplyStatus property is set
        internal bool IsSetApplyStatus()
        {
            return this._applyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role, for example, <c>arn:aws:iam::123456789012:role/RedshiftCopyUnload</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

    }
}