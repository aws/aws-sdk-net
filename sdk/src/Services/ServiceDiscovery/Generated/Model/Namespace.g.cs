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

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about a specified namespace.
    /// </summary>
    public partial class Namespace
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that Cloud Map assigns to the namespace when you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date that the namespace was created, in Unix date/time format and Coordinated
        /// Universal Time (UTC). The value of <c>CreateDate</c> is accurate to milliseconds.
        /// For example, the value <c>1516925490.087</c> represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of running an operation twice. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you specify for the namespace when you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of a namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the namespace, such as <c>example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A complex type that contains information that's specific to the type of the namespace.
        /// </para>
        /// </summary>
        public NamespaceProperties Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null;

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The ID of the Amazon Web Services account that created the namespace. If this isn't
        /// your account ID, it's the ID of the account that shared the namespace with your account.
        /// For more information about shared namespaces, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ResourceOwner { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwner property is set.
        /// </summary>
        internal bool IsSetResourceOwner() => this.ResourceOwner != null;

        /// <summary>
        /// Gets and sets the property ServiceCount. 
        /// <para>
        /// The number of services that are associated with the namespace.
        /// </para>
        /// </summary>
        public int? ServiceCount { get; set; }

        /// <summary>
        /// Checks to see if the ServiceCount property is set.
        /// </summary>
        internal bool IsSetServiceCount() => this.ServiceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the namespace. The methods for discovering instances depends on the value
        /// that you specify:
        /// </para>
        ///  <dl> <dt>HTTP</dt> <dd> 
        /// <para>
        /// Instances can be discovered only programmatically, using the Cloud Map <c>DiscoverInstances</c>
        /// API.
        /// </para>
        ///  </dd> <dt>DNS_PUBLIC</dt> <dd> 
        /// <para>
        /// Instances can be discovered using public DNS queries and using the <c>DiscoverInstances</c>
        /// API.
        /// </para>
        ///  </dd> <dt>DNS_PRIVATE</dt> <dd> 
        /// <para>
        /// Instances can be discovered using DNS queries in VPCs and using the <c>DiscoverInstances</c>
        /// API.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public NamespaceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
