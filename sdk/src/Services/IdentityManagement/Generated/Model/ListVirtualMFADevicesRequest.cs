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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListVirtualMFADevices operation.
    /// Lists the virtual MFA devices defined in the AWS account by assignment status. If
    /// you do not specify an assignment status, the operation returns a list of all virtual
    /// MFA devices. Assignment status can be <code>Assigned</code>, <code>Unassigned</code>,
    /// or <code>Any</code>.
    /// 
    ///  
    /// <para>
    /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
    /// parameters.
    /// </para>
    /// </summary>
    public partial class ListVirtualMFADevicesRequest : AmazonIdentityManagementServiceRequest
    {
        private AssignmentStatusType _assignmentStatus;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property AssignmentStatus. 
        /// <para>
        ///  The status (<code>Unassigned</code> or <code>Assigned</code>) of the devices to list.
        /// If you do not specify an <code>AssignmentStatus</code>, the operation defaults to
        /// <code>Any</code> which lists both assigned and unassigned virtual MFA devices.
        /// </para>
        /// </summary>
        public AssignmentStatusType AssignmentStatus
        {
            get { return this._assignmentStatus; }
            set { this._assignmentStatus = value; }
        }

        // Check to see if AssignmentStatus property is set
        internal bool IsSetAssignmentStatus()
        {
            return this._assignmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) Use this only when paginating results to indicate the maximum number of
        /// items you want in the response. If additional items exist beyond the maximum you specify,
        /// the <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include this parameter, it defaults to 100. Note that IAM might return
        /// fewer results, even when there are more results available. In that case, the <code>IsTruncated</code>
        /// response element returns <code>true</code> and <code>Marker</code> contains a value
        /// to include in the subsequent call that tells the service where to continue from.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}