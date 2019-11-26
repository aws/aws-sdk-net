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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIAMPolicyAssignment operation.
    /// Creates an assignment with one specified IAM policy Amazon Resource Name (ARN) and
    /// will assigned to specified groups or users of QuickSight. Users and groups need to
    /// be in the same namespace.
    /// </summary>
    public partial class CreateIAMPolicyAssignmentRequest : AmazonQuickSightRequest
    {
        private string _assignmentName;
        private AssignmentStatus _assignmentStatus;
        private string _awsAccountId;
        private Dictionary<string, List<string>> _identities = new Dictionary<string, List<string>>();
        private string _awsNamespace;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property AssignmentName. 
        /// <para>
        /// The name of the assignment. It must be unique within an AWS account.
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
        /// The status of an assignment:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ENABLED - Anything specified in this assignment is used while creating the data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISABLED - This assignment isn't used while creating the data source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DRAFT - Assignment is an unfinished draft and isn't used while creating the data source.
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
        /// The AWS Account ID where you want to assign QuickSight users or groups to an IAM policy.
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
        /// QuickSight users and/or groups that you want to assign the policy to.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Identities
        {
            get { return this._identities; }
            set { this._identities = value; }
        }

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this._identities != null && this._identities.Count > 0; 
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
        /// An IAM policy Amazon Resource Name (ARN) that you want to apply to the QuickSight
        /// users and groups specified in this assignment.
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