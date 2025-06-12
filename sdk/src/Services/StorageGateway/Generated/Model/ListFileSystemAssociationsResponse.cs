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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the ListFileSystemAssociations operation.
    /// </summary>
    public partial class ListFileSystemAssociationsResponse : AmazonWebServiceResponse
    {
        private List<FileSystemAssociationSummary> _fileSystemAssociationSummaryList = AWSConfigs.InitializeCollections ? new List<FileSystemAssociationSummary>() : null;
        private string _marker;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property FileSystemAssociationSummaryList. 
        /// <para>
        /// An array of information about the Amazon FSx gateway's file system associations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FileSystemAssociationSummary> FileSystemAssociationSummaryList
        {
            get { return this._fileSystemAssociationSummaryList; }
            set { this._fileSystemAssociationSummaryList = value; }
        }

        // Check to see if FileSystemAssociationSummaryList property is set
        internal bool IsSetFileSystemAssociationSummaryList()
        {
            return this._fileSystemAssociationSummaryList != null && (this._fileSystemAssociationSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the request includes <c>Marker</c>, the response returns that value in this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If a value is present, there are more file system associations to return. In a subsequent
        /// request, use <c>NextMarker</c> as the value for <c>Marker</c> to retrieve the next
        /// set of file system associations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}