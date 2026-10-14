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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIntegration operation. Updates an existing
    /// integration, identified by its id, ARN, or name. Only the fields you provide are changed.
    /// </summary>
    public partial class UpdateIntegrationRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property Credential. The replacement credential used to authenticate
        /// with the provider.
        /// </summary>
        public IntegrationCredential Credential { get; set; }

        /// <summary>
        /// Checks to see if the Credential property is set.
        /// </summary>
        internal bool IsSetCredential() => this.Credential != null;

        /// <summary>
        /// Gets and sets the property Identifier. Identifies the integration to update — exactly
        /// one of integrationId, integrationArn, or integrationName.
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationIdentifier Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property IntegrationAttributes. The provider-specific attributes
        /// to associate with the integration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IntegrationAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the IntegrationAttributes property is set.
        /// </summary>
        internal bool IsSetIntegrationAttributes() => this.IntegrationAttributes != null && (this.IntegrationAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name of the IAM role assumed
        /// to access the integration.
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
