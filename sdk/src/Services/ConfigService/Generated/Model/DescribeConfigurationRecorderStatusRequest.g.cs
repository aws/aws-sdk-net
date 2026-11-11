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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationRecorderStatus operation.
    /// Returns the current status of the configuration recorder you specify as well as the
    /// status of the last recording event for the configuration recorders. <para> For a detailed
    /// status of recording events over time, add your Config events to Amazon CloudWatch
    /// metrics and use CloudWatch metrics. </para> <para> If a configuration recorder is
    /// not specified, this operation returns the status for the customer managed configuration
    /// recorder configured for the account, if applicable. </para> <note> <para> When making
    /// a request to this operation, you can only specify one configuration recorder. </para>
    /// </note>
    /// </summary>
    public partial class DescribeConfigurationRecorderStatusRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration recorder that you want to specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorderNames. 
        /// <para>
        /// The name of the configuration recorder. If the name is not specified, the operation
        /// returns the status for the customer managed configuration recorder configured for
        /// the account, if applicable.
        /// </para>
        ///  <note> 
        /// <para>
        /// When making a request to this operation, you can only specify one configuration recorder.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConfigurationRecorderNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConfigurationRecorderNames property is set.
        /// </summary>
        internal bool IsSetConfigurationRecorderNames() => this.ConfigurationRecorderNames != null && (this.ConfigurationRecorderNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// For service-linked configuration recorders, you can use the service principal of the
        /// linked Amazon Web Services service to specify the configuration recorder. This field
        /// is only supported for Amazon Web Services service principals. For third-party service-linked
        /// configuration recorders, use <c>Arn</c> instead.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ServicePrincipal property is set.
        /// </summary>
        internal bool IsSetServicePrincipal() => this.ServicePrincipal != null;
    }
}
