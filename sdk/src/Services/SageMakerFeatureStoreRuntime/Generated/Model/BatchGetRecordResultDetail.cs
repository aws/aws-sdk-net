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
    /// The output of records that have been retrieved in a batch.
    /// </summary>
    public partial class BatchGetRecordResultDetail
    {
        private string _expiresAt;
        private string _featureGroupName;
        private List<FeatureValue> _record = AWSConfigs.InitializeCollections ? new List<FeatureValue>() : null;
        private string _recordIdentifierValueAsString;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The <c>ExpiresAt</c> ISO string of the requested record.
        /// </para>
        /// </summary>
        public string ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The <c>FeatureGroupName</c> containing Records you retrieved in a batch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=358400)]
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
        /// Gets and sets the property Record. 
        /// <para>
        /// The <c>Record</c> retrieved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<FeatureValue> Record
        {
            get { return this._record; }
            set { this._record = value; }
        }

        // Check to see if Record property is set
        internal bool IsSetRecord()
        {
            return this._record != null && (this._record.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordIdentifierValueAsString. 
        /// <para>
        /// The value of the record identifier in string format.
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