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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeSecurityHubV2 operation.
    /// </summary>
    public partial class DescribeSecurityHubV2Response : AmazonWebServiceResponse
    {
        private Dictionary<string, FeatureDetail> _features = AWSConfigs.InitializeCollections ? new Dictionary<string, FeatureDetail>() : null;
        private string _hubV2Arn;
        private string _subscribedAt;

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// A map of opt-in features and their current status and metadata for the account in
        /// the current Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FeatureDetail> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HubV2Arn. 
        /// <para>
        /// The ARN of the service resource.
        /// </para>
        /// </summary>
        public string HubV2Arn
        {
            get { return this._hubV2Arn; }
            set { this._hubV2Arn = value; }
        }

        // Check to see if HubV2Arn property is set
        internal bool IsSetHubV2Arn()
        {
            return this._hubV2Arn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscribedAt. 
        /// <para>
        /// The date and time when the service was enabled in the account.
        /// </para>
        /// </summary>
        public string SubscribedAt
        {
            get { return this._subscribedAt; }
            set { this._subscribedAt = value; }
        }

        // Check to see if SubscribedAt property is set
        internal bool IsSetSubscribedAt()
        {
            return this._subscribedAt != null;
        }

    }
}