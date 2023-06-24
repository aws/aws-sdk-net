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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// This is the response object from the CreateDataIntegration operation.
    /// </summary>
    public partial class CreateDataIntegrationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clientToken;
        private string _description;
        private FileConfiguration _fileConfiguration;
        private string _id;
        private string _kmsKey;
        private string _name;
        private Dictionary<string, Dictionary<string, List<string>>> _objectConfiguration = new Dictionary<string, Dictionary<string, List<string>>>();
        private ScheduleConfiguration _scheduleConfiguration;
        private string _sourceURI;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the DataIntegration.
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
        /// Gets and sets the property FileConfiguration. 
        /// <para>
        /// The configuration for what files should be pulled from the source.
        /// </para>
        /// </summary>
        public FileConfiguration FileConfiguration
        {
            get { return this._fileConfiguration; }
            set { this._fileConfiguration = value; }
        }

        // Check to see if FileConfiguration property is set
        internal bool IsSetFileConfiguration()
        {
            return this._fileConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The KMS key for the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectConfiguration. 
        /// <para>
        /// The configuration for what data should be pulled from the source.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> ObjectConfiguration
        {
            get { return this._objectConfiguration; }
            set { this._objectConfiguration = value; }
        }

        // Check to see if ObjectConfiguration property is set
        internal bool IsSetObjectConfiguration()
        {
            return this._objectConfiguration != null && this._objectConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The name of the data and how often it should be pulled from the source.
        /// </para>
        /// </summary>
        public ScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SourceURI. 
        /// <para>
        /// The URI of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string SourceURI
        {
            get { return this._sourceURI; }
            set { this._sourceURI = value; }
        }

        // Check to see if SourceURI property is set
        internal bool IsSetSourceURI()
        {
            return this._sourceURI != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}