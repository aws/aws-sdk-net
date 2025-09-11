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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Parameters for Amazon Athena.
    /// </summary>
    public partial class AthenaParameters
    {
        private IdentityCenterConfiguration _identityCenterConfiguration;
        private string _roleArn;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// An optional parameter that configures IAM Identity Center authentication to grant
        /// QuickSight access to your workgroup.
        /// </para>
        ///  
        /// <para>
        /// This parameter can only be specified if your QuickSight account is configured with
        /// IAM Identity Center.
        /// </para>
        /// </summary>
        public IdentityCenterConfiguration IdentityCenterConfiguration
        {
            get { return this._identityCenterConfiguration; }
            set { this._identityCenterConfiguration = value; }
        }

        // Check to see if IdentityCenterConfiguration property is set
        internal bool IsSetIdentityCenterConfiguration()
        {
            return this._identityCenterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Use the <c>RoleArn</c> structure to override an account-wide role for a specific Athena
        /// data source. For example, say an account administrator has turned off all Athena access
        /// with an account-wide role. The administrator can then use <c>RoleArn</c> to bypass
        /// the account-wide role and allow Athena access for the single Athena data source that
        /// is specified in the structure, even if the account-wide role forbidding Athena access
        /// is still active.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The workgroup that Amazon Athena uses.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}