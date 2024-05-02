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
    /// Information about a trust store.
    /// </summary>
    public partial class TrustStore
    {
        private string _name;
        private int? _numberOfCaCertificates;
        private TrustStoreStatus _status;
        private long? _totalRevokedEntries;
        private string _trustStoreArn;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfCaCertificates. 
        /// <para>
        /// The number of ca certificates in the trust store.
        /// </para>
        /// </summary>
        public int? NumberOfCaCertificates
        {
            get { return this._numberOfCaCertificates; }
            set { this._numberOfCaCertificates = value; }
        }

        // Check to see if NumberOfCaCertificates property is set
        internal bool IsSetNumberOfCaCertificates()
        {
            return this._numberOfCaCertificates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the trust store.
        /// </para>
        /// </summary>
        public TrustStoreStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalRevokedEntries. 
        /// <para>
        /// The number of revoked certificates in the trust store.
        /// </para>
        /// </summary>
        public long? TotalRevokedEntries
        {
            get { return this._totalRevokedEntries; }
            set { this._totalRevokedEntries = value; }
        }

        // Check to see if TotalRevokedEntries property is set
        internal bool IsSetTotalRevokedEntries()
        {
            return this._totalRevokedEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trust store.
        /// </para>
        /// </summary>
        public string TrustStoreArn
        {
            get { return this._trustStoreArn; }
            set { this._trustStoreArn = value; }
        }

        // Check to see if TrustStoreArn property is set
        internal bool IsSetTrustStoreArn()
        {
            return this._trustStoreArn != null;
        }

    }
}