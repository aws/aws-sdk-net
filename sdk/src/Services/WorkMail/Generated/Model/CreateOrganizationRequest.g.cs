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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOrganization operation. Creates a new WorkMail
    /// organization. Optionally, you can choose to associate an existing AWS Directory Service
    /// directory with your organization. If an AWS Directory Service directory ID is specified,
    /// the organization alias must match the directory alias. If you choose not to associate
    /// an existing directory with your organization, then we create a new WorkMail directory
    /// for you. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_new_organization.html">Adding
    /// an organization</a> in the <i>WorkMail Administrator Guide</i>. <para> You can associate
    /// multiple email domains with an organization, then choose your default email domain
    /// from the WorkMail console. You can also associate a domain that is managed in an Amazon
    /// Route 53 public hosted zone. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_domain.html">Adding
    /// a domain</a> and <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/default_domain.html">Choosing
    /// the default domain</a> in the <i>WorkMail Administrator Guide</i>. </para> <para>
    /// Optionally, you can use a customer managed key from AWS Key Management Service (AWS
    /// KMS) to encrypt email for your organization. If you don't associate an AWS KMS key,
    /// WorkMail creates a default, AWS managed key for you. </para>
    /// </summary>
    public partial class CreateOrganizationRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The organization alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 62)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The AWS Directory Service directory ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// The email domains to associate with the organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<Domain> Domains { get; set; } = AWSConfigs.InitializeCollections ? new List<Domain>() : null;

        /// <summary>
        /// Checks to see if the Domains property is set.
        /// </summary>
        internal bool IsSetDomains() => this.Domains != null && (this.Domains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableInteroperability. 
        /// <para>
        /// When <c>true</c>, allows organization interoperability between WorkMail and Microsoft
        /// Exchange. If <c>true</c>, you must include a AD Connector directory ID in the request.
        /// </para>
        /// </summary>
        public bool? EnableInteroperability { get; set; }

        /// <summary>
        /// Checks to see if the EnableInteroperability property is set.
        /// </summary>
        internal bool IsSetEnableInteroperability() => this.EnableInteroperability.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a customer managed key from AWS KMS.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
