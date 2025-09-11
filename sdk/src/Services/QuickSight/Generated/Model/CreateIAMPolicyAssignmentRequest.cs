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
    /// Container for the parameters to the CreateIAMPolicyAssignment operation.
    /// Creates an assignment with one specified IAM policy, identified by its Amazon Resource
    /// Name (ARN). This policy assignment is attached to the specified groups or users of
    /// Amazon QuickSight. Assignment names are unique per Amazon Web Services account. To
    /// avoid overwriting rules in other namespaces, use assignment names that are unique.
    /// </summary>
    public partial class CreateIAMPolicyAssignmentRequest : AmazonQuickSightRequest
    {
        private string _assignmentName;
        private AssignmentStatus _assignmentStatus;
        private string _awsAccountId;
        private Dictionary<string, List<string>> _identities = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _awsNamespace;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property AssignmentName. 
        /// <para>
        /// The name of the assignment, also called a rule. The name must be unique within the
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you want to assign an IAM policy to
        /// QuickSight users or groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// The QuickSight users, groups, or both that you want to assign the policy to.
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace that contains the assignment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The ARN for the IAM policy to apply to the QuickSight users and groups specified in
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

    }
}