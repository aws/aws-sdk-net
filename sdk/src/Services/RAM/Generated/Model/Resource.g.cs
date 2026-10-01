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

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Describes a resource associated with a resource share in RAM.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time when the resource was associated with the resource share.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date an time when the association between the resource and the resource share
        /// was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceGroupArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource group. This value is available only if the
        /// resource is part of a resource group.
        /// </para>
        /// </summary>
        public string ResourceGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupArn property is set.
        /// </summary>
        internal bool IsSetResourceGroupArn() => this.ResourceGroupArn != null;

        /// <summary>
        /// Gets and sets the property ResourceRegionScope. 
        /// <para>
        /// Specifies the scope of visibility of this resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>REGIONAL</b> – The resource can be accessed only by using requests that target
        /// the Amazon Web Services Region in which the resource exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>GLOBAL</b> – The resource can be accessed from any Amazon Web Services Region.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceRegionScope ResourceRegionScope { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegionScope property is set.
        /// </summary>
        internal bool IsSetResourceRegionScope() => this.ResourceRegionScope != null;

        /// <summary>
        /// Gets and sets the property ResourceShareArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the resource share this resource is associated with.
        /// </para>
        /// </summary>
        public string ResourceShareArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShareArn property is set.
        /// </summary>
        internal bool IsSetResourceShareArn() => this.ResourceShareArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the resource.
        /// </para>
        /// </summary>
        public ResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message about the status of the resource.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The resource type. This takes the form of: <c>service-code</c>:<c>resource-code</c>,
        /// and is case-insensitive. For example, an Amazon EC2 Subnet would be represented by
        /// the string <c>ec2:subnet</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
