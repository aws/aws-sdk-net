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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents the content of a particular type of related item.
    /// </summary>
    public partial class RelatedItemContent
    {
        private CommentContent _comment;
        private ConnectCaseContent _connectCase;
        private ContactContent _contact;
        private CustomContent _custom;
        private FileContent _file;
        private SlaContent _sla;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Represents the content of a comment to be returned to agents.
        /// </para>
        /// </summary>
        public CommentContent Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectCase. 
        /// <para>
        /// Content for a related Connect case
        /// </para>
        /// </summary>
        public ConnectCaseContent ConnectCase
        {
            get { return this._connectCase; }
            set { this._connectCase = value; }
        }

        // Check to see if ConnectCase property is set
        internal bool IsSetConnectCase()
        {
            return this._connectCase != null;
        }

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// Represents the content of a contact to be returned to agents.
        /// </para>
        /// </summary>
        public ContactContent Contact
        {
            get { return this._contact; }
            set { this._contact = value; }
        }

        // Check to see if Contact property is set
        internal bool IsSetContact()
        {
            return this._contact != null;
        }

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// Content for a custom related item
        /// </para>
        /// </summary>
        public CustomContent Custom
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if Custom property is set
        internal bool IsSetCustom()
        {
            return this._custom != null;
        }

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// Represents the content of a File to be returned to agents.
        /// </para>
        /// </summary>
        public FileContent File
        {
            get { return this._file; }
            set { this._file = value; }
        }

        // Check to see if File property is set
        internal bool IsSetFile()
        {
            return this._file != null;
        }

        /// <summary>
        /// Gets and sets the property Sla. 
        /// <para>
        /// Represents the content of an SLA to be returned to agents.
        /// </para>
        /// </summary>
        public SlaContent Sla
        {
            get { return this._sla; }
            set { this._sla = value; }
        }

        // Check to see if Sla property is set
        internal bool IsSetSla()
        {
            return this._sla != null;
        }

    }
}