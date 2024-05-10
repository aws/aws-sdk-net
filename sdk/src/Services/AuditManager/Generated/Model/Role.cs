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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The wrapper that contains the Audit Manager role information of the current user.
    /// This includes the role type and IAM Amazon Resource Name (ARN).
    /// </summary>
    public partial class Role
    {
        private string _roleArn;
        private RoleType _roleType;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property RoleType. 
        /// <para>
        ///  The type of customer persona. 
        /// </para>
        ///  <note> 
        /// <para>
        /// In <c>CreateAssessment</c>, <c>roleType</c> can only be <c>PROCESS_OWNER</c>. 
        /// </para>
        ///  
        /// <para>
        /// In <c>UpdateSettings</c>, <c>roleType</c> can only be <c>PROCESS_OWNER</c>.
        /// </para>
        ///  
        /// <para>
        /// In <c>BatchCreateDelegationByAssessment</c>, <c>roleType</c> can only be <c>RESOURCE_OWNER</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoleType RoleType
        {
            get { return this._roleType; }
            set { this._roleType = value; }
        }

        // Check to see if RoleType property is set
        internal bool IsSetRoleType()
        {
            return this._roleType != null;
        }

    }
}