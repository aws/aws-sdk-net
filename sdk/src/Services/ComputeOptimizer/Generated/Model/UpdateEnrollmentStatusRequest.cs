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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnrollmentStatus operation.
    /// Updates the enrollment (opt in and opt out) status of an account to the Compute Optimizer
    /// service.
    /// 
    ///  
    /// <para>
    /// If the account is a management account of an organization, this action can also be
    /// used to enroll member accounts of the organization.
    /// </para>
    ///  
    /// <para>
    /// You must have the appropriate permissions to opt in to Compute Optimizer, to view
    /// its recommendations, and to opt out. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/security-iam.html">Controlling
    /// access with Amazon Web Services Identity and Access Management</a> in the <i>Compute
    /// Optimizer User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When you opt in, Compute Optimizer automatically creates a service-linked role in
    /// your account to access its data. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/using-service-linked-roles.html">Using
    /// Service-Linked Roles for Compute Optimizer</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateEnrollmentStatusRequest : AmazonComputeOptimizerRequest
    {
        private bool? _includeMemberAccounts;
        private Status _status;

        /// <summary>
        /// Gets and sets the property IncludeMemberAccounts. 
        /// <para>
        /// Indicates whether to enroll member accounts of the organization if the account is
        /// the management account of an organization.
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
        /// The new enrollment status of the account.
        /// </para>
        ///  
        /// <para>
        /// The following status options are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c> - Opts in your account to the Compute Optimizer service. Compute Optimizer
        /// begins analyzing the configuration and utilization metrics of your Amazon Web Services
        /// resources after you opt in. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html">Metrics
        /// analyzed by Compute Optimizer</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Inactive</c> - Opts out your account from the Compute Optimizer service. Your
        /// account's recommendations and related metrics data will be deleted from Compute Optimizer
        /// after you opt out.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Pending</c> and <c>Failed</c> options cannot be used to update the enrollment
        /// status of an account. They are returned in the response of a request to update the
        /// enrollment status of an account.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
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