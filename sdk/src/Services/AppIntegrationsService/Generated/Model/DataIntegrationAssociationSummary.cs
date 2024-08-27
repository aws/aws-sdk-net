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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Summary information about the DataIntegration association.
    /// </summary>
    public partial class DataIntegrationAssociationSummary
    {
        private string _clientId;
        private string _dataIntegrationArn;
        private string _dataIntegrationAssociationArn;
        private string _destinationURI;
        private ExecutionConfiguration _executionConfiguration;
        private LastExecutionStatus _lastExecutionStatus;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The identifier for the client that is associated with the DataIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property DataIntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DataIntegrationArn
        {
            get { return this._dataIntegrationArn; }
            set { this._dataIntegrationArn = value; }
        }

        // Check to see if DataIntegrationArn property is set
        internal bool IsSetDataIntegrationArn()
        {
            return this._dataIntegrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataIntegrationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DataIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DataIntegrationAssociationArn
        {
            get { return this._dataIntegrationAssociationArn; }
            set { this._dataIntegrationAssociationArn = value; }
        }

        // Check to see if DataIntegrationAssociationArn property is set
        internal bool IsSetDataIntegrationAssociationArn()
        {
            return this._dataIntegrationAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationURI. 
        /// <para>
        /// The URI of the data destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DestinationURI
        {
            get { return this._destinationURI; }
            set { this._destinationURI = value; }
        }

        // Check to see if DestinationURI property is set
        internal bool IsSetDestinationURI()
        {
            return this._destinationURI != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration.
        /// </summary>
        public ExecutionConfiguration ExecutionConfiguration
        {
            get { return this._executionConfiguration; }
            set { this._executionConfiguration = value; }
        }

        // Check to see if ExecutionConfiguration property is set
        internal bool IsSetExecutionConfiguration()
        {
            return this._executionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastExecutionStatus. 
        /// <para>
        /// The execution status of the last job.
        /// </para>
        /// </summary>
        public LastExecutionStatus LastExecutionStatus
        {
            get { return this._lastExecutionStatus; }
            set { this._lastExecutionStatus = value; }
        }

        // Check to see if LastExecutionStatus property is set
        internal bool IsSetLastExecutionStatus()
        {
            return this._lastExecutionStatus != null;
        }

    }
}