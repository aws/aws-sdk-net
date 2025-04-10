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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWebACL operation.
    /// Deletes the specified <a>WebACL</a>. 
    /// 
    ///  
    /// <para>
    /// You can only use this if <c>ManagedByFirewallManager</c> is false in the web ACL.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// Before deleting any web ACL, first disassociate it from all resources.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To retrieve a list of the resources that are associated with a web ACL, use the following
    /// calls:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For Amazon CloudFront distributions, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
    /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
    /// in the <i>Amazon CloudFront API Reference</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For all other resources, call <a>ListResourcesForWebACL</a>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// To disassociate a resource from a web ACL, use the following calls:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For Amazon CloudFront distributions, provide an empty web ACL ID in the CloudFront
    /// call <c>UpdateDistribution</c>. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
    /// in the <i>Amazon CloudFront API Reference</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For all other resources, call <a>DisassociateWebACL</a>.
    /// </para>
    ///  </li> </ul> </li> </ul> </note>
    /// </summary>
    public partial class DeleteWebACLRequest : AmazonWAFV2Request
    {
        private string _id;
        private string _lockToken;
        private string _name;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the web ACL. This ID is returned in the responses to create
        /// and list commands. You provide it to operations like update and delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string LockToken
        {
            get { return this._lockToken; }
            set { this._lockToken = value; }
        }

        // Check to see if LockToken property is set
        internal bool IsSetLockToken()
        {
            return this._lockToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the web ACL. You cannot change the name of a web ACL after you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}