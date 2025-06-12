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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Details on data source packages for members of the behavior graph.
    /// </summary>
    public partial class MembershipDatasources
    {
        private string _accountId;
        private Dictionary<string, Dictionary<string, TimestampForCollection>> _datasourcePackageIngestHistory = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, TimestampForCollection>>() : null;
        private string _graphArn;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account identifier of the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property DatasourcePackageIngestHistory. 
        /// <para>
        /// Details on when a data source package was added to a behavior graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, TimestampForCollection>> DatasourcePackageIngestHistory
        {
            get { return this._datasourcePackageIngestHistory; }
            set { this._datasourcePackageIngestHistory = value; }
        }

        // Check to see if DatasourcePackageIngestHistory property is set
        internal bool IsSetDatasourcePackageIngestHistory()
        {
            return this._datasourcePackageIngestHistory != null && (this._datasourcePackageIngestHistory.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the organization behavior graph.
        /// </para>
        /// </summary>
        public string GraphArn
        {
            get { return this._graphArn; }
            set { this._graphArn = value; }
        }

        // Check to see if GraphArn property is set
        internal bool IsSetGraphArn()
        {
            return this._graphArn != null;
        }

    }
}