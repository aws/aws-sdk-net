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
    /// This is the response object from the GetEventLogConfiguration operation.
    /// </summary>
    public partial class GetEventLogConfigurationResponse : AmazonWebServiceResponse
    {
        private LogLevel _eventLogLevel;
        private string _id;
        private string _resourceId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property EventLogLevel. 
        /// <para>
        /// The logging level for the event log configuration.
        /// </para>
        /// </summary>
        public LogLevel EventLogLevel
        {
            get { return this._eventLogLevel; }
            set { this._eventLogLevel = value; }
        }

        // Check to see if EventLogLevel property is set
        internal bool IsSetEventLogLevel()
        {
            return this._eventLogLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the event log configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the resource for the event log configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource for the event log configuration.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}