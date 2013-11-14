/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Lists the virtual MFA devices under the AWS account by assignment status. If you do not specify an assignment status, the action
    /// returns a list of all virtual MFA devices. Assignment status can be <c>Assigned</c> ,
    /// <c>Unassigned</c> , or <c>Any</c> . </para> <para>You can paginate the results using the <c>MaxItems</c> and
    /// <c>Marker</c> parameters.</para>
    /// </summary>
    public partial class ListVirtualMFADevicesRequest : AmazonIdentityManagementServiceRequest
    {
        private AssignmentStatusType assignmentStatus;
        private string marker;
        private int? maxItems;


        /// <summary>
        /// The status (unassigned or assigned) of the devices to list. If you do not specify an <c>AssignmentStatus</c>, the action defaults to
        /// <c>Any</c> which lists both assigned and unassigned virtual MFA devices.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Assigned, Unassigned, Any</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public AssignmentStatusType AssignmentStatus
        {
            get { return this.assignmentStatus; }
            set { this.assignmentStatus = value; }
        }

        // Check to see if AssignmentStatus property is set
        internal bool IsSetAssignmentStatus()
        {
            return this.assignmentStatus != null;
        }

        /// <summary>
        /// Use this parameter only when paginating results, and only in a subsequent request after you've received a response where the results are
        /// truncated. Set it to the value of the <c>Marker</c> element in the response you just received.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 320</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// Use this parameter only when paginating results to indicate the maximum number of user names you want in the response. If there are
        /// additional user names beyond the maximum you specify, the <c>IsTruncated</c> response element is <c>true</c>. This parameter is optional. If
        /// you do not include it, it defaults to 100.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this.maxItems ?? default(int); }
            set { this.maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems.HasValue;
        }

    }
}
    
