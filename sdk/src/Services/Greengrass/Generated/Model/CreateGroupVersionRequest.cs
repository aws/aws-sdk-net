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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroupVersion operation.
    /// Creates a version of a group which has already been defined.
    /// </summary>
    public partial class CreateGroupVersionRequest : AmazonGreengrassRequest
    {
        private string _amznClientToken;
        private string _connectorDefinitionVersionArn;
        private string _coreDefinitionVersionArn;
        private string _deviceDefinitionVersionArn;
        private string _functionDefinitionVersionArn;
        private string _groupId;
        private string _loggerDefinitionVersionArn;
        private string _resourceDefinitionVersionArn;
        private string _subscriptionDefinitionVersionArn;

        /// <summary>
        /// Gets and sets the property AmznClientToken. A client token used to correlate requests
        /// and responses.
        /// </summary>
        public string AmznClientToken
        {
            get { return this._amznClientToken; }
            set { this._amznClientToken = value; }
        }

        // Check to see if AmznClientToken property is set
        internal bool IsSetAmznClientToken()
        {
            return this._amznClientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorDefinitionVersionArn. The ARN of the connector
        /// definition version for this group.
        /// </summary>
        public string ConnectorDefinitionVersionArn
        {
            get { return this._connectorDefinitionVersionArn; }
            set { this._connectorDefinitionVersionArn = value; }
        }

        // Check to see if ConnectorDefinitionVersionArn property is set
        internal bool IsSetConnectorDefinitionVersionArn()
        {
            return this._connectorDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property CoreDefinitionVersionArn. The ARN of the core definition
        /// version for this group.
        /// </summary>
        public string CoreDefinitionVersionArn
        {
            get { return this._coreDefinitionVersionArn; }
            set { this._coreDefinitionVersionArn = value; }
        }

        // Check to see if CoreDefinitionVersionArn property is set
        internal bool IsSetCoreDefinitionVersionArn()
        {
            return this._coreDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceDefinitionVersionArn. The ARN of the device definition
        /// version for this group.
        /// </summary>
        public string DeviceDefinitionVersionArn
        {
            get { return this._deviceDefinitionVersionArn; }
            set { this._deviceDefinitionVersionArn = value; }
        }

        // Check to see if DeviceDefinitionVersionArn property is set
        internal bool IsSetDeviceDefinitionVersionArn()
        {
            return this._deviceDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionDefinitionVersionArn. The ARN of the function definition
        /// version for this group.
        /// </summary>
        public string FunctionDefinitionVersionArn
        {
            get { return this._functionDefinitionVersionArn; }
            set { this._functionDefinitionVersionArn = value; }
        }

        // Check to see if FunctionDefinitionVersionArn property is set
        internal bool IsSetFunctionDefinitionVersionArn()
        {
            return this._functionDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. The ID of the Greengrass group.
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property LoggerDefinitionVersionArn. The ARN of the logger definition
        /// version for this group.
        /// </summary>
        public string LoggerDefinitionVersionArn
        {
            get { return this._loggerDefinitionVersionArn; }
            set { this._loggerDefinitionVersionArn = value; }
        }

        // Check to see if LoggerDefinitionVersionArn property is set
        internal bool IsSetLoggerDefinitionVersionArn()
        {
            return this._loggerDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDefinitionVersionArn. The ARN of the resource definition
        /// version for this group.
        /// </summary>
        public string ResourceDefinitionVersionArn
        {
            get { return this._resourceDefinitionVersionArn; }
            set { this._resourceDefinitionVersionArn = value; }
        }

        // Check to see if ResourceDefinitionVersionArn property is set
        internal bool IsSetResourceDefinitionVersionArn()
        {
            return this._resourceDefinitionVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionDefinitionVersionArn. The ARN of the subscription
        /// definition version for this group.
        /// </summary>
        public string SubscriptionDefinitionVersionArn
        {
            get { return this._subscriptionDefinitionVersionArn; }
            set { this._subscriptionDefinitionVersionArn = value; }
        }

        // Check to see if SubscriptionDefinitionVersionArn property is set
        internal bool IsSetSubscriptionDefinitionVersionArn()
        {
            return this._subscriptionDefinitionVersionArn != null;
        }

    }
}