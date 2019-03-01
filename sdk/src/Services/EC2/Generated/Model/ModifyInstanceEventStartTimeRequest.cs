/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyInstanceEventStartTime operation.
    /// Modifies the start time for a scheduled Amazon EC2 instance event.
    /// </summary>
    public partial class ModifyInstanceEventStartTimeRequest : AmazonEC2Request
    {
        private string _instanceEventId;
        private string _instanceId;
        private DateTime? _notBefore;

        /// <summary>
        /// Gets and sets the property InstanceEventId. 
        /// <para>
        /// The ID of the event whose date and time you are modifying.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance with the scheduled event.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The new date and time when the event will take place.
        /// </para>
        /// </summary>
        public DateTime NotBefore
        {
            get { return this._notBefore.GetValueOrDefault(); }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore.HasValue; 
        }

    }
}