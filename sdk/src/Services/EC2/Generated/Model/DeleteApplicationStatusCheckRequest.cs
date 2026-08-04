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
    /// Container for the parameters to the DeleteApplicationStatusCheck operation.
    /// Deletes an application status check. The following rules apply:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Deleting a check automatically removes all of its associations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>DescribeApplicationStatusChecks</c> to view existing checks before deleting.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteApplicationStatusCheckRequest : AmazonEC2Request
    {
        private string _applicationStatusCheckId;
        private string _clientToken;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationStatusCheckId
        {
            get { return this._applicationStatusCheckId; }
            set { this._applicationStatusCheckId = value; }
        }

        // Check to see if ApplicationStatusCheckId property is set
        internal bool IsSetApplicationStatusCheckId()
        {
            return this._applicationStatusCheckId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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