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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the CreateIntegration operation.
    /// </summary>
    public partial class CreateIntegrationResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _additionalEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _createTime;
        private string _description;
        private List<IntegrationError> _errors = AWSConfigs.InitializeCollections ? new List<IntegrationError>() : null;
        private string _integrationArn;
        private string _integrationName;
        private string _kmsKeyId;
        private string _sourceArn;
        private ZeroETLIntegrationStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// The encryption context for the integration. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// context</a> in the <i>Amazon Web Services Key Management Service Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalEncryptionContext
        {
            get { return this._additionalEncryptionContext; }
            set { this._additionalEncryptionContext = value; }
        }

        // Check to see if AdditionalEncryptionContext property is set
        internal bool IsSetAdditionalEncryptionContext()
        {
            return this._additionalEncryptionContext != null && (this._additionalEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time (UTC) when the integration was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Any errors associated with the integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegrationError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string IntegrationArn
        {
            get { return this._integrationArn; }
            set { this._integrationArn = value; }
        }

        // Check to see if IntegrationArn property is set
        internal bool IsSetIntegrationArn()
        {
            return this._integrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// The name of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string IntegrationName
        {
            get { return this._integrationName; }
            set { this._integrationName = value; }
        }

        // Check to see if IntegrationName property is set
        internal bool IsSetIntegrationName()
        {
            return this._integrationName != null;
        }

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        /// The Key Management Service (KMS) key identifier for the key used to encrypt the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string KMSKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KMSKeyId property is set
        internal bool IsSetKMSKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database used as the source for replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the integration.
        /// </para>
        /// </summary>
        public ZeroETLIntegrationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Redshift data warehouse to use as the
        /// target for replication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}