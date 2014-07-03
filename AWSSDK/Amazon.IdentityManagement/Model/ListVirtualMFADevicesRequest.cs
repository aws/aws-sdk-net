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
    /// Lists the virtual MFA devices under the AWS account by assignment status. If you
    /// do not            specify an assignment status, the action returns a list of all virtual MFA
    /// devices. Assignment            status can be <code>Assigned</code>, <code>Unassigned</code>,
    /// or <code>Any</code>. 
    /// 
    ///         
    /// <para>
    /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
    /// </para>
    /// </summary>
    public partial class ListVirtualMFADevicesRequest : AmazonWebServiceRequest
    {
        private string _assignmentStatus;
        private string _marker;
        private int? _maxItems;


        /// <summary>
        /// Gets and sets the property AssignmentStatus. 
        /// <para>
        /// The status (unassigned or assigned) of the devices to list. If you do not specify
        /// an                <code>AssignmentStatus</code>, the action defaults to <code>Any</code> which
        /// lists both            assigned and unassigned virtual MFA devices. 
        /// </para>
        /// </summary>
        public string AssignmentStatus
        {
            get { return this._assignmentStatus; }
            set { this._assignmentStatus = value; }
        }


        /// <summary>
        /// Sets the AssignmentStatus property
        /// </summary>
        /// <param name="assignmentStatus">The value to set for the AssignmentStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVirtualMFADevicesRequest WithAssignmentStatus(string assignmentStatus)
        {
            this._assignmentStatus = assignmentStatus;
            return this;
        }

        // Check to see if AssignmentStatus property is set
        internal bool IsSetAssignmentStatus()
        {
            return this._assignmentStatus != null;
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results, and only in a subsequent request
        /// after            you've received a response where the results are truncated. Set it to the
        /// value of the                <code>Marker</code> element in the response you just received.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVirtualMFADevicesRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this parameter only when paginating results to indicate the maximum number of
        /// user names            you want in the response. If there are additional user names beyond the
        /// maximum you specify,            the <code>IsTruncated</code> response element is <code>true</code>.
        /// This parameter is            optional. If you do not include it, it defaults to 100.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }


        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListVirtualMFADevicesRequest WithMaxItems(int maxItems)
        {
            this._maxItems = maxItems;
            return this;
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}