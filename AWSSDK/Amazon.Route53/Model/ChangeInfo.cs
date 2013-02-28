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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type that describes change information about changes made to your hosted zone.</para> <para>This element contains an ID that
    /// you use when performing a GetChange action to get detailed information about the change.</para>
    /// </summary>
    public class ChangeInfo
    {
        
        private string id;
        private string status;
        private DateTime? submittedAt;
        private string comment;

        /// <summary>
        /// The ID of the request. Use this ID to track when the change has completed across all Amazon Route 53 DNS servers.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        public ChangeInfo WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The current state of the request. <c>PENDING</c> indicates that this request has not yet been applied to all Amazon Route 53 DNS servers.
        /// Valid Values: <c>PENDING</c> | <c>INSYNC</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>PENDING, INSYNC</description>
        ///     </item>
        /// </list>
        /// </para>
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
        public ChangeInfo WithStatus(string status)
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
        /// The date and time the change was submitted, in the format <c>YYYY-MM-DDThh:mm:ssZ</c>, as specified in the ISO 8601 standard (for example,
        /// 2009-11-19T19:37:58Z). The <c>Z</c> after the time indicates that the time is listed in Coordinated Universal Time (UTC), which is
        /// synonymous with Greenwich Mean Time in this context.
        ///  
        /// </summary>
        public DateTime SubmittedAt
        {
            get { return this.submittedAt ?? default(DateTime); }
            set { this.submittedAt = value; }
        }

        /// <summary>
        /// Sets the SubmittedAt property
        /// </summary>
        /// <param name="submittedAt">The value to set for the SubmittedAt property </param>
        /// <returns>this instance</returns>
        public ChangeInfo WithSubmittedAt(DateTime submittedAt)
        {
            this.submittedAt = submittedAt;
            return this;
        }
            

        // Check to see if SubmittedAt property is set
        internal bool IsSetSubmittedAt()
        {
            return this.submittedAt.HasValue;
        }

        /// <summary>
        /// A complex type that describes change information about changes made to your hosted zone. This element contains an ID that you use when
        /// performing a <a>GetChange</a> action to get detailed information about the change.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        public ChangeInfo WithComment(string comment)
        {
            this.comment = comment;
            return this;
        }
            

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }
    }
}
