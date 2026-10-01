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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information about a group version.
    /// </summary>
    public partial class GroupVersion
    {
        /// <summary>
        /// Gets and sets the property ConnectorDefinitionVersionArn. The ARN of the connector
        /// definition version for this group.
        /// </summary>
        public string ConnectorDefinitionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorDefinitionVersionArn property is set.
        /// </summary>
        internal bool IsSetConnectorDefinitionVersionArn() => this.ConnectorDefinitionVersionArn != null;

        /// <summary>
        /// Gets and sets the property CoreDefinitionVersionArn. The ARN of the core definition
        /// version for this group.
        /// </summary>
        public string CoreDefinitionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreDefinitionVersionArn property is set.
        /// </summary>
        internal bool IsSetCoreDefinitionVersionArn() => this.CoreDefinitionVersionArn != null;

        /// <summary>
        /// Gets and sets the property DeviceDefinitionVersionArn. The ARN of the device definition
        /// version for this group.
        /// </summary>
        public string DeviceDefinitionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceDefinitionVersionArn property is set.
        /// </summary>
        internal bool IsSetDeviceDefinitionVersionArn() => this.DeviceDefinitionVersionArn != null;

        /// <summary>
        /// Gets and sets the property FunctionDefinitionVersionArn. The ARN of the function definition
        /// version for this group.
        /// </summary>
        public string FunctionDefinitionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionDefinitionVersionArn property is set.
        /// </summary>
        internal bool IsSetFunctionDefinitionVersionArn() => this.FunctionDefinitionVersionArn != null;

        /// <summary>
        /// Gets and sets the property LoggerDefinitionVersionArn. The ARN of the logger definition
        /// version for this group.
        /// </summary>
        public string LoggerDefinitionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the LoggerDefinitionVersionArn property is set.
        /// </summary>
        internal bool IsSetLoggerDefinitionVersionArn() => this.LoggerDefinitionVersionArn != null;

        /// <summary>
        /// Gets and sets the property ResourceDefinitionVersionArn. The ARN of the resource definition
        /// version for this group.
        /// </summary>
        public string ResourceDefinitionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDefinitionVersionArn property is set.
        /// </summary>
        internal bool IsSetResourceDefinitionVersionArn() => this.ResourceDefinitionVersionArn != null;

        /// <summary>
        /// Gets and sets the property SubscriptionDefinitionVersionArn. The ARN of the subscription
        /// definition version for this group.
        /// </summary>
        public string SubscriptionDefinitionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionDefinitionVersionArn property is set.
        /// </summary>
        internal bool IsSetSubscriptionDefinitionVersionArn() => this.SubscriptionDefinitionVersionArn != null;
    }
}
