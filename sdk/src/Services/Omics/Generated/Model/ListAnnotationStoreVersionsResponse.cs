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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the ListAnnotationStoreVersions operation.
    /// </summary>
    public partial class ListAnnotationStoreVersionsResponse : AmazonWebServiceResponse
    {
        private List<AnnotationStoreVersionItem> _annotationStoreVersions = AWSConfigs.InitializeCollections ? new List<AnnotationStoreVersionItem>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnnotationStoreVersions. 
        /// <para>
        ///  Lists all versions of an annotation store. 
        /// </para>
        /// </summary>
        public List<AnnotationStoreVersionItem> AnnotationStoreVersions
        {
            get { return this._annotationStoreVersions; }
            set { this._annotationStoreVersions = value; }
        }

        // Check to see if AnnotationStoreVersions property is set
        internal bool IsSetAnnotationStoreVersions()
        {
            return this._annotationStoreVersions != null && (this._annotationStoreVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Specifies the pagination token from a previous request to retrieve the next page
        /// of results. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}