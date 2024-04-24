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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Structure holding all <c>APPFLOW_INTEGRATION</c> specific workflow attributes.
    /// </summary>
    public partial class AppflowIntegrationWorkflowAttributes
    {
        private string _connectorProfileName;
        private string _roleArn;
        private SourceConnectorType _sourceConnectorType;

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        /// The name of the AppFlow connector profile used for ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ConnectorProfileName
        {
            get { return this._connectorProfileName; }
            set { this._connectorProfileName = value; }
        }

        // Check to see if ConnectorProfileName property is set
        internal bool IsSetConnectorProfileName()
        {
            return this._connectorProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. Customer Profiles assumes this role
        /// to create resources on your behalf as part of workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property SourceConnectorType. 
        /// <para>
        /// Specifies the source connector type, such as Salesforce, ServiceNow, and Marketo.
        /// Indicates source of ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceConnectorType SourceConnectorType
        {
            get { return this._sourceConnectorType; }
            set { this._sourceConnectorType = value; }
        }

        // Check to see if SourceConnectorType property is set
        internal bool IsSetSourceConnectorType()
        {
            return this._sourceConnectorType != null;
        }

    }
}