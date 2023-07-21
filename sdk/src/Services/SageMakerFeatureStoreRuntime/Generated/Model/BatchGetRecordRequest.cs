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
    /// Container for the parameters to the BatchGetRecord operation.
    /// Retrieves a batch of <code>Records</code> from a <code>FeatureGroup</code>.
    /// </summary>
    public partial class BatchGetRecordRequest : AmazonSageMakerFeatureStoreRuntimeRequest
    {
        private ExpirationTimeResponse _expirationTimeResponse;
        private List<BatchGetRecordIdentifier> _identifiers = new List<BatchGetRecordIdentifier>();

        /// <summary>
        /// Gets and sets the property ExpirationTimeResponse. 
        /// <para>
        /// Parameter to request <code>ExpiresAt</code> in response. If <code>Enabled</code>,
        /// <code>BatchGetRecord</code> will return the value of <code>ExpiresAt</code>, if it
        /// is not null. If <code>Disabled</code> and null, <code>BatchGetRecord</code> will return
        /// null.
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
        /// A list containing the name or Amazon Resource Name (ARN) of the <code>FeatureGroup</code>,
        /// the list of names of <code>Feature</code>s to be retrieved, and the corresponding
        /// <code>RecordIdentifier</code> values as strings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<BatchGetRecordIdentifier> Identifiers
        {
            get { return this._identifiers; }
            set { this._identifiers = value; }
        }

        // Check to see if Identifiers property is set
        internal bool IsSetIdentifiers()
        {
            return this._identifiers != null && this._identifiers.Count > 0; 
        }

    }
}