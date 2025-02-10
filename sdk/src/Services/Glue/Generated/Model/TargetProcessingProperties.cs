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
    /// The resource properties associated with the integration target.
    /// </summary>
    public partial class TargetProcessingProperties
    {
        private string _connectionName;
        private string _eventBusArn;
        private string _kmsArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The Glue network connection to configure the Glue job running in the customer VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ConnectionName
        {
            get { return this._connectionName; }
            set { this._connectionName = value; }
        }

        // Check to see if ConnectionName property is set
        internal bool IsSetConnectionName()
        {
            return this._connectionName != null;
        }

        /// <summary>
        /// Gets and sets the property EventBusArn. 
        /// <para>
        /// The ARN of an Eventbridge event bus to receive the integration status notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EventBusArn
        {
            get { return this._eventBusArn; }
            set { this._eventBusArn = value; }
        }

        // Check to see if EventBusArn property is set
        internal bool IsSetEventBusArn()
        {
            return this._eventBusArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        /// The ARN of the KMS key used for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsArn
        {
            get { return this._kmsArn; }
            set { this._kmsArn = value; }
        }

        // Check to see if KmsArn property is set
        internal bool IsSetKmsArn()
        {
            return this._kmsArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role to access the Glue database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}