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
    /// Status details of a conformance pack.
    /// </summary>
    public partial class ConformancePackStatusDetail
    {
        /// <summary>
        /// Gets and sets the property ConformancePackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of comformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ConformancePackArn { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackArn property is set.
        /// </summary>
        internal bool IsSetConformancePackArn() => this.ConformancePackArn != null;

        /// <summary>
        /// Gets and sets the property ConformancePackId. 
        /// <para>
        /// ID of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ConformancePackId { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackId property is set.
        /// </summary>
        internal bool IsSetConformancePackId() => this.ConformancePackId != null;

        /// <summary>
        /// Gets and sets the property ConformancePackName. 
        /// <para>
        /// Name of the conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConformancePackName { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackName property is set.
        /// </summary>
        internal bool IsSetConformancePackName() => this.ConformancePackName != null;

        /// <summary>
        /// Gets and sets the property ConformancePackState. 
        /// <para>
        /// Indicates deployment status of conformance pack.
        /// </para>
        ///  
        /// <para>
        /// Config sets the state of the conformance pack to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE_IN_PROGRESS when a conformance pack creation is in progress for an account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_COMPLETE when a conformance pack has been successfully created in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED when a conformance pack creation failed in your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_IN_PROGRESS when a conformance pack deletion is in progress. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED when a conformance pack deletion failed in your account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConformancePackState ConformancePackState { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackState property is set.
        /// </summary>
        internal bool IsSetConformancePackState() => this.ConformancePackState != null;

        /// <summary>
        /// Gets and sets the property ConformancePackStatusReason. 
        /// <para>
        /// The reason of conformance pack creation failure.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string ConformancePackStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ConformancePackStatusReason property is set.
        /// </summary>
        internal bool IsSetConformancePackStatusReason() => this.ConformancePackStatusReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdateCompletedTime. 
        /// <para>
        /// Last time when conformation pack creation and update was successful.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateCompletedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateCompletedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateCompletedTime() => this.LastUpdateCompletedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateRequestedTime. 
        /// <para>
        /// Last time when conformation pack creation and update was requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdateRequestedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateRequestedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateRequestedTime() => this.LastUpdateRequestedTime.HasValue;

        /// <summary>
        /// Gets and sets the property StackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of CloudFormation stack. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string StackArn { get; set; }

        /// <summary>
        /// Checks to see if the StackArn property is set.
        /// </summary>
        internal bool IsSetStackArn() => this.StackArn != null;
    }
}
