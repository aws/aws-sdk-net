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
    /// Container for the parameters to the CreateTrafficPolicy operation.
    /// Creates a traffic policy, which you use to create multiple DNS resource record sets
    /// for one domain name (such as example.com) or one subdomain name (such as www.example.com).
    /// 
    ///  
    /// <para>
    /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicy</code>
    /// resource. The request body must include a document with a <code>CreateTrafficPolicyRequest</code>
    /// element. The response includes the <code>CreateTrafficPolicyResponse</code> element,
    /// which contains information about the new traffic policy.
    /// </para>
    /// </summary>
    public partial class CreateTrafficPolicyRequest : AmazonRoute53Request
    {
        private string _name;
        private string _document;
        private string _comment;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the traffic policy.
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
        /// Gets and sets the property Document. 
        /// <para>
        /// The definition of this traffic policy in JSON format. For more information, see <a
        /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/api-policies-traffic-policy-document-format.html">Traffic
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
        /// (Optional) Any comments that you want to include about the traffic policy.
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