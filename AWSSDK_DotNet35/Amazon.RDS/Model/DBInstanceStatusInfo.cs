/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para>Provides a list of status information for a DB instance.</para>
    /// </summary>
    public class DBInstanceStatusInfo
    {
        
        private string statusType;
        private bool? normal;
        private string status;
        private string message;


        /// <summary>
        /// This value is currently "read replication."
        ///  
        /// </summary>
        public string StatusType
        {
            get { return this.statusType; }
            set { this.statusType = value; }
        }

        // Check to see if StatusType property is set
        internal bool IsSetStatusType()
        {
            return this.statusType != null;
        }

        /// <summary>
        /// Boolean value that is true if the instance is operating normally, or false if the instance is in an error state.
        ///  
        /// </summary>
        public bool Normal
        {
            get { return this.normal ?? default(bool); }
            set { this.normal = value; }
        }

        // Check to see if Normal property is set
        internal bool IsSetNormal()
        {
            return this.normal.HasValue;
        }

        /// <summary>
        /// Status of the DB instance. For a StatusType of read replica, the values can be replicating, error, stopped, or terminated.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// Details of the error if there is an error for the instance. If the instance is not in an error state, this value is blank.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }
    }
}
