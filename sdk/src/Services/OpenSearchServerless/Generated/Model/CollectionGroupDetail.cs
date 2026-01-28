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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Details about a collection group.
    /// </summary>
    public partial class CollectionGroupDetail
    {
        private string _arn;
        private CollectionGroupCapacityLimits _capacityLimits;
        private long? _createdDate;
        private string _description;
        private string _id;
        private string _name;
        private int? _numberOfCollections;
        private StandbyReplicas _standbyReplicas;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collection group.
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
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the collection group, in OpenSearch Compute Units (OCUs).
        /// </para>
        /// </summary>
        public CollectionGroupCapacityLimits CapacityLimits
        {
            get { return this._capacityLimits; }
            set { this._capacityLimits = value; }
        }

        // Check to see if CapacityLimits property is set
        internal bool IsSetCapacityLimits()
        {
            return this._capacityLimits != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The Epoch time when the collection group was created.
        /// </para>
        /// </summary>
        public long? CreatedDate
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the collection group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the collection group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the collection group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=32)]
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
        /// Gets and sets the property NumberOfCollections. 
        /// <para>
        /// The number of collections associated with the collection group.
        /// </para>
        /// </summary>
        public int? NumberOfCollections
        {
            get { return this._numberOfCollections; }
            set { this._numberOfCollections = value; }
        }

        // Check to see if NumberOfCollections property is set
        internal bool IsSetNumberOfCollections()
        {
            return this._numberOfCollections.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StandbyReplicas. 
        /// <para>
        /// Indicates whether standby replicas are used for the collection group.
        /// </para>
        /// </summary>
        public StandbyReplicas StandbyReplicas
        {
            get { return this._standbyReplicas; }
            set { this._standbyReplicas = value; }
        }

        // Check to see if StandbyReplicas property is set
        internal bool IsSetStandbyReplicas()
        {
            return this._standbyReplicas != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs associated with the collection group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

    }
}