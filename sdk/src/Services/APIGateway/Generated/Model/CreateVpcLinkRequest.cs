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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcLink operation.
    /// Creates a VPC link, under the caller's account in a selected region, in an asynchronous
    /// operation that typically takes 2-4 minutes to complete and become operational. The
    /// caller must have permissions to create and update VPC Endpoint services.
    /// </summary>
    public partial class CreateVpcLinkRequest : AmazonAPIGatewayRequest
    {
        private string _description;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
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
        /// Gets and sets the property Name. 
        /// <para>
        /// [Required] The name used to label and identify the VPC link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/]. The tag
        /// key can be up to 128 characters and must not start with <code>aws:</code>. The tag
        /// value can be up to 256 characters.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetArns. 
        /// <para>
        /// [Required] The ARN of the network load balancer of the VPC targeted by the VPC link.
        /// The network load balancer must be owned by the same AWS account of the API owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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