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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccessControlApplicationSecret operation.
    /// Updates the Amazon Web Services Secrets Manager secret ARNs of an IdP-provided client
    /// secret. You can add, replace, or remove the ARN for a Region, but you can't remove
    /// the last remaining Region. To remove it, delete the client secret.
    /// </summary>
    public partial class UpdateAccessControlApplicationSecretRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the access control application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the Quick Sight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ClientSecretId. 
        /// <para>
        /// The ID of the client secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ClientSecretId { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecretId property is set.
        /// </summary>
        internal bool IsSetClientSecretId() => this.ClientSecretId != null;

        /// <summary>
        /// Gets and sets the property RemoveRegionalSecretManagerArns. 
        /// <para>
        /// The Regions whose ARNs to remove. You can't remove the last remaining Region. To remove
        /// it, delete the client secret instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> RemoveRegionalSecretManagerArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveRegionalSecretManagerArns property is set.
        /// </summary>
        internal bool IsSetRemoveRegionalSecretManagerArns() => this.RemoveRegionalSecretManagerArns != null && (this.RemoveRegionalSecretManagerArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateRegionalSecretManagerArns. 
        /// <para>
        /// The Region ARNs to add or replace. The Region in each ARN must match its key.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> UpdateRegionalSecretManagerArns { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the UpdateRegionalSecretManagerArns property is set.
        /// </summary>
        internal bool IsSetUpdateRegionalSecretManagerArns() => this.UpdateRegionalSecretManagerArns != null && (this.UpdateRegionalSecretManagerArns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
