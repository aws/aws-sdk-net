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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a scheduled event for an instance.
    /// </summary>
    public partial class InstanceStatusEvent
    {
        private EventCode _code;
        private string _description;
        private string _instanceEventId;
        private DateTime? _notAfter;
        private DateTime? _notBefore;
        private DateTime? _notBeforeDeadline;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The event code.
        /// </para>
        /// </summary>
        public EventCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the event.
        /// </para>
        ///  
        /// <para>
        /// After a scheduled event is completed, it can still be described for up to a week.
        /// If the event has been completed, this description starts with the following text:
        /// [Completed].
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceEventId. 
        /// <para>
        /// The ID of the event.
        /// </para>
        /// </summary>
        public string InstanceEventId
        {
            get { return this._instanceEventId; }
            set { this._instanceEventId = value; }
        }

        // Check to see if InstanceEventId property is set
        internal bool IsSetInstanceEventId()
        {
            return this._instanceEventId != null;
        }

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The latest scheduled end time for the event.
        /// </para>
        /// </summary>
        public DateTime? NotAfter
        {
            get { return this._notAfter; }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The earliest scheduled start time for the event.
        /// </para>
        /// </summary>
        public DateTime? NotBefore
        {
            get { return this._notBefore; }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotBeforeDeadline. 
        /// <para>
        /// The deadline for starting the event.
        /// </para>
        /// </summary>
        public DateTime? NotBeforeDeadline
        {
            get { return this._notBeforeDeadline; }
            set { this._notBeforeDeadline = value; }
        }

        // Check to see if NotBeforeDeadline property is set
        internal bool IsSetNotBeforeDeadline()
        {
            return this._notBeforeDeadline.HasValue; 
        }

    }
}