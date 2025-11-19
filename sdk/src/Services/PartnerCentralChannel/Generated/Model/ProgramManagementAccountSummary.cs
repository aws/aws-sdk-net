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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
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
namespace Amazon.PartnerCentralChannel.Model
{
    /// <summary>
    /// Summary information about a program management account.
    /// </summary>
    public partial class ProgramManagementAccountSummary
    {
        private string _accountId;
        private string _arn;
        private string _catalog;
        private DateTime? _createdAt;
        private string _displayName;
        private string _id;
        private Program _program;
        private string _revision;
        private DateTime? _startDate;
        private ProgramManagementAccountStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS account ID associated with the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
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
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier associated with the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the account was created.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=17)]
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
        /// Gets and sets the property Program. 
        /// <para>
        /// The program type for the management account.
        /// </para>
        /// </summary>
        public Program Program
        {
            get { return this._program; }
            set { this._program = value; }
        }

        // Check to see if Program property is set
        internal bool IsSetProgram()
        {
            return this._program != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision number of the program management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the program management account.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the program management account.
        /// </para>
        /// </summary>
        public ProgramManagementAccountStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the account was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}