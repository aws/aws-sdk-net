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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the AddPartner operation.
    /// Adds a partner integration to a cluster. This operation authorizes a partner to push
    /// status updates for the specified database. To complete the integration, you also set
    /// up the integration on the partner website.
    /// </summary>
    public partial class AddPartnerRequest : AmazonRedshiftRequest
    {
        private string _accountId;
        private string _clusterIdentifier;
        private string _databaseName;
        private string _partnerName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID that owns the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier of the cluster that receives data from the partner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database that receives data from the partner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=127)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property PartnerName. 
        /// <para>
        /// The name of the partner that is authorized to send data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string PartnerName
        {
            get { return this._partnerName; }
            set { this._partnerName = value; }
        }

        // Check to see if PartnerName property is set
        internal bool IsSetPartnerName()
        {
            return this._partnerName != null;
        }

    }
}