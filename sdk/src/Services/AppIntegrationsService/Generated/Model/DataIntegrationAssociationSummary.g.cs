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

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Summary information about the DataIntegration association.
    /// </summary>
    public partial class DataIntegrationAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The identifier for the client that is associated with the DataIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property DataIntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DataIntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the DataIntegrationArn property is set.
        /// </summary>
        internal bool IsSetDataIntegrationArn() => this.DataIntegrationArn != null;

        /// <summary>
        /// Gets and sets the property DataIntegrationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DataIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DataIntegrationAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the DataIntegrationAssociationArn property is set.
        /// </summary>
        internal bool IsSetDataIntegrationAssociationArn() => this.DataIntegrationAssociationArn != null;

        /// <summary>
        /// Gets and sets the property DestinationURI. 
        /// <para>
        /// The URI of the data destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DestinationURI { get; set; }

        /// <summary>
        /// Checks to see if the DestinationURI property is set.
        /// </summary>
        internal bool IsSetDestinationURI() => this.DestinationURI != null;

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration.
        /// </summary>
        public ExecutionConfiguration ExecutionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionConfiguration property is set.
        /// </summary>
        internal bool IsSetExecutionConfiguration() => this.ExecutionConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastExecutionStatus. 
        /// <para>
        /// The execution status of the last job.
        /// </para>
        /// </summary>
        public LastExecutionStatus LastExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutionStatus property is set.
        /// </summary>
        internal bool IsSetLastExecutionStatus() => this.LastExecutionStatus != null;
    }
}
