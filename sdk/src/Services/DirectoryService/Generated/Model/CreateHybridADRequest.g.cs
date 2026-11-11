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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHybridAD operation. Creates a hybrid directory
    /// that connects your self-managed Active Directory (AD) infrastructure and Amazon Web
    /// Services. <para> You must have a successful directory assessment using <a>StartADAssessment</a>
    /// to validate your environment compatibility before you use this operation. </para>
    /// <para> Updates are applied asynchronously. Use <a>DescribeDirectories</a> to monitor
    /// the progress of directory creation. </para>
    /// </summary>
    public partial class CreateHybridADRequest : AmazonDirectoryServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique identifier of the successful directory assessment that validates your self-managed
        /// AD environment. You must have a successful directory assessment before you create
        /// a hybrid directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Secrets Manager secret that
        /// contains the credentials for the service account used to join hybrid domain controllers
        /// to your self-managed AD domain. This secret is used once and not stored.
        /// </para>
        ///  
        /// <para>
        /// The secret must contain key-value pairs with keys matching <c>customerAdAdminDomainUsername</c>
        /// and <c>customerAdAdminDomainPassword</c>. For example: <c>{"customerAdAdminDomainUsername":"carlos_salazar","customerAdAdminDomainPassword":"ExamplePassword123!"}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the directory. Each tag consists of a key and value pair.
        /// You can specify multiple tags as a list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
