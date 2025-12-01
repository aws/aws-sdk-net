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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetObjectTypeAttributeStatistics operation.
    /// </summary>
    public partial class GetObjectTypeAttributeStatisticsResponse : AmazonWebServiceResponse
    {
        private DateTime? _calculatedAt;
        private GetObjectTypeAttributeStatisticsStats _statistics;

        /// <summary>
        /// Gets and sets the property CalculatedAt. 
        /// <para>
        /// Time when this statistics was calculated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CalculatedAt
        {
            get { return this._calculatedAt.GetValueOrDefault(); }
            set { this._calculatedAt = value; }
        }

        // Check to see if CalculatedAt property is set
        internal bool IsSetCalculatedAt()
        {
            return this._calculatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GetObjectTypeAttributeStatisticsStats Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

    }
}