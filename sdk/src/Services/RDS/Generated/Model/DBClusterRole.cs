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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Describes an Amazon Web Services Identity and Access Management (IAM) role that is
    /// associated with a DB cluster.
    /// </summary>
    public partial class DBClusterRole
    {
        private string _featureName;
        private string _roleArn;
        private string _status;

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of the feature associated with the Amazon Web Services Identity and Access
        /// Management (IAM) role. For information about supported feature names, see <a>DBEngineVersion</a>.
        /// </para>
        /// </summary>
        public string FeatureName
        {
            get { return this._featureName; }
            set { this._featureName = value; }
        }

        // Check to see if FeatureName property is set
        internal bool IsSetFeatureName()
        {
            return this._featureName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that is associated with the DB cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the state of association between the IAM role and the DB cluster. The Status
        /// property returns one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - the IAM role ARN is associated with the DB cluster and can be used
        /// to access other Amazon Web Services on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - the IAM role ARN is being associated with the DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID</c> - the IAM role ARN is associated with the DB cluster, but the DB cluster
        /// is unable to assume the IAM role in order to access other Amazon Web Services on your
        /// behalf.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}