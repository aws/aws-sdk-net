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
    /// Contains the details about a blue/green deployment.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/blue-green-deployments.html">Using
    /// Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon RDS User
    /// Guide</i> and <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/blue-green-deployments.html">
    /// Using Amazon RDS Blue/Green Deployments for database updates</a> in the <i>Amazon
    /// Aurora User Guide</i>.
    /// </para>
    /// </summary>
    public partial class SwitchoverDetail
    {
        private string _sourceMember;
        private string _status;
        private string _targetMember;

        /// <summary>
        /// Gets and sets the property SourceMember. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a resource in the blue environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceMember
        {
            get { return this._sourceMember; }
            set { this._sourceMember = value; }
        }

        // Check to see if SourceMember property is set
        internal bool IsSetSourceMember()
        {
            return this._sourceMember != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The switchover status of a resource in a blue/green deployment.
        /// </para>
        ///  
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>preparing-for-switchover</code> - The resource is being prepared to switch
        /// over.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ready-for-switchover</code> - The resource is ready to switch over.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>switchover-in-progress</code> - The resource is being switched over.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>switchover-completed</code> - The resource has been switched over.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>switchover-failed</code> - The resource attempted to switch over but failed.
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

        /// <summary>
        /// Gets and sets the property TargetMember. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a resource in the green environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string TargetMember
        {
            get { return this._targetMember; }
            set { this._targetMember = value; }
        }

        // Check to see if TargetMember property is set
        internal bool IsSetTargetMember()
        {
            return this._targetMember != null;
        }

    }
}