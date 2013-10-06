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

        /// <summary>
        /// Sets the StatusType property
        /// </summary>
        /// <param name="statusType">The value to set for the StatusType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBInstanceStatusInfo WithStatusType(string statusType)
        {
            this.statusType = statusType;
            return this;
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

        /// <summary>
        /// Sets the Normal property
        /// </summary>
        /// <param name="normal">The value to set for the Normal property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBInstanceStatusInfo WithNormal(bool normal)
        {
            this.normal = normal;
            return this;
        }
            

        // Check to see if Normal property is set
        internal bool IsSetNormal()
        {
            return this.normal.HasValue;
        }

        /// <summary>
        /// Status of the DB instance. For a StatusType of Read Replica, the values can be replicating, error, stopped, or terminated.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBInstanceStatusInfo WithStatus(string status)
        {
            this.status = status;
            return this;
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

        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">The value to set for the Message property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DBInstanceStatusInfo WithMessage(string message)
        {
            this.message = message;
            return this;
        }
            

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }
    }
}
