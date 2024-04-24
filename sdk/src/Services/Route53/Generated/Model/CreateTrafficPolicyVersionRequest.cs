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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrafficPolicyVersion operation.
    /// Creates a new version of an existing traffic policy. When you create a new version
    /// of a traffic policy, you specify the ID of the traffic policy that you want to update
    /// and a JSON-formatted document that describes the new version. You use traffic policies
    /// to create multiple DNS resource record sets for one domain name (such as example.com)
    /// or one subdomain name (such as www.example.com). You can create a maximum of 1000
    /// versions of a traffic policy. If you reach the limit and need to create another version,
    /// you'll need to start a new traffic policy.
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
        /// Gets and sets the property Document. 
        /// <para>
        /// The definition of this version of the traffic policy, in JSON format. You specified
        /// the JSON in the <c>CreateTrafficPolicyVersion</c> request. For more information about
        /// the JSON format, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateTrafficPolicy.html">CreateTrafficPolicy</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=102400)]
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
        /// The comment that you specified in the <c>CreateTrafficPolicyVersion</c> request, if
        /// any.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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