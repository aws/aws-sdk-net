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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a finding aggregation by code repository.
    /// </summary>
    public partial class CodeRepositoryAggregationResponse
    {
        private string _accountId;
        private long? _exploitAvailableActiveFindingsCount;
        private long? _fixAvailableActiveFindingsCount;
        private string _projectNames;
        private string _providerType;
        private string _resourceId;
        private SeverityCounts _severityCounts;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the code repository.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExploitAvailableActiveFindingsCount. 
        /// <para>
        /// The number of active findings that have an exploit available for the code repository.
        /// </para>
        /// </summary>
        public long? ExploitAvailableActiveFindingsCount
        {
            get { return this._exploitAvailableActiveFindingsCount; }
            set { this._exploitAvailableActiveFindingsCount = value; }
        }

        // Check to see if ExploitAvailableActiveFindingsCount property is set
        internal bool IsSetExploitAvailableActiveFindingsCount()
        {
            return this._exploitAvailableActiveFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FixAvailableActiveFindingsCount. 
        /// <para>
        /// The number of active findings that have a fix available for the code repository.
        /// </para>
        /// </summary>
        public long? FixAvailableActiveFindingsCount
        {
            get { return this._fixAvailableActiveFindingsCount; }
            set { this._fixAvailableActiveFindingsCount = value; }
        }

        // Check to see if FixAvailableActiveFindingsCount property is set
        internal bool IsSetFixAvailableActiveFindingsCount()
        {
            return this._fixAvailableActiveFindingsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectNames. 
        /// <para>
        /// The names of the projects associated with the code repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectNames
        {
            get { return this._projectNames; }
            set { this._projectNames = value; }
        }

        // Check to see if ProjectNames property is set
        internal bool IsSetProjectNames()
        {
            return this._projectNames != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of repository provider for the code repository.
        /// </para>
        /// </summary>
        public string ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID of the code repository.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts.
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

    }
}