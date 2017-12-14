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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A API Gateway VPC link for a <a>RestApi</a> to access resources in an Amazon Virtual
    /// Private Cloud (VPC).
    /// 
    ///  <div class="remarks"> 
    /// <para>
    /// 
    /// <para>
    /// To enable access to a resource in an Amazon Virtual Private Cloud through Amazon API
    /// Gateway, you, as an API developer, create a <a>VpcLink</a> resource targeted for one
    /// or more network load balancers of the VPC and then integrate an API method with a
    /// private integration that uses the <a>VpcLink</a>. The private integration has an integration
    /// type of <code>HTTP</code> or <code>HTTP_PROXY</code> and has a connection type of
    /// <code>VPC_LINK</code>. The integration uses the <code>connectionId</code> property
    /// to identify the <a>VpcLink</a> used.
    /// </para>
    ///  
    /// </para>
    ///  </div>
    /// </summary>
    public partial class UpdateVpcLinkResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _id;
        private string _name;
        private VpcLinkStatus _status;
        private string _statusMessage;
        private List<string> _targetArns = new List<string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the VPC link.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the <a>VpcLink</a>. It is used in an <a>Integration</a> to reference
        /// this <a>VpcLink</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name used to label and identify the VPC link.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VPC link. The valid values are <code>AVAILABLE</code>, <code>PENDING</code>,
        /// <code>DELETING</code>, or <code>FAILED</code>. Deploying an API will wait if the status
        /// is <code>PENDING</code> and will fail if the status is <code>DELETING</code>. 
        /// </para>
        /// </summary>
        public VpcLinkStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A description about the VPC link status.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArns. 
        /// <para>
        /// The ARNs of network load balancers of the VPC targeted by the VPC link. The network
        /// load balancers must be owned by the same AWS account of the API owner.
        /// </para>
        /// </summary>
        public List<string> TargetArns
        {
            get { return this._targetArns; }
            set { this._targetArns = value; }
        }

        // Check to see if TargetArns property is set
        internal bool IsSetTargetArns()
        {
            return this._targetArns != null && this._targetArns.Count > 0; 
        }

    }
}