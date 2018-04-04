/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAggregationAuthorization operation.
    /// Deletes the authorization granted to the specified configuration aggregator account
    /// in a specified region.
    /// </summary>
    public partial class DeleteAggregationAuthorizationRequest : AmazonConfigServiceRequest
    {
        private string _authorizedAccountId;
        private string _authorizedAwsRegion;

        /// <summary>
        /// Gets and sets the property AuthorizedAccountId. 
        /// <para>
        /// The 12-digit account ID of the account authorized to aggregate data.
        /// </para>
        /// </summary>
        public string AuthorizedAccountId
        {
            get { return this._authorizedAccountId; }
            set { this._authorizedAccountId = value; }
        }

        // Check to see if AuthorizedAccountId property is set
        internal bool IsSetAuthorizedAccountId()
        {
            return this._authorizedAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizedAwsRegion. 
        /// <para>
        /// The region authorized to collect aggregated data.
        /// </para>
        /// </summary>
        public string AuthorizedAwsRegion
        {
            get { return this._authorizedAwsRegion; }
            set { this._authorizedAwsRegion = value; }
        }

        // Check to see if AuthorizedAwsRegion property is set
        internal bool IsSetAuthorizedAwsRegion()
        {
            return this._authorizedAwsRegion != null;
        }

    }
}