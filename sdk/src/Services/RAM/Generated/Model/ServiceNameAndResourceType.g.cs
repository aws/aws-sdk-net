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
    /// Information about a shareable resource type and the Amazon Web Services service to
    /// which resources of that type belong.
    /// </summary>
    public partial class ServiceNameAndResourceType
    {
        /// <summary>
        /// Gets and sets the property ResourceRegionScope. 
        /// <para>
        /// Specifies the scope of visibility of resources of this type:
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource. This takes the form of: <c>service-code</c>:<c>resource-code</c>,
        /// and is case-insensitive. For example, an Amazon EC2 Subnet would be represented by
        /// the string <c>ec2:subnet</c>.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service to which resources of this type belong.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;
    }
}
