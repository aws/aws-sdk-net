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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents the destination of the message, consisting of To:, CC:, and BCC: fields.</para> <para> By default, the string must be 7-bit
    /// ASCII. If the text must contain any other characters, then you must use MIME encoded-word syntax (RFC 2047) instead of a literal string.
    /// MIME encoded-word syntax uses the following form: <c>=?charset?encoding?encoded-text?=</c> .
    /// For more information, see <a href="http://tools.ietf.org/html/rfc2047" >RFC 2047</a> .
    /// </para>
    /// </summary>
    public class Destination
    {
        
        private List<string> toAddresses = new List<string>();
        private List<string> ccAddresses = new List<string>();
        private List<string> bccAddresses = new List<string>();
        /// <summary>
        /// Default constructor for a new Destination object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public Destination() {}
    
        /// <summary>
        /// Constructs a new Destination object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="toAddresses"> The To: field(s) of the message. </param>
        public Destination(List<string> toAddresses)
        {
            this.toAddresses = toAddresses;
        }
    

        /// <summary>
        /// The To: field(s) of the message.
        ///  
        /// </summary>
        public List<string> ToAddresses
        {
            get { return this.toAddresses; }
            set { this.toAddresses = value; }
        }

        // Check to see if ToAddresses property is set
        internal bool IsSetToAddresses()
        {
            return this.toAddresses.Count > 0;
        }

        /// <summary>
        /// The CC: field(s) of the message.
        ///  
        /// </summary>
        public List<string> CcAddresses
        {
            get { return this.ccAddresses; }
            set { this.ccAddresses = value; }
        }

        // Check to see if CcAddresses property is set
        internal bool IsSetCcAddresses()
        {
            return this.ccAddresses.Count > 0;
        }

        /// <summary>
        /// The BCC: field(s) of the message.
        ///  
        /// </summary>
        public List<string> BccAddresses
        {
            get { return this.bccAddresses; }
            set { this.bccAddresses = value; }
        }

        // Check to see if BccAddresses property is set
        internal bool IsSetBccAddresses()
        {
            return this.bccAddresses.Count > 0;
        }
    }
}
