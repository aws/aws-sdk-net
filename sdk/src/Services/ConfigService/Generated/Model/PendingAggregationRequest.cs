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
    /// An object that represents the account ID and region of an aggregator account that
    /// is requesting authorization but is not yet authorized.
    /// </summary>
    public partial class PendingAggregationRequest
    {
        private string _requesterAccountId;
        private string _requesterAwsRegion;

        /// <summary>
        /// Gets and sets the property RequesterAccountId. 
        /// <para>
        /// The 12-digit account ID of the account requesting to aggregate data.
        /// </para>
        /// </summary>
        public string RequesterAccountId
        {
            get { return this._requesterAccountId; }
            set { this._requesterAccountId = value; }
        }

        // Check to see if RequesterAccountId property is set
        internal bool IsSetRequesterAccountId()
        {
            return this._requesterAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterAwsRegion. 
        /// <para>
        /// The region requesting to aggregate data. 
        /// </para>
        /// </summary>
        public string RequesterAwsRegion
        {
            get { return this._requesterAwsRegion; }
            set { this._requesterAwsRegion = value; }
        }

        // Check to see if RequesterAwsRegion property is set
        internal bool IsSetRequesterAwsRegion()
        {
            return this._requesterAwsRegion != null;
        }

    }
}