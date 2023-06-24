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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePublicDnsNamespace operation.
    /// Creates a public namespace based on DNS, which is visible on the internet. The namespace
    /// defines your service naming scheme. For example, if you name your namespace <code>example.com</code>
    /// and name your service <code>backend</code>, the resulting DNS name for the service
    /// is <code>backend.example.com</code>. You can discover instances that were registered
    /// with a public DNS namespace by using either a <code>DiscoverInstances</code> request
    /// or using DNS. For the current quota on the number of namespaces that you can create
    /// using the same Amazon Web Services account, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/cloud-map-limits.html">Cloud
    /// Map quotas</a> in the <i>Cloud Map Developer Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// The <code>CreatePublicDnsNamespace</code> API operation is not supported in the Amazon
    /// Web Services GovCloud (US) Regions.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreatePublicDnsNamespaceRequest : AmazonServiceDiscoveryRequest
    {
        private string _creatorRequestId;
        private string _description;
        private string _name;
        private PublicDnsNamespaceProperties _properties;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <code>CreatePublicDnsNamespace</code>
        /// requests to be retried without the risk of running the operation twice. <code>CreatorRequestId</code>
        /// can be any unique string (for example, a date/timestamp).
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// The name that you want to assign to this namespace.
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not include sensitive information in the name. The name is publicly available using
        /// DNS queries.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=253)]
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
        /// Gets and sets the property Properties. 
        /// <para>
        /// Properties for the public DNS namespace.
        /// </para>
        /// </summary>
        public PublicDnsNamespaceProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the namespace. Each tag consists of a key and an optional value
        /// that you define. Tags keys can be up to 128 characters in length, and tag values can
        /// be up to 256 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}