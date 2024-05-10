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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Information about the connection health of an RDS Proxy target.
    /// </summary>
    public partial class TargetHealth
    {
        private string _description;
        private TargetHealthReason _reason;
        private TargetState _state;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the health of the RDS Proxy target. If the <c>State</c> is <c>AVAILABLE</c>,
        /// a description is not included.
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the current health <c>State</c> of the RDS Proxy target.
        /// </para>
        /// </summary>
        public TargetHealthReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the connection health lifecycle for the RDS Proxy target. The
        /// following is a typical lifecycle example for the states of an RDS Proxy target:
        /// </para>
        ///  
        /// <para>
        ///  <c>registering</c> &gt; <c>unavailable</c> &gt; <c>available</c> &gt; <c>unavailable</c>
        /// &gt; <c>available</c> 
        /// </para>
        /// </summary>
        public TargetState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}