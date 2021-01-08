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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Provides a list of status information for an instance.
    /// </summary>
    public partial class DBInstanceStatusInfo
    {
        private string _message;
        private bool? _normal;
        private string _status;
        private string _statusType;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Details of the error if there is an error for the instance. If the instance is not
        /// in an error state, this value is blank.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Normal. 
        /// <para>
        /// A Boolean value that is <code>true</code> if the instance is operating normally, or
        /// <code>false</code> if the instance is in an error state.
        /// </para>
        /// </summary>
        public bool Normal
        {
            get { return this._normal.GetValueOrDefault(); }
            set { this._normal = value; }
        }

        // Check to see if Normal property is set
        internal bool IsSetNormal()
        {
            return this._normal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the instance. For a <code>StatusType</code> of read replica, the values
        /// can be <code>replicating</code>, error, <code>stopped</code>, or <code>terminated</code>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusType. 
        /// <para>
        /// This value is currently "<code>read replication</code>."
        /// </para>
        /// </summary>
        public string StatusType
        {
            get { return this._statusType; }
            set { this._statusType = value; }
        }

        // Check to see if StatusType property is set
        internal bool IsSetStatusType()
        {
            return this._statusType != null;
        }

    }
}