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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The details of an Amazon QuickSight space.
    /// </summary>
    public partial class SpaceDetails
    {
        private int? _consumedSourceDocCount;
        private long? _consumedSourceSize;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _createdByArn;
        private string _description;
        private string _name;
        private List<SpaceQuickSightResource> _resources = AWSConfigs.InitializeCollections ? new List<SpaceQuickSightResource>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ConsumedSourceDocCount. 
        /// <para>
        /// The number of consumed source documents.
        /// </para>
        /// </summary>
        public int? ConsumedSourceDocCount
        {
            get { return this._consumedSourceDocCount; }
            set { this._consumedSourceDocCount = value; }
        }

        // Check to see if ConsumedSourceDocCount property is set
        internal bool IsSetConsumedSourceDocCount()
        {
            return this._consumedSourceDocCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumedSourceSize. 
        /// <para>
        /// The total consumed source size in bytes.
        /// </para>
        /// </summary>
        public long? ConsumedSourceSize
        {
            get { return this._consumedSourceSize; }
            set { this._consumedSourceSize = value; }
        }

        // Check to see if ConsumedSourceSize property is set
        internal bool IsSetConsumedSourceSize()
        {
            return this._consumedSourceSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the space was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// The user who created the space.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedByArn. 
        /// <para>
        /// The ARN of the user who created the space.
        /// </para>
        /// </summary>
        public string CreatedByArn
        {
            get { return this._createdByArn; }
            set { this._createdByArn = value; }
        }

        // Check to see if CreatedByArn property is set
        internal bool IsSetCreatedByArn()
        {
            return this._createdByArn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources in the space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SpaceQuickSightResource> Resources
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the space was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}