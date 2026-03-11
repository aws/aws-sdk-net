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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeMetadataModelChildren operation.
    /// </summary>
    public partial class DescribeMetadataModelChildrenResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<MetadataModelReference> _metadataModelChildren = AWSConfigs.InitializeCollections ? new List<MetadataModelReference>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Specifies the unique pagination token that makes it possible to display the next page
        /// of metadata model children. If a marker is returned, there are more metadata model
        /// children available.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataModelChildren. 
        /// <para>
        /// A list of child metadata models.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetadataModelReference> MetadataModelChildren
        {
            get { return this._metadataModelChildren; }
            set { this._metadataModelChildren = value; }
        }

        // Check to see if MetadataModelChildren property is set
        internal bool IsSetMetadataModelChildren()
        {
            return this._metadataModelChildren != null && (this._metadataModelChildren.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}