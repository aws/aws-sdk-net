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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The required configuration fields to give intermediate access to a provider service.
    /// </summary>
    public partial class ProviderIntermediateDataAccessConfiguration
    {
        private List<string> _awsAccountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _requiredBucketActions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountIds. 
        /// <para>
        /// The Amazon Web Services account that provider can use to read or write data into the
        /// customer's intermediate S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsAccountIds
        {
            get { return this._awsAccountIds; }
            set { this._awsAccountIds = value; }
        }

        // Check to see if AwsAccountIds property is set
        internal bool IsSetAwsAccountIds()
        {
            return this._awsAccountIds != null && (this._awsAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RequiredBucketActions. 
        /// <para>
        /// The S3 bucket actions that the provider requires permission for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequiredBucketActions
        {
            get { return this._requiredBucketActions; }
            set { this._requiredBucketActions = value; }
        }

        // Check to see if RequiredBucketActions property is set
        internal bool IsSetRequiredBucketActions()
        {
            return this._requiredBucketActions != null && (this._requiredBucketActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}