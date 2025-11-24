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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This contains metadata about resource selection for tiering configurations.
    /// 
    ///  
    /// <para>
    /// You can specify up to 5 different resource selections per tiering configuration. Data
    /// moved to lower-cost tier remains there until deletion (one-way transition).
    /// </para>
    /// </summary>
    public partial class ResourceSelection
    {
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceType;
        private int? _tieringDownSettingsInDays;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// An array of strings that either contains ARNs of the associated resources or contains
        /// a wildcard <c>*</c> to specify all resources. You can specify up to 100 specific resources
        /// per tiering configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource; for example, <c>S3</c> for Amazon S3. For
        /// tiering configurations, this is currently limited to <c>S3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TieringDownSettingsInDays. 
        /// <para>
        /// The number of days after creation within a backup vault that an object can transition
        /// to the low cost warm storage tier. Must be a positive integer between 60 and 36500
        /// days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=36500)]
        public int? TieringDownSettingsInDays
        {
            get { return this._tieringDownSettingsInDays; }
            set { this._tieringDownSettingsInDays = value; }
        }

        // Check to see if TieringDownSettingsInDays property is set
        internal bool IsSetTieringDownSettingsInDays()
        {
            return this._tieringDownSettingsInDays.HasValue; 
        }

    }
}