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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// Returns information about all configurations.
    /// </summary>
    public partial class Configuration
    {
        private string _arn;
        private AuthenticationStrategy _authenticationStrategy;
        private DateTime? _created;
        private string _description;
        private EngineType _engineType;
        private string _engineVersion;
        private string _id;
        private ConfigurationRevision _latestRevision;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Required. The ARN of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AuthenticationStrategy. 
        /// <para>
        /// Optional. The authentication strategy associated with the configuration. The default
        /// is SIMPLE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthenticationStrategy AuthenticationStrategy
        {
            get { return this._authenticationStrategy; }
            set { this._authenticationStrategy = value; }
        }

        // Check to see if AuthenticationStrategy property is set
        internal bool IsSetAuthenticationStrategy()
        {
            return this._authenticationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// Required. The date and time of the configuration revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Required. The description of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EngineType. 
        /// <para>
        /// Required. The type of broker engine. Currently, Amazon MQ supports ACTIVEMQ and RABBITMQ.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The broker engine version. Defaults to the latest available version for the specified
        /// broker engine type. For a list of supported engine versions, see the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/activemq-version-management.html">ActiveMQ
        /// version management</a> and the <a href="https://docs.aws.amazon.com//amazon-mq/latest/developer-guide/rabbitmq-version-management.html">RabbitMQ
        /// version management</a> sections in the Amazon MQ Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Required. The unique ID that Amazon MQ generates for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// Required. The latest revision of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationRevision LatestRevision
        {
            get { return this._latestRevision; }
            set { this._latestRevision = value; }
        }

        // Check to see if LatestRevision property is set
        internal bool IsSetLatestRevision()
        {
            return this._latestRevision != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Required. The name of the configuration. This value can contain only alphanumeric
        /// characters, dashes, periods, underscores, and tildes (- . _ ~). This value must be
        /// 1-150 characters long.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of all tags associated with this configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}