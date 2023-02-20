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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about the associated AppIntegrations.
    /// </summary>
    public partial class IntegrationAssociationSummary
    {
        private string _instanceId;
        private string _integrationArn;
        private string _integrationAssociationArn;
        private string _integrationAssociationId;
        private IntegrationType _integrationType;
        private string _sourceApplicationName;
        private string _sourceApplicationUrl;
        private SourceType _sourceType;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the AppIntegration.
        /// </para>
        /// </summary>
        public string IntegrationArn
        {
            get { return this._integrationArn; }
            set { this._integrationArn = value; }
        }

        // Check to see if IntegrationArn property is set
        internal bool IsSetIntegrationArn()
        {
            return this._integrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the AppIntegration association.
        /// </para>
        /// </summary>
        public string IntegrationAssociationArn
        {
            get { return this._integrationAssociationArn; }
            set { this._integrationAssociationArn = value; }
        }

        // Check to see if IntegrationAssociationArn property is set
        internal bool IsSetIntegrationAssociationArn()
        {
            return this._integrationAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationAssociationId. 
        /// <para>
        /// The identifier for the AppIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string IntegrationAssociationId
        {
            get { return this._integrationAssociationId; }
            set { this._integrationAssociationId = value; }
        }

        // Check to see if IntegrationAssociationId property is set
        internal bool IsSetIntegrationAssociationId()
        {
            return this._integrationAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The integration type.
        /// </para>
        /// </summary>
        public IntegrationType IntegrationType
        {
            get { return this._integrationType; }
            set { this._integrationType = value; }
        }

        // Check to see if IntegrationType property is set
        internal bool IsSetIntegrationType()
        {
            return this._integrationType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceApplicationName. 
        /// <para>
        /// The user-provided, friendly name for the external application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SourceApplicationName
        {
            get { return this._sourceApplicationName; }
            set { this._sourceApplicationName = value; }
        }

        // Check to see if SourceApplicationName property is set
        internal bool IsSetSourceApplicationName()
        {
            return this._sourceApplicationName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceApplicationUrl. 
        /// <para>
        /// The URL for the external application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string SourceApplicationUrl
        {
            get { return this._sourceApplicationUrl; }
            set { this._sourceApplicationUrl = value; }
        }

        // Check to see if SourceApplicationUrl property is set
        internal bool IsSetSourceApplicationUrl()
        {
            return this._sourceApplicationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The name of the source.
        /// </para>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}