/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Describes an AWS Identity and Access Management (IAM) role that is associated with
    /// a DB cluster.
    /// </summary>
    public partial class DBClusterRole
    {
        private string _roleArn;
        private string _status;

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
        ///  <code>ACTIVE</code> - the IAM role ARN is associated with the DB cluster and can
        /// be used to access other AWS services on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code> - the IAM role ARN is being associated with the DB cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INVALID</code> - the IAM role ARN is associated with the DB cluster, but the
        /// DB cluster is unable to assume the IAM role in order to access other AWS services
        /// on your behalf.
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