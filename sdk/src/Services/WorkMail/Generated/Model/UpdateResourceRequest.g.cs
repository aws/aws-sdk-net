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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResource operation. Updates data for the
    /// resource. To have the latest information, it must be preceded by a <a>DescribeResource</a>
    /// call. The dataset in the request should be the one expected when performing another
    /// <c>DescribeResource</c> call.
    /// </summary>
    public partial class UpdateResourceRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property BookingOptions. 
        /// <para>
        /// The resource's booking options to be updated.
        /// </para>
        /// </summary>
        public BookingOptions BookingOptions { get; set; }

        /// <summary>
        /// Checks to see if the BookingOptions property is set.
        /// </summary>
        internal bool IsSetBookingOptions() => this.BookingOptions != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the resource description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 64)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HiddenFromGlobalAddressList. 
        /// <para>
        /// If enabled, the resource is hidden from the global address list.
        /// </para>
        /// </summary>
        public bool? HiddenFromGlobalAddressList { get; set; }

        /// <summary>
        /// Checks to see if the HiddenFromGlobalAddressList property is set.
        /// </summary>
        internal bool IsSetHiddenFromGlobalAddressList() => this.HiddenFromGlobalAddressList.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier associated with the organization for which the resource is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource to be updated.
        /// </para>
        ///  
        /// <para>
        /// The identifier can accept <i>ResourceId</i>, <i>Resourcename</i>, or <i>email</i>.
        /// The following identity formats are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Resource ID: r-0123456789a0123456789b0123456789
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: resource@domain.tld
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Resource name: resource
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Updates the resource type.
        /// </para>
        /// </summary>
        public ResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
