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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the ImportModel operation. Creates a new custom model
    /// that replicates a source custom model that you import. The source model can be in
    /// your Amazon Web Services account or another one. <para> If the source model is in
    /// another Amazon Web Services account, then it must have a resource-based policy that
    /// authorizes you to import it. </para> <para> The source model must be in the same Amazon
    /// Web Services Region that you're using when you import. You can't import a model that's
    /// in a different Region. </para>
    /// </summary>
    public partial class ImportModelRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend permission
        /// to use Amazon Key Management Service (KMS) to encrypt or decrypt the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property ModelKmsKeyId. 
        /// <para>
        /// ID for the KMS key that Amazon Comprehend uses to encrypt trained custom models. The
        /// ModelKmsKeyId can be either of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <c>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ModelKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ModelKmsKeyId property is set.
        /// </summary>
        internal bool IsSetModelKmsKeyId() => this.ModelKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name to assign to the custom model that is created in Amazon Comprehend by this
        /// import.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string SourceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelArn property is set.
        /// </summary>
        internal bool IsSetSourceModelArn() => this.SourceModelArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the custom model that is created by this import. A tag is a
        /// key-value pair that adds as a metadata to a resource used by Amazon Comprehend. For
        /// example, a tag with "Sales" as the key might be added to a resource to indicate its
        /// use by the sales department.
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

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version name given to the custom model that is created by this import. Version
        /// names can have a maximum of 256 characters. Alphanumeric characters, hyphens (-) and
        /// underscores (_) are allowed. The version name must be unique among all models with
        /// the same classifier name in the account/Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
