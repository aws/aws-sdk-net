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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyActivityStream operation.
    /// Changes the audit policy state of a database activity stream to either locked (default)
    /// or unlocked. A locked policy is read-only, whereas an unlocked policy is read/write.
    /// If your activity stream is started and locked, you can unlock it, customize your audit
    /// policy, and then lock your activity stream. Restarting the activity stream isn't required.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/DBActivityStreams.Modifying.html">
    /// Modifying a database activity stream</a> in the <i>Amazon RDS User Guide</i>. 
    /// 
    ///  
    /// <para>
    /// This operation is supported for RDS for Oracle and Microsoft SQL Server.
    /// </para>
    /// </summary>
    public partial class ModifyActivityStreamRequest : AmazonRDSRequest
    {
        private AuditPolicyState _auditPolicyState;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property AuditPolicyState. 
        /// <para>
        /// The audit policy state. When a policy is unlocked, it is read/write. When it is locked,
        /// it is read-only. You can edit your audit policy only when the activity stream is unlocked
        /// or stopped.
        /// </para>
        /// </summary>
        public AuditPolicyState AuditPolicyState
        {
            get { return this._auditPolicyState; }
            set { this._auditPolicyState = value; }
        }

        // Check to see if AuditPolicyState property is set
        internal bool IsSetAuditPolicyState()
        {
            return this._auditPolicyState != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RDS for Oracle or Microsoft SQL Server DB instance.
        /// For example, <code>arn:aws:rds:us-east-1:12345667890:instance:my-orcl-db</code>.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}