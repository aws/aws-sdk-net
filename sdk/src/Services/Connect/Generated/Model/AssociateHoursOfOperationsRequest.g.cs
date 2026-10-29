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
    /// Container for the parameters to the AssociateHoursOfOperations operation. Associates
    /// a set of hours of operations with another hours of operation. For more information
    /// about inheriting overrides from parent hours of operation, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/hours-of-operation-overrides.html">Hours
    /// of operation overrides</a> in the Administrator Guide.
    /// </summary>
    public partial class AssociateHoursOfOperationsRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier of the child hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HoursOfOperationId { get; set; }

        /// <summary>
        /// Checks to see if the HoursOfOperationId property is set.
        /// </summary>
        internal bool IsSetHoursOfOperationId() => this.HoursOfOperationId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ParentHoursOfOperationConfigs. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the parent hours of operation resources to associate
        /// with the child hours of operation resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 3)]
        public List<ParentHoursOfOperationConfig> ParentHoursOfOperationConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<ParentHoursOfOperationConfig>() : null;

        /// <summary>
        /// Checks to see if the ParentHoursOfOperationConfigs property is set.
        /// </summary>
        internal bool IsSetParentHoursOfOperationConfigs() => this.ParentHoursOfOperationConfigs != null && (this.ParentHoursOfOperationConfigs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
