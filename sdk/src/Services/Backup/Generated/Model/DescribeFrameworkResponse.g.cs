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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeFramework operation.
    /// </summary>
    public partial class DescribeFrameworkResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a framework is created, in ISO 8601 representation. The value
        /// of <c>CreationTime</c> is accurate to milliseconds. For example, 2020-07-10T15:00:00.000-08:00
        /// represents the 10th of July 2020 at 3:00 PM 8 hours behind UTC.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The deployment status of a framework. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATE_IN_PROGRESS | UPDATE_IN_PROGRESS | DELETE_IN_PROGRESS | COMPLETED | FAILED</c>
        /// 
        /// </para>
        /// </summary>
        public string DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property FrameworkArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string FrameworkArn { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkArn property is set.
        /// </summary>
        internal bool IsSetFrameworkArn() => this.FrameworkArn != null;

        /// <summary>
        /// Gets and sets the property FrameworkControls. 
        /// <para>
        /// The controls that make up the framework. Each control in the list has a name, input
        /// parameters, and scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FrameworkControl> FrameworkControls { get; set; } = AWSConfigs.InitializeCollections ? new List<FrameworkControl>() : null;

        /// <summary>
        /// Checks to see if the FrameworkControls property is set.
        /// </summary>
        internal bool IsSetFrameworkControls() => this.FrameworkControls != null && (this.FrameworkControls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// An optional description of the framework.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FrameworkDescription { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkDescription property is set.
        /// </summary>
        internal bool IsSetFrameworkDescription() => this.FrameworkDescription != null;

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        /// The unique name of a framework.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FrameworkName { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkName property is set.
        /// </summary>
        internal bool IsSetFrameworkName() => this.FrameworkName != null;

        /// <summary>
        /// Gets and sets the property FrameworkStatus. 
        /// <para>
        /// A framework consists of one or more controls. Each control governs a resource, such
        /// as backup plans, backup selections, backup vaults, or recovery points. You can also
        /// turn Config recording on or off for each resource. The statuses are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> when recording is turned on for all resources governed by the framework.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIALLY_ACTIVE</c> when recording is turned off for at least one resource governed
        /// by the framework.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> when recording is turned off for all resources governed by the framework.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNAVAILABLE</c> when Backup is unable to validate recording status at this time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FrameworkStatus { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkStatus property is set.
        /// </summary>
        internal bool IsSetFrameworkStatus() => this.FrameworkStatus != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>DescribeFrameworkOutput</c>. Retrying a successful request with the same
        /// idempotency token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;
    }
}
