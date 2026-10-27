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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains information about an OAuth2 credential provider.
    /// </summary>
    public partial class Oauth2CredentialProviderItem
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the OAuth2 credential provider was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property CredentialProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OAuth2 credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CredentialProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialProviderArn property is set.
        /// </summary>
        internal bool IsSetCredentialProviderArn() => this.CredentialProviderArn != null;

        /// <summary>
        /// Gets and sets the property CredentialProviderVendor. 
        /// <para>
        /// The vendor of the OAuth2 credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CredentialProviderVendorType CredentialProviderVendor { get; set; }

        /// <summary>
        /// Checks to see if the CredentialProviderVendor property is set.
        /// </summary>
        internal bool IsSetCredentialProviderVendor() => this.CredentialProviderVendor != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the OAuth2 credential provider was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the OAuth2 credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
