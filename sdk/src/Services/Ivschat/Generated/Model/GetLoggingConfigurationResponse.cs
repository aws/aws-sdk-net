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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
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
namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// This is the response object from the GetLoggingConfiguration operation.
    /// </summary>
    public partial class GetLoggingConfigurationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createTime;
        private DestinationConfiguration _destinationConfiguration;
        private string _id;
        private string _name;
        private LoggingConfigurationState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Logging-configuration ARN, from the request (if <c>identifier</c> was an ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time when the logging configuration was created. This is an ISO 8601 timestamp; <i>note
        /// that this is returned as a string</i>.
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
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// A complex type that contains a destination configuration for where chat content will
        /// be logged. There is only one type of destination (<c>cloudWatchLogs</c>, <c>firehose</c>,
        /// or <c>s3</c>) in a <c>destinationConfiguration</c>.
        /// </para>
        /// </summary>
        public DestinationConfiguration DestinationConfiguration
        {
            get { return this._destinationConfiguration; }
            set { this._destinationConfiguration = value; }
        }

        // Check to see if DestinationConfiguration property is set
        internal bool IsSetDestinationConfiguration()
        {
            return this._destinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Logging-configuration ID, generated by the system. This is a relative identifier,
        /// the part of the ARN that uniquely identifies the logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Logging-configuration name. This value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the logging configuration. When the state is <c>ACTIVE</c>, the configuration
        /// is ready to log chat content.
        /// </para>
        /// </summary>
        public LoggingConfigurationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of maps, each of the form <c>string:string (key:value)</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// Time of the logging configuration’s last update. This is an ISO 8601 timestamp; <i>note
        /// that this is returned as a string</i>.
        /// </para>
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return this._updateTime; }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}