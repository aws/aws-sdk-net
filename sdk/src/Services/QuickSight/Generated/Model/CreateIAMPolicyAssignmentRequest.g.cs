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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateIAMPolicyAssignment operation. Creates an
    /// assignment with one specified IAM policy, identified by its Amazon Resource Name (ARN).
    /// This policy assignment is attached to the specified groups or users of Amazon Quick
    /// Sight. Assignment names are unique per Amazon Web Services account. To avoid overwriting
    /// rules in other namespaces, use assignment names that are unique.
    /// </summary>
    public partial class CreateIAMPolicyAssignmentRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AssignmentName. 
        /// <para>
        /// The name of the assignment, also called a rule. The name must be unique within the
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string AssignmentName { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentName property is set.
        /// </summary>
        internal bool IsSetAssignmentName() => this.AssignmentName != null;

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
        [AWSProperty(Required = true)]
        public AssignmentStatus AssignmentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssignmentStatus property is set.
        /// </summary>
        internal bool IsSetAssignmentStatus() => this.AssignmentStatus != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you want to assign an IAM policy to
        /// Amazon Quick Sight users or groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Identities. 
        /// <para>
        /// The Amazon Quick Sight users, groups, or both that you want to assign the policy to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Identities { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Identities property is set.
        /// </summary>
        internal bool IsSetIdentities() => this.Identities != null && (this.Identities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace that contains the assignment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The ARN for the IAM policy to apply to the Amazon Quick Sight users and groups specified
        /// in this assignment.
        /// </para>
        /// </summary>
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;
    }
}
