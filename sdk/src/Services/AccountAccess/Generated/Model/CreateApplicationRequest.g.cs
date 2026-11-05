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

namespace Amazon.AccountAccess.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation. Creates an account
    /// access manager instance and its Amazon Web Services account access application in
    /// the associated IAM Identity Center instance. This operation is idempotent; calling
    /// it multiple times with the same parameters returns the existing application.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonAccountAccessRequest
    {
        /// <summary>
        /// Gets and sets the property IdentitySource. 
        /// <para>
        /// Specifies the identity source for the application. The identity source defines the
        /// IAM Identity Center instance that provides principals for entitlements.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IdentitySource IdentitySource { get; set; }

        /// <summary>
        /// Checks to see if the IdentitySource property is set.
        /// </summary>
        internal bool IsSetIdentitySource() => this.IdentitySource != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags to assign to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
