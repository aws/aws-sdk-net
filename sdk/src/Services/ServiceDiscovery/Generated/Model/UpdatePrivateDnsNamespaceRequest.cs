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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePrivateDnsNamespace operation.
    /// Updates a private DNS namespace.
    /// </summary>
    public partial class UpdatePrivateDnsNamespaceRequest : AmazonServiceDiscoveryRequest
    {
        private string _id;
        private PrivateDnsNamespaceChange _awsNamespace;
        private string _updaterRequestId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the namespace that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// Updated properties for the private DNS namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrivateDnsNamespaceChange Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property UpdaterRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <c>UpdatePrivateDnsNamespace</c>
        /// requests to be retried without the risk of running the operation twice. <c>UpdaterRequestId</c>
        /// can be any unique string (for example, a date/timestamp).
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string UpdaterRequestId
        {
            get { return this._updaterRequestId; }
            set { this._updaterRequestId = value; }
        }

        // Check to see if UpdaterRequestId property is set
        internal bool IsSetUpdaterRequestId()
        {
            return this._updaterRequestId != null;
        }

    }
}