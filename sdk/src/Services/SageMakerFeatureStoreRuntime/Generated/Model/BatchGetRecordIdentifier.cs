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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// The identifier that identifies the batch of Records you are retrieving in a batch.
    /// </summary>
    public partial class BatchGetRecordIdentifier
    {
        private string _featureGroupName;
        private List<string> _featureNames = new List<string>();
        private List<string> _recordIdentifiersValueAsString = new List<string>();

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the <code>FeatureGroup</code> containing
        /// the records you are retrieving in a batch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureNames. 
        /// <para>
        /// List of names of Features to be retrieved. If not specified, the latest value for
        /// all the Features are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> FeatureNames
        {
            get { return this._featureNames; }
            set { this._featureNames = value; }
        }

        // Check to see if FeatureNames property is set
        internal bool IsSetFeatureNames()
        {
            return this._featureNames != null && this._featureNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecordIdentifiersValueAsString. 
        /// <para>
        /// The value for a list of record identifiers in string format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> RecordIdentifiersValueAsString
        {
            get { return this._recordIdentifiersValueAsString; }
            set { this._recordIdentifiersValueAsString = value; }
        }

        // Check to see if RecordIdentifiersValueAsString property is set
        internal bool IsSetRecordIdentifiersValueAsString()
        {
            return this._recordIdentifiersValueAsString != null && this._recordIdentifiersValueAsString.Count > 0; 
        }

    }
}