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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about the associated AppIntegrations.
    /// </summary>
    public partial class IntegrationAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the AppIntegration.
        /// </para>
        /// </summary>
        public string IntegrationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationArn() => this.IntegrationArn != null;

        /// <summary>
        /// Gets and sets the property IntegrationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the AppIntegration association.
        /// </para>
        /// </summary>
        public string IntegrationAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationAssociationArn property is set.
        /// </summary>
        internal bool IsSetIntegrationAssociationArn() => this.IntegrationAssociationArn != null;

        /// <summary>
        /// Gets and sets the property IntegrationAssociationId. 
        /// <para>
        /// The identifier for the AppIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string IntegrationAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationAssociationId property is set.
        /// </summary>
        internal bool IsSetIntegrationAssociationId() => this.IntegrationAssociationId != null;

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The integration type.
        /// </para>
        /// </summary>
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property SourceApplicationName. 
        /// <para>
        /// The user-provided, friendly name for the external application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SourceApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceApplicationName property is set.
        /// </summary>
        internal bool IsSetSourceApplicationName() => this.SourceApplicationName != null;

        /// <summary>
        /// Gets and sets the property SourceApplicationUrl. 
        /// <para>
        /// The URL for the external application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string SourceApplicationUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceApplicationUrl property is set.
        /// </summary>
        internal bool IsSetSourceApplicationUrl() => this.SourceApplicationUrl != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The name of the source.
        /// </para>
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
