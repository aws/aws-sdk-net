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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRole operation.
    /// Updates the description or maximum session duration setting of a role.
    /// </summary>
    public partial class UpdateRoleRequest : AmazonIdentityManagementServiceRequest
    {
        private string _description;
        private int? _maxSessionDuration;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description that you want to apply to the specified role.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSessionDuration. 
        /// <para>
        /// The maximum session duration (in seconds) that you want to set for the specified role.
        /// If you do not specify a value for this setting, the default value of one hour is applied.
        /// This setting can have a value from 1 hour to 12 hours.
        /// </para>
        ///  
        /// <para>
        /// Anyone who assumes the role from the CLI or API can use the <c>DurationSeconds</c>
        /// API parameter or the <c>duration-seconds</c> CLI parameter to request a longer session.
        /// The <c>MaxSessionDuration</c> setting determines the maximum duration that can be
        /// requested using the <c>DurationSeconds</c> parameter. If users don't specify a value
        /// for the <c>DurationSeconds</c> parameter, their security credentials are valid for
        /// one hour by default. This applies when you use the <c>AssumeRole*</c> API operations
        /// or the <c>assume-role*</c> CLI operations but does not apply when you use those operations
        /// to create a console URL. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use.html">Using
        /// IAM roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// IAM role credentials provided by Amazon EC2 instances assigned to the role are not
        /// subject to the specified maximum session duration.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=3600, Max=43200)]
        public int? MaxSessionDuration
        {
            get { return this._maxSessionDuration; }
            set { this._maxSessionDuration = value; }
        }

        // Check to see if MaxSessionDuration property is set
        internal bool IsSetMaxSessionDuration()
        {
            return this._maxSessionDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role that you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}