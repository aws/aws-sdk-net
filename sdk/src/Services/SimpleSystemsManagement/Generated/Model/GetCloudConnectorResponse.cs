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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetCloudConnector operation.
    /// </summary>
    public partial class GetCloudConnectorResponse : AmazonWebServiceResponse
    {
        private string _cloudConnectorArn;
        private string _configConnectorArn;
        private CloudConnectorConfiguration _configuration;
        private DateTime? _createdAt;
        private string _description;
        private string _displayName;
        private string _roleArn;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CloudConnectorArn. 
        /// <para>
        /// The ARN of the cloud connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CloudConnectorArn
        {
            get { return this._cloudConnectorArn; }
            set { this._cloudConnectorArn = value; }
        }

        // Check to see if CloudConnectorArn property is set
        internal bool IsSetCloudConnectorArn()
        {
            return this._cloudConnectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigConnectorArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Config connector associated with this cloud connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ConfigConnectorArn
        {
            get { return this._configConnectorArn; }
            set { this._configConnectorArn = value; }
        }

        // Check to see if ConfigConnectorArn property is set
        internal bool IsSetConfigConnectorArn()
        {
            return this._configConnectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration details for the third-party cloud environment connection.
        /// </para>
        /// </summary>
        public CloudConnectorConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the cloud connector was created.
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
        /// The description of the cloud connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The friendly name of the cloud connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role used by the cloud connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the cloud connector was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}