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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrafficPolicyVersion operation.
    /// Creates a new version of an existing traffic policy. When you create a new version
    /// of a traffic policy, you specify the ID of the traffic policy that you want to update
    /// and a JSON-formatted document that describes the new version.
    /// 
    ///  
    /// <para>
    /// You use traffic policies to create multiple DNS resource record sets for one domain
    /// name (such as example.com) or one subdomain name (such as www.example.com).
    /// </para>
    ///  
    /// <para>
    /// To create a new version, send a <code>POST</code> request to the <code>/<i>Route 53
    /// API version</i>/trafficpolicy/</code> resource. The request body includes a document
    /// with a <code>CreateTrafficPolicyVersionRequest</code> element. The response returns
    /// the <code>CreateTrafficPolicyVersionResponse</code> element, which contains information
    /// about the new version of the traffic policy.
    /// </para>
    /// </summary>
    public partial class CreateTrafficPolicyVersionRequest : AmazonRoute53Request
    {
        private string _id;
        private string _document;
        private string _comment;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the traffic policy for which you want to create a new version.
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
        /// Gets and sets the property Document. 
        /// <para>
        /// The definition of a new traffic policy version, in JSON format. You must specify the
        /// full definition of the new traffic policy. You cannot specify just the differences
        /// between the new version and a previous version. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/APIReference/api-policies-traffic-policy-document-format.html">Traffic
        /// Policy Document Format</a> in the <i>Amazon Route 53 API Reference</i>.
        /// </para>
        /// </summary>
        public string Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Any comments that you want to include about the new traffic policy version.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

    }
}