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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatasetEntries operation.
    /// <note> 
    /// <para>
    /// This operation applies only to Amazon Rekognition Custom Labels.
    /// </para>
    ///  </note> 
    /// <para>
    ///  Lists the entries (images) within a dataset. An entry is a JSON Line that contains
    /// the information for a single image, including the image location, assigned labels,
    /// and object location bounding boxes. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/customlabels-dg/md-manifest-files.html">Creating
    /// a manifest file</a>.
    /// </para>
    ///  
    /// <para>
    /// JSON Lines in the response include information about non-terminal errors found in
    /// the dataset. Non terminal errors are reported in <c>errors</c> lists within each JSON
    /// Line. The same information is reported in the training and testing validation result
    /// manifests that Amazon Rekognition Custom Labels creates during model training. 
    /// </para>
    ///  
    /// <para>
    /// You can filter the response in variety of ways, such as choosing which labels to return
    /// and returning JSON Lines created after a specific date. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:ListDatasetEntries</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListDatasetEntriesRequest : AmazonRekognitionRequest
    {
        private List<string> _containsLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _datasetArn;
        private bool? _hasErrors;
        private bool? _labeled;
        private int? _maxResults;
        private string _nextToken;
        private string _sourceRefContains;

        /// <summary>
        /// Gets and sets the property ContainsLabels. 
        /// <para>
        /// Specifies a label filter for the response. The response includes an entry only if
        /// one or more of the labels in <c>ContainsLabels</c> exist in the entry. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ContainsLabels
        {
            get { return this._containsLabels; }
            set { this._containsLabels = value; }
        }

        // Check to see if ContainsLabels property is set
        internal bool IsSetContainsLabels()
        {
            return this._containsLabels != null && (this._containsLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the dataset that you want to use. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property HasErrors. 
        /// <para>
        /// Specifies an error filter for the response. Specify <c>True</c> to only include entries
        /// that have errors. 
        /// </para>
        /// </summary>
        public bool? HasErrors
        {
            get { return this._hasErrors; }
            set { this._hasErrors = value; }
        }

        // Check to see if HasErrors property is set
        internal bool IsSetHasErrors()
        {
            return this._hasErrors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Labeled. 
        /// <para>
        ///  Specify <c>true</c> to get only the JSON Lines where the image is labeled. Specify
        /// <c>false</c> to get only the JSON Lines where the image isn't labeled. If you don't
        /// specify <c>Labeled</c>, <c>ListDatasetEntries</c> returns JSON Lines for labeled and
        /// unlabeled images. 
        /// </para>
        /// </summary>
        public bool? Labeled
        {
            get { return this._labeled; }
            set { this._labeled = value; }
        }

        // Check to see if Labeled property is set
        internal bool IsSetLabeled()
        {
            return this._labeled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per paginated call. The largest value you
        /// can specify is 100. If you specify a value greater than 100, a ValidationException
        /// error occurs. The default value is 100. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there is more results to retrieve),
        /// Amazon Rekognition Custom Labels returns a pagination token in the response. You can
        /// use this pagination token to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property SourceRefContains. 
        /// <para>
        /// If specified, <c>ListDatasetEntries</c> only returns JSON Lines where the value of
        /// <c>SourceRefContains</c> is part of the <c>source-ref</c> field. The <c>source-ref</c>
        /// field contains the Amazon S3 location of the image. You can use <c>SouceRefContains</c>
        /// for tasks such as getting the JSON Line for a single image, or gettting JSON Lines
        /// for all images within a specific folder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceRefContains
        {
            get { return this._sourceRefContains; }
            set { this._sourceRefContains = value; }
        }

        // Check to see if SourceRefContains property is set
        internal bool IsSetSourceRefContains()
        {
            return this._sourceRefContains != null;
        }

    }
}