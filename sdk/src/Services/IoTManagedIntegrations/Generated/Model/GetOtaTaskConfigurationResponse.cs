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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// This is the response object from the GetOtaTaskConfiguration operation.
    /// </summary>
    public partial class GetOtaTaskConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _description;
        private string _name;
        private PushConfig _pushConfig;
        private string _taskConfigurationId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp value of when the over-the-air (OTA) task configuration was created
        /// at.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the over-the-air (OTA) task configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the over-the-air (OTA) task configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property PushConfig. 
        /// <para>
        /// Describes the type of configuration used for the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public PushConfig PushConfig
        {
            get { return this._pushConfig; }
            set { this._pushConfig = value; }
        }

        // Check to see if PushConfig property is set
        internal bool IsSetPushConfig()
        {
            return this._pushConfig != null;
        }

        /// <summary>
        /// Gets and sets the property TaskConfigurationId. 
        /// <para>
        /// The over-the-air (OTA) task configuration id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TaskConfigurationId
        {
            get { return this._taskConfigurationId; }
            set { this._taskConfigurationId = value; }
        }

        // Check to see if TaskConfigurationId property is set
        internal bool IsSetTaskConfigurationId()
        {
            return this._taskConfigurationId != null;
        }

    }
}