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
        private List<BatchGetRecordIdentifier> _identifiers = new List<BatchGetRecordIdentifier>();

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// A list of <code>FeatureGroup</code> names, with their corresponding <code>RecordIdentifier</code>
        /// value, and Feature name that have been requested to be retrieved in batch.
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