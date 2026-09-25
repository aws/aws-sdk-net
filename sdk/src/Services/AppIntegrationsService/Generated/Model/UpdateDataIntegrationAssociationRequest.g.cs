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
    /// Container for the parameters to the UpdateDataIntegrationAssociation operation. Updates
    /// and persists a DataIntegrationAssociation resource. <note> <para> Updating a DataIntegrationAssociation
    /// with ExecutionConfiguration will rerun the on-demand job. </para> </note>
    /// </summary>
    public partial class UpdateDataIntegrationAssociationRequest : AmazonAppIntegrationsServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DataIntegrationAssociationIdentifier. 
        /// <para>
        /// A unique identifier. of the DataIntegrationAssociation resource
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DataIntegrationAssociationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DataIntegrationAssociationIdentifier property is set.
        /// </summary>
        internal bool IsSetDataIntegrationAssociationIdentifier() => this.DataIntegrationAssociationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DataIntegrationIdentifier. 
        /// <para>
        /// A unique identifier for the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DataIntegrationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DataIntegrationIdentifier property is set.
        /// </summary>
        internal bool IsSetDataIntegrationIdentifier() => this.DataIntegrationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration. 
        /// <para>
        /// The configuration for how the files should be pulled from the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionConfiguration ExecutionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionConfiguration property is set.
        /// </summary>
        internal bool IsSetExecutionConfiguration() => this.ExecutionConfiguration != null;
    }
}
