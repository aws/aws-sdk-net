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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the GetExclusionsPreview operation.
    /// </summary>
    public partial class GetExclusionsPreviewResponse : AmazonWebServiceResponse
    {
        private List<ExclusionPreview> _exclusionPreviews = AWSConfigs.InitializeCollections ? new List<ExclusionPreview>() : null;
        private string _nextToken;
        private PreviewStatus _previewStatus;

        /// <summary>
        /// Gets and sets the property ExclusionPreviews. 
        /// <para>
        /// Information about the exclusions included in the preview.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ExclusionPreview> ExclusionPreviews
        {
            get { return this._exclusionPreviews; }
            set { this._exclusionPreviews = value; }
        }

        // Check to see if ExclusionPreviews property is set
        internal bool IsSetExclusionPreviews()
        {
            return this._exclusionPreviews != null && (this._exclusionPreviews.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When a response is generated, if there is more data to be listed, this parameters
        /// is present in the response and contains the value to use for the nextToken parameter
        /// in a subsequent pagination request. If there is no more data to be listed, this parameter
        /// is set to null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
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

        /// <summary>
        /// Gets and sets the property PreviewStatus. 
        /// <para>
        /// Specifies the status of the request to generate an exclusions preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PreviewStatus PreviewStatus
        {
            get { return this._previewStatus; }
            set { this._previewStatus = value; }
        }

        // Check to see if PreviewStatus property is set
        internal bool IsSetPreviewStatus()
        {
            return this._previewStatus != null;
        }

    }
}