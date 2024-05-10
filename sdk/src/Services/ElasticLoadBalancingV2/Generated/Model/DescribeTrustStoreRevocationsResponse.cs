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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeTrustStoreRevocations operation.
    /// </summary>
    public partial class DescribeTrustStoreRevocationsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<DescribeTrustStoreRevocation> _trustStoreRevocations = AWSConfigs.InitializeCollections ? new List<DescribeTrustStoreRevocation>() : null;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If there are additional results, this is the marker for the next set of results. Otherwise,
        /// this is null.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreRevocations. 
        /// <para>
        /// Information about the revocation file in the trust store.
        /// </para>
        /// </summary>
        public List<DescribeTrustStoreRevocation> TrustStoreRevocations
        {
            get { return this._trustStoreRevocations; }
            set { this._trustStoreRevocations = value; }
        }

        // Check to see if TrustStoreRevocations property is set
        internal bool IsSetTrustStoreRevocations()
        {
            return this._trustStoreRevocations != null && (this._trustStoreRevocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}