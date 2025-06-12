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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// The summary of the Personal Access Token.
    /// </summary>
    public partial class PersonalAccessTokenSummary
    {
        private DateTime? _dateCreated;
        private DateTime? _dateLastUsed;
        private DateTime? _expiresTime;
        private string _name;
        private string _personalAccessTokenId;
        private List<string> _scopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userId;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        ///  The date when the Personal Access Token was created. 
        /// </para>
        /// </summary>
        public DateTime? DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateLastUsed. 
        /// <para>
        ///  The date when the Personal Access Token was last used. 
        /// </para>
        /// </summary>
        public DateTime? DateLastUsed
        {
            get { return this._dateLastUsed; }
            set { this._dateLastUsed = value; }
        }

        // Check to see if DateLastUsed property is set
        internal bool IsSetDateLastUsed()
        {
            return this._dateLastUsed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresTime. 
        /// <para>
        ///  The date when the Personal Access Token will expire. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresTime
        {
            get { return this._expiresTime; }
            set { this._expiresTime = value; }
        }

        // Check to see if ExpiresTime property is set
        internal bool IsSetExpiresTime()
        {
            return this._expiresTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the Personal Access Token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalAccessTokenId. 
        /// <para>
        ///  The ID of the Personal Access Token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PersonalAccessTokenId
        {
            get { return this._personalAccessTokenId; }
            set { this._personalAccessTokenId = value; }
        }

        // Check to see if PersonalAccessTokenId property is set
        internal bool IsSetPersonalAccessTokenId()
        {
            return this._personalAccessTokenId != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        ///  Lists all the Personal Access Token permissions for a mailbox. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null && (this._scopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  The user ID of the WorkMail user associated with the Personal Access Token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}