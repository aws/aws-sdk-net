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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetRecord operation.
    /// Use for <c>OnlineStore</c> serving from a <c>FeatureStore</c>. Only the latest records
    /// stored in the <c>OnlineStore</c> can be retrieved. If no Record with <c>RecordIdentifierValue</c>
    /// is found, then an empty result is returned.
    /// </summary>
    public partial class GetRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private ExpirationTimeResponse _expirationTimeResponse;
        private string _featureGroupName;
        private List<string> _featureNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _recordIdentifierValueAsString;

        /// <summary>
        /// Gets and sets the property ExpirationTimeResponse. 
        /// <para>
        /// Parameter to request <c>ExpiresAt</c> in response. If <c>Enabled</c>, <c>GetRecord</c>
        /// will return the value of <c>ExpiresAt</c>, if it is not null. If <c>Disabled</c> and
        /// null, <c>GetRecord</c> will return null.
        /// </para>
        /// </summary>
        public ExpirationTimeResponse ExpirationTimeResponse
        {
            get { return this._expirationTimeResponse; }
            set { this._expirationTimeResponse = value; }
        }

        // Check to see if ExpirationTimeResponse property is set
        internal bool IsSetExpirationTimeResponse()
        {
            return this._expirationTimeResponse != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the feature group from which you want to
        /// retrieve a record.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._featureNames != null && (this._featureNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordIdentifierValueAsString. 
        /// <para>
        /// The value that corresponds to <c>RecordIdentifier</c> type and uniquely identifies
        /// the record in the <c>FeatureGroup</c>. 
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