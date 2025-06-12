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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// A resource in Amazon Web Services that Amazon Web Services Resource Explorer has discovered,
    /// and for which it has stored information in the index of the Amazon Web Services Region
    /// that contains the resource.
    /// </summary>
    public partial class Resource
    {
        private string _arn;
        private DateTime? _lastReportedAt;
        private string _owningAccountId;
        private List<ResourceProperty> _properties = AWSConfigs.InitializeCollections ? new List<ResourceProperty>() : null;
        private string _region;
        private string _resourceType;
        private string _service;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the resource.
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
        /// Gets and sets the property LastReportedAt. 
        /// <para>
        /// The date and time that Resource Explorer last queried this resource and updated the
        /// index with the latest information about the resource.
        /// </para>
        /// </summary>
        public DateTime? LastReportedAt
        {
            get { return this._lastReportedAt; }
            set { this._lastReportedAt = value; }
        }

        // Check to see if LastReportedAt property is set
        internal bool IsSetLastReportedAt()
        {
            return this._lastReportedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwningAccountId. 
        /// <para>
        /// The Amazon Web Services account that owns the resource.
        /// </para>
        /// </summary>
        public string OwningAccountId
        {
            get { return this._owningAccountId; }
            set { this._owningAccountId = value; }
        }

        // Check to see if OwningAccountId property is set
        internal bool IsSetOwningAccountId()
        {
            return this._owningAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A structure with additional type-specific details about the resource. These properties
        /// can be added by turning on integration between Resource Explorer and other Amazon
        /// Web Services services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceProperty> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which the resource was created and exists.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The Amazon Web Services service that owns the resource and is responsible for creating
        /// and updating it.
        /// </para>
        /// </summary>
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}