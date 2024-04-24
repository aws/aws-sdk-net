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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Contains a <c>Bounce</c> object if the event type is <c>BOUNCE</c>. Contains a <c>Complaint</c>
    /// object if the event type is <c>COMPLAINT</c>.
    /// </summary>
    public partial class EventDetails
    {
        private Bounce _bounce;
        private Complaint _complaint;

        /// <summary>
        /// Gets and sets the property Bounce. 
        /// <para>
        /// Information about a <c>Bounce</c> event.
        /// </para>
        /// </summary>
        public Bounce Bounce
        {
            get { return this._bounce; }
            set { this._bounce = value; }
        }

        // Check to see if Bounce property is set
        internal bool IsSetBounce()
        {
            return this._bounce != null;
        }

        /// <summary>
        /// Gets and sets the property Complaint. 
        /// <para>
        /// Information about a <c>Complaint</c> event.
        /// </para>
        /// </summary>
        public Complaint Complaint
        {
            get { return this._complaint; }
            set { this._complaint = value; }
        }

        // Check to see if Complaint property is set
        internal bool IsSetComplaint()
        {
            return this._complaint != null;
        }

    }
}