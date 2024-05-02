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
    /// The representation of a user or group.
    /// </summary>
    public partial class Member
    {
        private DateTime? _disabledDate;
        private DateTime? _enabledDate;
        private string _id;
        private string _name;
        private EntityState _state;
        private MemberType _type;

        /// <summary>
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date indicating when the member was disabled from WorkMail use.
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
        /// Gets and sets the property EnabledDate. 
        /// <para>
        /// The date indicating when the member was enabled for WorkMail use.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the member.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the member, which can be ENABLED, DISABLED, or DELETED.
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
        /// A member can be a user or group.
        /// </para>
        /// </summary>
        public MemberType Type
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