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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that lists the changes and information for a ChangeBatch.
    /// </summary>
    public partial class ChangeBatchRecord
    {
        private string _id;
        private DateTime? _submittedAt;
        private ChangeStatus _status;
        private string _comment;
        private string _submitter;
        private List<Change> _changes = new List<Change>();

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the request. Use this ID to track when the change has completed across all
        /// Amazon Route 53 DNS servers.
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
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The date and time the change was submitted, in the format <code>YYYY-MM-DDThh:mm:ssZ</code>,
        /// as specified in the ISO 8601 standard (for example, 2009-11-19T19:37:58Z). The <code>Z</code>
        /// after the time indicates that the time is listed in Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime SubmittedAt
        {
            get { return this._submittedAt.GetValueOrDefault(); }
            set { this._submittedAt = value; }
        }

        // Check to see if SubmittedAt property is set
        internal bool IsSetSubmittedAt()
        {
            return this._submittedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the request. <code>PENDING</code> indicates that this request
        /// has not yet been applied to all Amazon Route 53 DNS servers.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>PENDING</code> | <code>INSYNC</code> 
        /// </para>
        /// </summary>
        public ChangeStatus Status
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
        /// Gets and sets the property Comment. 
        /// <para>
        /// A complex type that describes change information about changes made to your hosted
        /// zone.
        /// </para>
        ///  
        /// <para>
        /// This element contains an ID that you use when performing a <a>GetChange</a> action
        /// to get detailed information about the change.
        /// </para>
        /// </summary>
        public string Comment
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
        /// Gets and sets the property Submitter. 
        /// <para>
        /// The AWS account ID attached to the changes. 
        /// </para>
        /// </summary>
        public string Submitter
        {
            get { return this._submitter; }
            set { this._submitter = value; }
        }

        // Check to see if Submitter property is set
        internal bool IsSetSubmitter()
        {
            return this._submitter != null;
        }

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// A list of changes made in the ChangeBatch.
        /// </para>
        /// </summary>
        public List<Change> Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null && this._changes.Count > 0; 
        }

    }
}