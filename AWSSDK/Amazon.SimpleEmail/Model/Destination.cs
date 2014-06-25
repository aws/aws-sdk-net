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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the destination of the message, consisting of To:, CC:, and BCC: fields.
    /// 
    ///         
    /// <para>
    ///             By default, the string must be 7-bit ASCII. If the text must contain any
    /// other characters,             then you must use MIME encoded-word syntax (RFC 2047)
    /// instead of a literal string.             MIME encoded-word syntax uses the following
    /// form: <code>=?charset?encoding?encoded-text?=</code>.             For more information,
    /// see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>.        
    /// </para>
    /// </summary>
    public partial class Destination
    {
        private List<string> _bccAddresses = new List<string>();
        private List<string> _ccAddresses = new List<string>();
        private List<string> _toAddresses = new List<string>();


        /// <summary>
        /// Gets and sets the property BccAddresses. 
        /// <para>
        /// The BCC: field(s) of the message.
        /// </para>
        /// </summary>
        public List<string> BccAddresses
        {
            get { return this._bccAddresses; }
            set { this._bccAddresses = value; }
        }

        /// <summary>
        /// Sets the BccAddresses property
        /// </summary>
        /// <param name="bccAddresses">The values to add to the BccAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Destination WithBccAddresses(params string[] bccAddresses)
        {
            foreach (var element in bccAddresses)
            {
                this._bccAddresses.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the BccAddresses property
        /// </summary>
        /// <param name="bccAddresses">The values to add to the BccAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Destination WithBccAddresses(IEnumerable<string> bccAddresses)
        {
            foreach (var element in bccAddresses)
            {
                this._bccAddresses.Add(element);
            }
            return this;
        }
        // Check to see if BccAddresses property is set
        internal bool IsSetBccAddresses()
        {
            return this._bccAddresses != null && this._bccAddresses.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property CcAddresses. 
        /// <para>
        /// The CC: field(s) of the message.
        /// </para>
        /// </summary>
        public List<string> CcAddresses
        {
            get { return this._ccAddresses; }
            set { this._ccAddresses = value; }
        }

        /// <summary>
        /// Sets the CcAddresses property
        /// </summary>
        /// <param name="ccAddresses">The values to add to the CcAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Destination WithCcAddresses(params string[] ccAddresses)
        {
            foreach (var element in ccAddresses)
            {
                this._ccAddresses.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the CcAddresses property
        /// </summary>
        /// <param name="ccAddresses">The values to add to the CcAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Destination WithCcAddresses(IEnumerable<string> ccAddresses)
        {
            foreach (var element in ccAddresses)
            {
                this._ccAddresses.Add(element);
            }
            return this;
        }
        // Check to see if CcAddresses property is set
        internal bool IsSetCcAddresses()
        {
            return this._ccAddresses != null && this._ccAddresses.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ToAddresses. 
        /// <para>
        /// The To: field(s) of the message.
        /// </para>
        /// </summary>
        public List<string> ToAddresses
        {
            get { return this._toAddresses; }
            set { this._toAddresses = value; }
        }

        /// <summary>
        /// Sets the ToAddresses property
        /// </summary>
        /// <param name="toAddresses">The values to add to the ToAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Destination WithToAddresses(params string[] toAddresses)
        {
            foreach (var element in toAddresses)
            {
                this._toAddresses.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ToAddresses property
        /// </summary>
        /// <param name="toAddresses">The values to add to the ToAddresses collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Destination WithToAddresses(IEnumerable<string> toAddresses)
        {
            foreach (var element in toAddresses)
            {
                this._toAddresses.Add(element);
            }
            return this;
        }
        // Check to see if ToAddresses property is set
        internal bool IsSetToAddresses()
        {
            return this._toAddresses != null && this._toAddresses.Count > 0; 
        }

    }
}