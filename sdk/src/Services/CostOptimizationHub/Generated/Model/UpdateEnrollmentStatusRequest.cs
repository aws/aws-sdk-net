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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnrollmentStatus operation.
    /// Updates the enrollment (opt in and opt out) status of an account to the Cost Optimization
    /// Hub service.
    /// 
    ///  
    /// <para>
    /// If the account is a management account or delegated administrator of an organization,
    /// this action can also be used to enroll member accounts of the organization.
    /// </para>
    ///  
    /// <para>
    /// You must have the appropriate permissions to opt in to Cost Optimization Hub and to
    /// view its recommendations. When you opt in, Cost Optimization Hub automatically creates
    /// a service-linked role in your account to access its data.
    /// </para>
    /// </summary>
    public partial class UpdateEnrollmentStatusRequest : AmazonCostOptimizationHubRequest
    {
        private bool? _includeMemberAccounts;
        private EnrollmentStatus _status;

        /// <summary>
        /// Gets and sets the property IncludeMemberAccounts. 
        /// <para>
        /// Indicates whether to enroll member accounts of the organization if the account is
        /// the management account or delegated administrator.
        /// </para>
        /// </summary>
        public bool? IncludeMemberAccounts
        {
            get { return this._includeMemberAccounts; }
            set { this._includeMemberAccounts = value; }
        }

        // Check to see if IncludeMemberAccounts property is set
        internal bool IsSetIncludeMemberAccounts()
        {
            return this._includeMemberAccounts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Sets the account status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrollmentStatus Status
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