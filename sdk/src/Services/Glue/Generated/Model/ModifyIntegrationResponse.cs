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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the ModifyIntegration operation.
    /// </summary>
    public partial class ModifyIntegrationResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _additionalEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _createTime;
        private string _dataFilter;
        private string _description;
        private List<IntegrationError> _errors = AWSConfigs.InitializeCollections ? new List<IntegrationError>() : null;
        private string _integrationArn;
        private IntegrationConfig _integrationConfig;
        private string _integrationName;
        private string _kmsKeyId;
        private string _sourceArn;
        private IntegrationStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property AdditionalEncryptionContext. 
        /// <para>
        /// An optional set of non-secret key–value pairs that contains additional contextual
        /// information for encryption.
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
        /// The time when the integration was created, in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DataFilter. 
        /// <para>
        /// Selects source tables for the integration using Maxwell filter syntax.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DataFilter
        {
            get { return this._dataFilter; }
            set { this._dataFilter = value; }
        }

        // Check to see if DataFilter property is set
        internal bool IsSetDataFilter()
        {
            return this._dataFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// A list of errors associated with the integration modification.
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
        /// The Amazon Resource Name (ARN) for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property IntegrationConfig.
        /// </summary>
        public IntegrationConfig IntegrationConfig
        {
            get { return this._integrationConfig; }
            set { this._integrationConfig = value; }
        }

        // Check to see if IntegrationConfig property is set
        internal bool IsSetIntegrationConfig()
        {
            return this._integrationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// A unique name for an integration in Glue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of a KMS key used for encrypting the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the source for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The status of the integration being modified.
        /// </para>
        ///  
        /// <para>
        /// The possible statuses are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING: The integration is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE: The integration creation succeeds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MODIFYING: The integration is being modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED: The integration creation fails. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING: The integration is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SYNCING: The integration is synchronizing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NEEDS_ATTENTION: The integration needs attention, such as synchronization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationStatus Status
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
        /// Metadata assigned to the resource consisting of a list of key-value pairs.
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
        /// The ARN of the target for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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