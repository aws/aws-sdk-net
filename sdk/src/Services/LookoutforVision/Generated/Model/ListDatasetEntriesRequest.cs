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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatasetEntries operation.
    /// Lists the JSON Lines within a dataset. An Amazon Lookout for Vision JSON Line contains
    /// the anomaly information for a single image, including the image location and the assigned
    /// label.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lookoutvision:ListDatasetEntries</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class ListDatasetEntriesRequest : AmazonLookoutforVisionRequest
    {
        private DateTime? _afterCreationDate;
        private string _anomalyClass;
        private DateTime? _beforeCreationDate;
        private string _datasetType;
        private bool? _labeled;
        private int? _maxResults;
        private string _nextToken;
        private string _projectName;
        private string _sourceRefContains;

        /// <summary>
        /// Gets and sets the property AfterCreationDate. 
        /// <para>
        /// Only includes entries after the specified date in the response. For example, <c>2020-06-23T00:00:00</c>.
        /// </para>
        /// </summary>
        public DateTime? AfterCreationDate
        {
            get { return this._afterCreationDate; }
            set { this._afterCreationDate = value; }
        }

        // Check to see if AfterCreationDate property is set
        internal bool IsSetAfterCreationDate()
        {
            return this._afterCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AnomalyClass. 
        /// <para>
        /// Specify <c>normal</c> to include only normal images. Specify <c>anomaly</c> to only
        /// include anomalous entries. If you don't specify a value, Amazon Lookout for Vision
        /// returns normal and anomalous images.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string AnomalyClass
        {
            get { return this._anomalyClass; }
            set { this._anomalyClass = value; }
        }

        // Check to see if AnomalyClass property is set
        internal bool IsSetAnomalyClass()
        {
            return this._anomalyClass != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeCreationDate. 
        /// <para>
        /// Only includes entries before the specified date in the response. For example, <c>2020-06-23T00:00:00</c>.
        /// </para>
        /// </summary>
        public DateTime? BeforeCreationDate
        {
            get { return this._beforeCreationDate; }
            set { this._beforeCreationDate = value; }
        }

        // Check to see if BeforeCreationDate property is set
        internal bool IsSetBeforeCreationDate()
        {
            return this._beforeCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of the dataset that you want to list. Specify <c>train</c> to list the training
        /// dataset. Specify <c>test</c> to list the test dataset. If you have a single dataset
        /// project, specify <c>train</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string DatasetType
        {
            get { return this._datasetType; }
            set { this._datasetType = value; }
        }

        // Check to see if DatasetType property is set
        internal bool IsSetDatasetType()
        {
            return this._datasetType != null;
        }

        /// <summary>
        /// Gets and sets the property Labeled. 
        /// <para>
        /// Specify <c>true</c> to include labeled entries, otherwise specify <c>false</c>. If
        /// you don't specify a value, Lookout for Vision returns all entries.
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
        /// If the previous response was incomplete (because there is more data to retrieve),
        /// Amazon Lookout for Vision returns a pagination token in the response. You can use
        /// this pagination token to retrieve the next set of dataset entries.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project that contains the dataset that you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRefContains. 
        /// <para>
        /// Perform a "contains" search on the values of the <c>source-ref</c> key within the
        /// dataset. For example a value of "IMG_17" returns all JSON Lines where the <c>source-ref</c>
        /// key value matches <i>*IMG_17*</i>.
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