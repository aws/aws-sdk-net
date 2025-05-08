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
    /// Describes an attachment change.
    /// </summary>
    public partial class NetworkInterfaceAttachmentChanges
    {
        private string _attachmentId;
        private bool? _defaultEnaQueueCount;
        private bool? _deleteOnTermination;
        private int? _enaQueueCount;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the network interface attachment.
        /// </para>
        /// </summary>
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultEnaQueueCount. 
        /// <para>
        /// The default number of the ENA queues.
        /// </para>
        /// </summary>
        public bool? DefaultEnaQueueCount
        {
            get { return this._defaultEnaQueueCount; }
            set { this._defaultEnaQueueCount = value; }
        }

        // Check to see if DefaultEnaQueueCount property is set
        internal bool IsSetDefaultEnaQueueCount()
        {
            return this._defaultEnaQueueCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the network interface is deleted when the instance is terminated.
        /// </para>
        /// </summary>
        public bool? DeleteOnTermination
        {
            get { return this._deleteOnTermination; }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnaQueueCount. 
        /// <para>
        /// The number of ENA queues to be created with the instance.
        /// </para>
        /// </summary>
        public int? EnaQueueCount
        {
            get { return this._enaQueueCount; }
            set { this._enaQueueCount = value; }
        }

        // Check to see if EnaQueueCount property is set
        internal bool IsSetEnaQueueCount()
        {
            return this._enaQueueCount.HasValue; 
        }

    }
}