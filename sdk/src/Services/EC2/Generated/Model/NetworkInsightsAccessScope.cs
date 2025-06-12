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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Network Access Scope.
    /// </summary>
    public partial class NetworkInsightsAccessScope
    {
        private DateTime? _createdDate;
        private string _networkInsightsAccessScopeArn;
        private string _networkInsightsAccessScopeId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _updatedDate;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The creation date.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Access Scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string NetworkInsightsAccessScopeArn
        {
            get { return this._networkInsightsAccessScopeArn; }
            set { this._networkInsightsAccessScopeArn = value; }
        }

        // Check to see if NetworkInsightsAccessScopeArn property is set
        internal bool IsSetNetworkInsightsAccessScopeArn()
        {
            return this._networkInsightsAccessScopeArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeId. 
        /// <para>
        /// The ID of the Network Access Scope.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeId
        {
            get { return this._networkInsightsAccessScopeId; }
            set { this._networkInsightsAccessScopeId = value; }
        }

        // Check to see if NetworkInsightsAccessScopeId property is set
        internal bool IsSetNetworkInsightsAccessScopeId()
        {
            return this._networkInsightsAccessScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedDate. 
        /// <para>
        /// The last updated date.
        /// </para>
        /// </summary>
        public DateTime? UpdatedDate
        {
            get { return this._updatedDate; }
            set { this._updatedDate = value; }
        }

        // Check to see if UpdatedDate property is set
        internal bool IsSetUpdatedDate()
        {
            return this._updatedDate.HasValue; 
        }

    }
}