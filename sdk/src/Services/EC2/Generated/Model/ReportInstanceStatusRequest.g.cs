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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ReportInstanceStatus operation. Submits feedback
    /// about the status of an instance. The instance must be in the <c>running</c> state.
    /// If your experience with the instance differs from the instance status returned by
    /// <a>DescribeInstanceStatus</a>, use <a>ReportInstanceStatus</a> to report your experience
    /// with the instance. Amazon EC2 collects this information to improve the accuracy of
    /// status checks. <para> Use of this action does not change the value returned by <a>DescribeInstanceStatus</a>.
    /// </para>
    /// </summary>
    public partial class ReportInstanceStatusRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive text about the health state of your instance.
        /// </para>
        /// </summary>
        [Obsolete("This member has been deprecated")]
        [AWSProperty(Sensitive = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the reported instance health state ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReasonCodes. 
        /// <para>
        /// The reason codes that describe the health state of your instance.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>instance-stuck-in-state</c>: My instance is stuck in a state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unresponsive</c>: My instance is unresponsive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>not-accepting-credentials</c>: My instance is not accepting my credentials.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>password-not-available</c>: A password is not available for my instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>performance-network</c>: My instance is experiencing performance problems that
        /// I believe are network related.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>performance-instance-store</c>: My instance is experiencing performance problems
        /// that I believe are related to the instance stores.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>performance-ebs-volume</c>: My instance is experiencing performance problems that
        /// I believe are related to an EBS volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>performance-other</c>: My instance is experiencing performance problems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>other</c>: [explain using the description parameter]
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ReasonCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReasonCodes property is set.
        /// </summary>
        internal bool IsSetReasonCodes() => this.ReasonCodes != null && (this.ReasonCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the reported instance health state began.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of all instances listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
