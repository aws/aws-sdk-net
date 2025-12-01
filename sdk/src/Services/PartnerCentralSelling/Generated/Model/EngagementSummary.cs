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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// An object that contains an <c>Engagement</c>'s subset of fields.
    /// </summary>
    public partial class EngagementSummary
    {
        private string _arn;
        private List<string> _contextTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _id;
        private int? _memberCount;
        private DateTime? _modifiedAt;
        private string _modifiedBy;
        private string _title;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created Engagement.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ContextTypes. 
        /// <para>
        /// An array of context types associated with the engagement, such as "CustomerProject"
        /// or "Lead". This provides a quick overview of the types of contexts included in the
        /// engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> ContextTypes
        {
            get { return this._contextTypes; }
            set { this._contextTypes = value; }
        }

        // Check to see if ContextTypes property is set
        internal bool IsSetContextTypes()
        {
            return this._contextTypes != null && (this._contextTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the Engagement was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The AWS Account ID of the Engagement creator.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the Engagement.
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
        /// Gets and sets the property MemberCount. 
        /// <para>
        /// The number of members in the Engagement.
        /// </para>
        /// </summary>
        public int MemberCount
        {
            get { return this._memberCount.GetValueOrDefault(); }
            set { this._memberCount = value; }
        }

        // Check to see if MemberCount property is set
        internal bool IsSetMemberCount()
        {
            return this._memberCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The timestamp indicating when the engagement was last modified, in ISO 8601 format
        /// (UTC). Example: "2023-05-01T20:37:46Z".
        /// </para>
        /// </summary>
        public DateTime ModifiedAt
        {
            get { return this._modifiedAt.GetValueOrDefault(); }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifiedBy. 
        /// <para>
        /// The AWS account ID of the user who last modified the engagement. This field helps
        /// track who made the most recent changes to the engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ModifiedBy
        {
            get { return this._modifiedBy; }
            set { this._modifiedBy = value; }
        }

        // Check to see if ModifiedBy property is set
        internal bool IsSetModifiedBy()
        {
            return this._modifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the Engagement.
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