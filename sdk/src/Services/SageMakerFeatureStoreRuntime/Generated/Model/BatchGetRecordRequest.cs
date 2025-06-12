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
    /// Container for the parameters to the BatchGetRecord operation.
    /// Retrieves a batch of <c>Records</c> from a <c>FeatureGroup</c>.
    /// </summary>
    public partial class BatchGetRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private ExpirationTimeResponse _expirationTimeResponse;
        private List<BatchGetRecordIdentifier> _identifiers = AWSConfigs.InitializeCollections ? new List<BatchGetRecordIdentifier>() : null;

        /// <summary>
        /// Gets and sets the property ExpirationTimeResponse. 
        /// <para>
        /// Parameter to request <c>ExpiresAt</c> in response. If <c>Enabled</c>, <c>BatchGetRecord</c>
        /// will return the value of <c>ExpiresAt</c>, if it is not null. If <c>Disabled</c> and
        /// null, <c>BatchGetRecord</c> will return null.
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
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// A list containing the name or Amazon Resource Name (ARN) of the <c>FeatureGroup</c>,
        /// the list of names of <c>Feature</c>s to be retrieved, and the corresponding <c>RecordIdentifier</c>
        /// values as strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<BatchGetRecordIdentifier> Identifiers
        {
            get { return this._identifiers; }
            set { this._identifiers = value; }
        }

        // Check to see if Identifiers property is set
        internal bool IsSetIdentifiers()
        {
            return this._identifiers != null && (this._identifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}