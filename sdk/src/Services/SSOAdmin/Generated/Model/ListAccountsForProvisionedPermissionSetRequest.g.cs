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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListAccountsForProvisionedPermissionSet operation.
    /// Lists all the Amazon Web Services accounts where the specified permission set is provisioned.
    /// </summary>
    public partial class ListAccountsForProvisionedPermissionSetRequest : AmazonSSOAdminRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the IAM Identity Center instance under which the operation will be executed.
        /// For more information about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to display for the <a>PermissionSet</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the list API. Initially the value is null. Use the output
        /// of previous API calls to make subsequent calls.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PermissionSetArn. 
        /// <para>
        /// The ARN of the <a>PermissionSet</a> from which the associated Amazon Web Services
        /// accounts will be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string PermissionSetArn { get; set; }

        /// <summary>
        /// Checks to see if the PermissionSetArn property is set.
        /// </summary>
        internal bool IsSetPermissionSetArn() => this.PermissionSetArn != null;

        /// <summary>
        /// Gets and sets the property ProvisioningStatus. 
        /// <para>
        /// The permission set provisioning status for an Amazon Web Services account.
        /// </para>
        /// </summary>
        public ProvisioningStatus ProvisioningStatus { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningStatus property is set.
        /// </summary>
        internal bool IsSetProvisioningStatus() => this.ProvisioningStatus != null;
    }
}
