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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// This is the response object from the UpdateIntegration operation.
    /// </summary>
    public partial class UpdateIntegrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. When the integration was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IntegrationArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string IntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationArn() => this.IntegrationArn != null;

        /// <summary>
        /// Gets and sets the property IntegrationId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property IntegrationType.
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProviderDetails.
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderDetails ProviderDetails { get; set; }

        /// <summary>
        /// Checks to see if the ProviderDetails property is set.
        /// </summary>
        internal bool IsSetProviderDetails() => this.ProviderDetails != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. When the integration was last updated.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
