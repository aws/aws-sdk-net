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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStackInstance operation. Returns the stack
    /// instance that's associated with the specified StackSet, Amazon Web Services account,
    /// and Amazon Web Services Region. <para> For a list of stack instances that are associated
    /// with a specific StackSet, use <a>ListStackInstances</a>. </para>
    /// </summary>
    public partial class DescribeStackInstanceRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs { get; set; }

        /// <summary>
        /// Checks to see if the CallAs property is set.
        /// </summary>
        internal bool IsSetCallAs() => this.CallAs != null;

        /// <summary>
        /// Gets and sets the property StackInstanceAccount. 
        /// <para>
        /// The ID of an Amazon Web Services account that's associated with this stack instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackInstanceAccount { get; set; }

        /// <summary>
        /// Checks to see if the StackInstanceAccount property is set.
        /// </summary>
        internal bool IsSetStackInstanceAccount() => this.StackInstanceAccount != null;

        /// <summary>
        /// Gets and sets the property StackInstanceRegion. 
        /// <para>
        /// The name of a Region that's associated with this stack instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackInstanceRegion { get; set; }

        /// <summary>
        /// Checks to see if the StackInstanceRegion property is set.
        /// </summary>
        internal bool IsSetStackInstanceRegion() => this.StackInstanceRegion != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or the unique stack ID of the StackSet that you want to get stack instance
        /// information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;
    }
}
