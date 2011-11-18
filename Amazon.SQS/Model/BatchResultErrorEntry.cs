﻿/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-10-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// This is used in the responses of batch API to give a detailed description
    /// of the result of an operation on each entry in the request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2011-10-01/", IsNullable = false)]
    public class BatchResultErrorEntry
    {
        private string idField;
        private string codeField;
        private string messageField;
        private string senderFaultField;

        /// <summary>
        /// Gets and sets the id of an entry in a batch request.
        /// </summary>
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <summary>
        /// Checks if Id property is set
        /// </summary>
        /// <returns>true if Id property is set</returns>
        public bool IsSetId()
        {
            return this.idField != null;
        }

        /// <summary>
        /// Gets and sets the Code property.  Code is an error code representing why the operation failed on this entry.
        /// </summary>
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        /// <summary>
        /// Checks if Code property is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public bool IsSetCode()
        {
            return this.codeField != null;
        }

        /// <summary>
        /// Gets and sets the Message property.  A message explaining why the operation failed on this entry.
        /// </summary>
        public string Message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return this.messageField != null;
        }

        /// <summary>
        /// Gets and sets the SenderFault property.  SenderFault indicates whether the error happened due to the sender's fault.
        /// </summary>
        public string SenderFault
        {
            get { return this.senderFaultField; }
            set { this.senderFaultField = value; }
        }

        /// <summary>
        /// Checks if SenderFault property is set
        /// </summary>
        /// <returns>true if SenderFault property is set</returns>
        public bool IsSetSenderFault()
        {
            return this.senderFaultField != null;
        }
    }
}
