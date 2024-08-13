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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that describes change information about changes made to your hosted
    /// zone.
    /// </summary>
    public partial class ChangeInfo
    {
        private string _id;
        private ChangeStatus _status;
        private DateTime? _submittedAt;
        private string _comment;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeInfo() { }

        /// <summary>
        /// Instantiates ChangeInfo with the parameterized properties
        /// </summary>
        /// <param name="id">This element contains an ID that you use when performing a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetChange.html">GetChange</a> action to get detailed information about the change.</param>
        /// <param name="status">The current state of the request. <c>PENDING</c> indicates that this request has not yet been applied to all Amazon Route 53 DNS servers.</param>
        /// <param name="submittedAt">The date and time that the change request was submitted in <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601 format</a> and Coordinated Universal Time (UTC). For example, the value <c>2017-03-27T17:48:16.751Z</c> represents March 27, 2017 at 17:48:16.751 UTC.</param>
        public ChangeInfo(string id, ChangeStatus status, DateTime? submittedAt)
        {
            _id = id;
            _status = status;
            _submittedAt = submittedAt;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// This element contains an ID that you use when performing a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetChange.html">GetChange</a>
        /// action to get detailed information about the change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the request. <c>PENDING</c> indicates that this request has not
        /// yet been applied to all Amazon Route 53 DNS servers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The date and time that the change request was submitted in <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO
        /// 8601 format</a> and Coordinated Universal Time (UTC). For example, the value <c>2017-03-27T17:48:16.751Z</c>
        /// represents March 27, 2017 at 17:48:16.751 UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmittedAt
        {
            get { return this._submittedAt; }
            set { this._submittedAt = value; }
        }

        // Check to see if SubmittedAt property is set
        internal bool IsSetSubmittedAt()
        {
            return this._submittedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A comment you can provide.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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

    }
}