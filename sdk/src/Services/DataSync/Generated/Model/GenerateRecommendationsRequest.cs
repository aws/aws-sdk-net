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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateRecommendations operation.
    /// Creates recommendations about where to migrate your data to in Amazon Web Services.
    /// Recommendations are generated based on information that DataSync Discovery collects
    /// about your on-premises storage system's resources. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
    /// provided by DataSync Discovery</a>.
    /// 
    ///  
    /// <para>
    /// Once generated, you can view your recommendations by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeStorageSystemResources.html">DescribeStorageSystemResources</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// If your <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-job-statuses.html#discovery-job-statuses-table">discovery
    /// job completes successfully</a>, you don't need to use this operation. DataSync Discovery
    /// generates the recommendations for you automatically.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GenerateRecommendationsRequest : AmazonDataSyncRequest
    {
        private string _discoveryJobArn;
        private List<string> _resourceIds = new List<string>();
        private DiscoveryResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property DiscoveryJobArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the discovery job that collects information
        /// about your on-premises storage system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DiscoveryJobArn
        {
            get { return this._discoveryJobArn; }
            set { this._discoveryJobArn = value; }
        }

        // Check to see if DiscoveryJobArn property is set
        internal bool IsSetDiscoveryJobArn()
        {
            return this._discoveryJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// Specifies the universally unique identifiers (UUIDs) of the resources in your storage
        /// system that you want recommendations on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the type of resource in your storage system that you want recommendations
        /// on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiscoveryResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}