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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the GetOpenIDConnectProvider operation.
    /// </summary>
    public partial class GetOpenIDConnectProviderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientIDList. 
        /// <para>
        /// A list of client IDs (also known as audiences) that are associated with the specified
        /// IAM OIDC provider resource object. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateOpenIDConnectProvider.html">CreateOpenIDConnectProvider</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClientIDList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClientIDList property is set.
        /// </summary>
        internal bool IsSetClientIDList() => this.ClientIDList != null && (this.ClientIDList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContextProvider. 
        /// <para>
        /// The trusted identity propagation context provider configuration associated with the
        /// IAM OIDC provider resource object. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ContextProvider.html">ContextProvider</a>.
        /// </para>
        ///  
        /// <para>
        /// This element is returned only when a trusted identity propagation context provider
        /// is configured for the OIDC provider.
        /// </para>
        /// </summary>
        public ContextProvider ContextProvider { get; set; }

        /// <summary>
        /// Checks to see if the ContextProvider property is set.
        /// </summary>
        internal bool IsSetContextProvider() => this.ContextProvider != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the IAM OIDC provider resource object was created in the Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance associated with
        /// the IAM OIDC provider resource object.
        /// </para>
        ///  
        /// <para>
        /// For the format, see <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_InstanceMetadata.html">InstanceMetadata</a>
        /// in the <i>IAM Identity Center API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// This element is returned only when an IAM Identity Center instance is associated with
        /// the OIDC provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string IdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceArn() => this.IdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity store that is resolved from the associated
        /// IAM Identity Center instance.
        /// </para>
        ///  
        /// <para>
        /// For the format, see <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_InstanceMetadata.html">InstanceMetadata</a>
        /// in the <i>IAM Identity Center API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// This element is returned only when an IAM Identity Center instance is associated with
        /// the OIDC provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IdentityStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreArn property is set.
        /// </summary>
        internal bool IsSetIdentityStoreArn() => this.IdentityStoreArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that are attached to the specified IAM OIDC provider. The returned
        /// list of tags is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThumbprintList. 
        /// <para>
        /// A list of certificate thumbprints that are associated with the specified IAM OIDC
        /// provider resource object. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateOpenIDConnectProvider.html">CreateOpenIDConnectProvider</a>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ThumbprintList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ThumbprintList property is set.
        /// </summary>
        internal bool IsSetThumbprintList() => this.ThumbprintList != null && (this.ThumbprintList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL that the IAM OIDC provider resource object is associated with. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateOpenIDConnectProvider.html">CreateOpenIDConnectProvider</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
