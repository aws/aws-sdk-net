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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the UpdateIAMPolicyAssignment operation.
    /// </summary>
    public partial class UpdateIAMPolicyAssignmentResponse : AmazonWebServiceResponse
    {
        private string _assignmentId;
        private string _assignmentName;
        private AssignmentStatus _assignmentStatus;
        private Dictionary<string, List<string>> _identities = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _policyArn;
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property AssignmentId. 
        /// <para>
        /// The ID of the assignment.
        /// </para>
        /// </summary>
        public string AssignmentId
        {
            get { return this._assignmentId; }
            set { this._assignmentId = value; }
        }

        // Check to see if AssignmentId property is set
        internal bool IsSetAssignmentId()
        {
            return this._assignmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssignmentName. 
        /// <para>
        /// The name of the assignment or rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string AssignmentName
        {
            get { return this._assignmentName; }
            set { this._assignmentName = value; }
        }

        // Check to see if AssignmentName property is set
        internal bool IsSetAssignmentName()
        {
            return this._assignmentName != null;
        }

        /// <summary>
        /// Gets and sets the property AssignmentStatus. 
        /// <para>
        /// The status of the assignment. Possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> - Anything specified in this assignment is used when creating the
        /// data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - This assignment isn't used when creating the data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DRAFT</c> - This assignment is an unfinished draft and isn't used when creating
        /// the data source.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AssignmentStatus AssignmentStatus
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
        /// Gets and sets the property Identities. 
        /// <para>
        /// The QuickSight users, groups, or both that the IAM policy is assigned to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this._identities != null && (this._identities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The ARN for the IAM policy applied to the QuickSight users and groups specified in
        /// this assignment.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}