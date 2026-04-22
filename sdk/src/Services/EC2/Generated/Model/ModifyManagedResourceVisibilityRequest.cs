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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyManagedResourceVisibility operation.
    /// Modifies the managed resource visibility configuration for the account. Use this operation
    /// to control whether managed resources are hidden or visible by default. Visibility
    /// settings are account-wide and affect all IAM principals uniformly. Hidden resources
    /// remain fully operational and billable.
    /// </summary>
    public partial class ModifyManagedResourceVisibilityRequest : AmazonEC2Request
    {
        private ManagedResourceDefaultVisibility _defaultVisibility;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property DefaultVisibility. 
        /// <para>
        /// The default visibility setting for managed resources. Valid values: <c>hidden</c>
        /// | <c>visible</c>.
        /// </para>
        /// </summary>
        public ManagedResourceDefaultVisibility DefaultVisibility
        {
            get { return this._defaultVisibility; }
            set { this._defaultVisibility = value; }
        }

        // Check to see if DefaultVisibility property is set
        internal bool IsSetDefaultVisibility()
        {
            return this._defaultVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

    }
}