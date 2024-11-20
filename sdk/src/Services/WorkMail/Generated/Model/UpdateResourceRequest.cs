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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
    /// Container for the parameters to the UpdateResource operation.
    /// Updates data for the resource. To have the latest information, it must be preceded
    /// by a <a>DescribeResource</a> call. The dataset in the request should be the one expected
    /// when performing another <c>DescribeResource</c> call.
    /// </summary>
    public partial class UpdateResourceRequest : AmazonWorkMailRequest
    {
        private BookingOptions _bookingOptions;
        private string _description;
        private bool? _hiddenFromGlobalAddressList;
        private string _name;
        private string _organizationId;
        private string _resourceId;
        private ResourceType _type;

        /// <summary>
        /// Gets and sets the property BookingOptions. 
        /// <para>
        /// The resource's booking options to be updated.
        /// </para>
        /// </summary>
        public BookingOptions BookingOptions
        {
            get { return this._bookingOptions; }
            set { this._bookingOptions = value; }
        }

        // Check to see if BookingOptions property is set
        internal bool IsSetBookingOptions()
        {
            return this._bookingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Updates the resource description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=64)]
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
        /// Gets and sets the property HiddenFromGlobalAddressList. 
        /// <para>
        /// If enabled, the resource is hidden from the global address list.
        /// </para>
        /// </summary>
        public bool? HiddenFromGlobalAddressList
        {
            get { return this._hiddenFromGlobalAddressList; }
            set { this._hiddenFromGlobalAddressList = value; }
        }

        // Check to see if HiddenFromGlobalAddressList property is set
        internal bool IsSetHiddenFromGlobalAddressList()
        {
            return this._hiddenFromGlobalAddressList.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier associated with the organization for which the resource is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Updates the resource type.
        /// </para>
        /// </summary>
        public ResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}