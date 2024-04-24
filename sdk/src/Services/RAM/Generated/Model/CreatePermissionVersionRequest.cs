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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
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
namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePermissionVersion operation.
    /// Creates a new version of the specified customer managed permission. The new version
    /// is automatically set as the default version of the customer managed permission. New
    /// resource shares automatically use the default permission. Existing resource shares
    /// continue to use their original permission versions, but you can use <a>ReplacePermissionAssociations</a>
    /// to update them.
    /// 
    ///  
    /// <para>
    /// If the specified customer managed permission already has the maximum of 5 versions,
    /// then you must delete one of the existing versions before you can create a new one.
    /// </para>
    /// </summary>
    public partial class CreatePermissionVersionRequest : AmazonRAMRequest
    {
        private string _clientToken;
        private string _permissionArn;
        private string _policyTemplate;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value.</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotentParameterMismatch</c> error.
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
        /// Gets and sets the property PermissionArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the customer managed permission you're creating a new version
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PermissionArn
        {
            get { return this._permissionArn; }
            set { this._permissionArn = value; }
        }

        // Check to see if PermissionArn property is set
        internal bool IsSetPermissionArn()
        {
            return this._permissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyTemplate. 
        /// <para>
        /// A string in JSON format string that contains the following elements of a resource-based
        /// policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Effect</b>: must be set to <c>ALLOW</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Action</b>: specifies the actions that are allowed by this customer managed permission.
        /// The list must contain only actions that are supported by the specified resource type.
        /// For a list of all actions supported by each resource type, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html">Actions,
        /// resources, and condition keys for Amazon Web Services services</a> in the <i>Identity
        /// and Access Management User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Condition</b>: (optional) specifies conditional parameters that must evaluate
        /// to true when a user attempts an action for that action to be allowed. For more information
        /// about the Condition element, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_condition.html">IAM
        /// policies: Condition element</a> in the <i>Identity and Access Management User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This template can't include either the <c>Resource</c> or <c>Principal</c> elements.
        /// Those are both filled in by RAM when it instantiates the resource-based policy on
        /// each resource shared using this managed permission. The <c>Resource</c> comes from
        /// the ARN of the specific resource that you are sharing. The <c>Principal</c> comes
        /// from the list of identities added to the resource share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyTemplate
        {
            get { return this._policyTemplate; }
            set { this._policyTemplate = value; }
        }

        // Check to see if PolicyTemplate property is set
        internal bool IsSetPolicyTemplate()
        {
            return this._policyTemplate != null;
        }

    }
}