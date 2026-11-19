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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateRole operation. Updates the description,
    /// maximum session duration, or maximum sign-in session duration of a role. You cannot
    /// change the maximum sign-in session duration of a service-linked role.
    /// </summary>
    public partial class UpdateRoleRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description that you want to apply to the specified role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        [AWSProperty(Min = 3600, Max = 43200)]
        public int? MaxSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxSessionDuration property is set.
        /// </summary>
        internal bool IsSetMaxSessionDuration() => this.MaxSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property MaxSigninSessionDuration. 
        /// <para>
        /// The maximum duration (in seconds) of an Amazon Web Services Sign-In session for users
        /// who sign in with the specified role. This setting can have a value from 1 hour (3600
        /// seconds) to 90 days (7776000 seconds), inclusive, and replaces any value currently
        /// configured for the role. This setting is independent of <c>MaxSessionDuration</c>.
        /// </para>
        ///  
        /// <para>
        /// If you omit both this parameter and <c>ResetMaxSigninSessionDuration</c>, the current
        /// setting is unchanged. You cannot specify this parameter and set <c>ResetMaxSigninSessionDuration</c>
        /// to <c>true</c> in the same request.
        /// </para>
        ///  
        /// <para>
        /// Changes to this setting apply to new sign-in sessions. Sessions that are already established
        /// are not affected.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot set this value on a service-linked role.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 3600, Max = 7776000)]
        public int? MaxSigninSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxSigninSessionDuration property is set.
        /// </summary>
        internal bool IsSetMaxSigninSessionDuration() => this.MaxSigninSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property ResetMaxSigninSessionDuration. 
        /// <para>
        /// Specifies whether to clear the role's maximum sign-in session duration. Set this value
        /// to <c>true</c> to return the setting to its unset state, so that the existing sign-in
        /// session behavior applies. When the setting is unset, the role's <c>MaxSigninSessionDuration</c>
        /// is omitted from responses.
        /// </para>
        ///  
        /// <para>
        /// If you set this value to <c>false</c> or omit it, the current setting is not cleared.
        /// You cannot set this value to <c>true</c> and specify <c>MaxSigninSessionDuration</c>
        /// in the same request. Clearing a setting that is already unset has no effect.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot reset this value on a service-linked role.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ResetMaxSigninSessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the ResetMaxSigninSessionDuration property is set.
        /// </summary>
        internal bool IsSetResetMaxSigninSessionDuration() => this.ResetMaxSigninSessionDuration.HasValue;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role that you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;
    }
}
