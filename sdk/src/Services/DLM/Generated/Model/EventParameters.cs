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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies an event that triggers an event-based policy.
    /// </summary>
    public partial class EventParameters
    {
        private string _descriptionRegex;
        private EventTypeValues _eventType;
        private List<string> _snapshotOwner = new List<string>();

        /// <summary>
        /// Gets and sets the property DescriptionRegex. 
        /// <para>
        /// The snapshot description that can trigger the policy. The description pattern is specified
        /// using a regular expression. The policy runs only if a snapshot with a description
        /// that matches the specified pattern is shared with your account.
        /// </para>
        ///  
        /// <para>
        /// For example, specifying <code>^.*Created for policy: policy-1234567890abcdef0.*$</code>
        /// configures the policy to run only if snapshots created by policy <code>policy-1234567890abcdef0</code>
        /// are shared with your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string DescriptionRegex
        {
            get { return this._descriptionRegex; }
            set { this._descriptionRegex = value; }
        }

        // Check to see if DescriptionRegex property is set
        internal bool IsSetDescriptionRegex()
        {
            return this._descriptionRegex != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event. Currently, only snapshot sharing events are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventTypeValues EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotOwner. 
        /// <para>
        /// The IDs of the AWS accounts that can trigger policy by sharing snapshots with your
        /// account. The policy only runs if one of the specified AWS accounts shares a snapshot
        /// with your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<string> SnapshotOwner
        {
            get { return this._snapshotOwner; }
            set { this._snapshotOwner = value; }
        }

        // Check to see if SnapshotOwner property is set
        internal bool IsSetSnapshotOwner()
        {
            return this._snapshotOwner != null && this._snapshotOwner.Count > 0; 
        }

    }
}