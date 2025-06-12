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
    /// Details for an Amazon S3 filter.
    /// </summary>
    public partial class AwsS3BucketNotificationConfigurationS3KeyFilter
    {
        private List<AwsS3BucketNotificationConfigurationS3KeyFilterRule> _filterRules = AWSConfigs.InitializeCollections ? new List<AwsS3BucketNotificationConfigurationS3KeyFilterRule>() : null;

        /// <summary>
        /// Gets and sets the property FilterRules. 
        /// <para>
        /// The filter rules for the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketNotificationConfigurationS3KeyFilterRule> FilterRules
        {
            get { return this._filterRules; }
            set { this._filterRules = value; }
        }

        // Check to see if FilterRules property is set
        internal bool IsSetFilterRules()
        {
            return this._filterRules != null && (this._filterRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}