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
    /// The list of types of related items and their parameters to use for filtering.
    /// </summary>
    public partial class RelatedItemTypeFilter
    {
        private CommentFilter _comment;
        private ConnectCaseFilter _connectCase;
        private ContactFilter _contact;
        private CustomFilter _custom;
        private FileFilter _file;
        private SlaFilter _sla;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A filter for related items of type <c>Comment</c>.
        /// </para>
        /// </summary>
        public CommentFilter Comment
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
        /// Filter for related items of type Connect case
        /// </para>
        /// </summary>
        public ConnectCaseFilter ConnectCase
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
        /// A filter for related items of type <c>Contact</c>.
        /// </para>
        /// </summary>
        public ContactFilter Contact
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
        /// Filter for related items of type Custom
        /// </para>
        /// </summary>
        public CustomFilter Custom
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
        /// A filter for related items of this type of <c>File</c>.
        /// </para>
        /// </summary>
        public FileFilter File
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
        ///  Filter for related items of type <c>SLA</c>.
        /// </para>
        /// </summary>
        public SlaFilter Sla
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