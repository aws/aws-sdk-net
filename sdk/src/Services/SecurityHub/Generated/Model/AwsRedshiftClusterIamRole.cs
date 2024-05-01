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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An IAM role that the cluster can use to access other Amazon Web Services services.
    /// </summary>
    public partial class AwsRedshiftClusterIamRole
    {
        private string _applyStatus;
        private string _iamRoleArn;

        /// <summary>
        /// Gets and sets the property ApplyStatus. 
        /// <para>
        /// The status of the IAM role's association with the cluster.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>in-sync</c> | <c>adding</c> | <c>removing</c> 
        /// </para>
        /// </summary>
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
        /// The ARN of the IAM role.
        /// </para>
        /// </summary>
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