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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the ImportModel operation.
    /// Creates a new custom model that replicates a source custom model that you import.
    /// The source model can be in your AWS account or another one.
    /// 
    ///  
    /// <para>
    /// If the source model is in another AWS account, then it must have a resource-based
    /// policy that authorizes you to import it.
    /// </para>
    ///  
    /// <para>
    /// The source model must be in the same AWS region that you're using when you import.
    /// You can't import a model that's in a different region.
    /// </para>
    /// </summary>
    public partial class ImportModelRequest : AmazonComprehendRequest
    {
        private string _dataAccessRoleArn;
        private string _modelKmsKeyId;
        private string _modelName;
        private string _sourceModelArn;
        private List<Tag> _tags = new List<Tag>();
        private string _versionName;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants Amazon Comprehend permission to use Amazon Key Management Service (KMS)
        /// to encrypt or decrypt the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelKmsKeyId. 
        /// <para>
        /// ID for the AWS Key Management Service (KMS) key that Amazon Comprehend uses to encrypt
        /// trained custom models. The ModelKmsKeyId can be either of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ModelKmsKeyId
        {
            get { return this._modelKmsKeyId; }
            set { this._modelKmsKeyId = value; }
        }

        // Check to see if ModelKmsKeyId property is set
        internal bool IsSetModelKmsKeyId()
        {
            return this._modelKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name to assign to the custom model that is created in Amazon Comprehend by this
        /// import.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SourceModelArn
        {
            get { return this._sourceModelArn; }
            set { this._sourceModelArn = value; }
        }

        // Check to see if SourceModelArn property is set
        internal bool IsSetSourceModelArn()
        {
            return this._sourceModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the custom model that is created by this import. A tag is a
        /// key-value pair that adds as a metadata to a resource used by Amazon Comprehend. For
        /// example, a tag with "Sales" as the key might be added to a resource to indicate its
        /// use by the sales department.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version name given to the custom model that is created by this import. Version
        /// names can have a maximum of 256 characters. Alphanumeric characters, hyphens (-) and
        /// underscores (_) are allowed. The version name must be unique among all models with
        /// the same classifier name in the account/AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}