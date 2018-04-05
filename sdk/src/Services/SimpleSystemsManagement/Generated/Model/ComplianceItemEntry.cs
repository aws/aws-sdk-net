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

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about a compliance item.
    /// </summary>
    public partial class ComplianceItemEntry
    {
        private Dictionary<string, string> _details = new Dictionary<string, string>();
        private string _id;
        private ComplianceSeverity _severity;
        private ComplianceStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// A "Key": "Value" tag combination for the compliance item.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && this._details.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The compliance item ID. For example, if the compliance item is a Windows patch, the
        /// ID could be the number of the KB article.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the compliance status. Severity can be one of the following: Critical,
        /// High, Medium, Low, Informational, Unspecified.
        /// </para>
        /// </summary>
        public ComplianceSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the compliance item. An item is either COMPLIANT or NON_COMPLIANT.
        /// </para>
        /// </summary>
        public ComplianceStatus Status
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
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the compliance item. For example, if the compliance item is a Windows
        /// patch, the title could be the title of the KB article for the patch; for example:
        /// Security Update for Active Directory Federation Services. 
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}