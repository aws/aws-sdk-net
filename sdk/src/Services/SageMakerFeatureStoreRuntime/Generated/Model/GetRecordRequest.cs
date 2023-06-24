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
    /// Container for the parameters to the GetRecord operation.
    /// Use for <code>OnlineStore</code> serving from a <code>FeatureStore</code>. Only the
    /// latest records stored in the <code>OnlineStore</code> can be retrieved. If no Record
    /// with <code>RecordIdentifierValue</code> is found, then an empty result is returned.
    /// </summary>
    public partial class GetRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private string _featureGroupName;
        private List<string> _featureNames = new List<string>();
        private string _recordIdentifierValueAsString;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the feature group from which you want to retrieve a record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property RecordIdentifierValueAsString. 
        /// <para>
        /// The value that corresponds to <code>RecordIdentifier</code> type and uniquely identifies
        /// the record in the <code>FeatureGroup</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=358400)]
        public string RecordIdentifierValueAsString
        {
            get { return this._recordIdentifierValueAsString; }
            set { this._recordIdentifierValueAsString = value; }
        }

        // Check to see if RecordIdentifierValueAsString property is set
        internal bool IsSetRecordIdentifierValueAsString()
        {
            return this._recordIdentifierValueAsString != null;
        }

    }
}