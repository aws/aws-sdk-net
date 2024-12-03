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
    /// This is the response object from the DescribeResource operation.
    /// </summary>
    public partial class DescribeResourceResponse : AmazonWebServiceResponse
    {
        private BookingOptions _bookingOptions;
        private string _description;
        private DateTime? _disabledDate;
        private string _email;
        private DateTime? _enabledDate;
        private bool? _hiddenFromGlobalAddressList;
        private string _name;
        private string _resourceId;
        private EntityState _state;
        private ResourceType _type;

        /// <summary>
        /// Gets and sets the property BookingOptions. 
        /// <para>
        /// The booking options for the described resource.
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
        /// Description of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date and time when a resource was disabled from WorkMail, in UNIX epoch time format.
        /// </para>
        /// </summary>
        public DateTime? DisabledDate
        {
            get { return this._disabledDate; }
            set { this._disabledDate = value; }
        }

        // Check to see if DisabledDate property is set
        internal bool IsSetDisabledDate()
        {
            return this._disabledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of the described resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledDate. 
        /// <para>
        /// The date and time when a resource was enabled for WorkMail, in UNIX epoch time format.
        /// </para>
        /// </summary>
        public DateTime? EnabledDate
        {
            get { return this._enabledDate; }
            set { this._enabledDate = value; }
        }

        // Check to see if EnabledDate property is set
        internal bool IsSetEnabledDate()
        {
            return this._enabledDate.HasValue; 
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
        /// The name of the described resource.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the described resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=34, Max=34)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the resource: enabled (registered to WorkMail), disabled (deregistered
        /// or never registered to WorkMail), or deleted.
        /// </para>
        /// </summary>
        public EntityState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the described resource.
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