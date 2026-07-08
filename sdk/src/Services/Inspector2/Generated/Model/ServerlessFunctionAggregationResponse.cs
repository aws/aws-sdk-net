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
    /// A response that contains the results of a serverless function aggregation.
    /// </summary>
    public partial class ServerlessFunctionAggregationResponse
    {
        private string _accountId;
        private string _cloudAccountId;
        private string _cloudOrgId;
        private string _cloudPartition;
        private Provider _cloudProvider;
        private string _cloudRegion;
        private long? _exploitAvailableActiveFindingsCount;
        private long? _fixAvailableActiveFindingsCount;
        private string _functionName;
        private DateTime? _lastModifiedAt;
        private string _resourceId;
        private string _runtime;
        private SeverityCounts _severityCounts;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID associated with the serverless function.
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
        /// Gets and sets the property CloudAccountId. 
        /// <para>
        /// The cloud account ID for the serverless function aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string CloudAccountId
        {
            get { return this._cloudAccountId; }
            set { this._cloudAccountId = value; }
        }

        // Check to see if CloudAccountId property is set
        internal bool IsSetCloudAccountId()
        {
            return this._cloudAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudOrgId. 
        /// <para>
        /// The cloud organization ID for the serverless function aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string CloudOrgId
        {
            get { return this._cloudOrgId; }
            set { this._cloudOrgId = value; }
        }

        // Check to see if CloudOrgId property is set
        internal bool IsSetCloudOrgId()
        {
            return this._cloudOrgId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudPartition. 
        /// <para>
        /// The cloud infrastructure partition associated with this serverless function aggregation.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> – Amazon Web Services commercial Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> – Amazon Web Services China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> – Amazon Web Services GovCloud (US) Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AzureCloud</c> – Azure commercial Regions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudPartition
        {
            get { return this._cloudPartition; }
            set { this._cloudPartition = value; }
        }

        // Check to see if CloudPartition property is set
        internal bool IsSetCloudPartition()
        {
            return this._cloudPartition != null;
        }

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud service provider associated with this serverless function aggregation. Valid
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> – Findings from Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZURE</c> – Findings from Microsoft Azure resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Provider CloudProvider
        {
            get { return this._cloudProvider; }
            set { this._cloudProvider = value; }
        }

        // Check to see if CloudProvider property is set
        internal bool IsSetCloudProvider()
        {
            return this._cloudProvider != null;
        }

        /// <summary>
        /// Gets and sets the property CloudRegion. 
        /// <para>
        /// The cloud Region associated with this serverless function aggregation. The value format
        /// depends on the cloud provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services Region, such as <c>us-east-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Azure region, such as <c>eastus</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudRegion
        {
            get { return this._cloudRegion; }
            set { this._cloudRegion = value; }
        }

        // Check to see if CloudRegion property is set
        internal bool IsSetCloudRegion()
        {
            return this._cloudRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ExploitAvailableActiveFindingsCount. 
        /// <para>
        /// The number of active findings with an exploit available for the serverless function.
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
        /// The number of active findings with a fix available for the serverless function.
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
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the serverless function.
        /// </para>
        /// </summary>
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time the serverless function was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID for the serverless function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime of the serverless function.
        /// </para>
        /// </summary>
        public string Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the serverless function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}