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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of the properties of a trial component. To get all the properties, call
    /// the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeTrialComponent.html">DescribeTrialComponent</a>
    /// API and provide the <c>TrialComponentName</c>.
    /// </summary>
    public partial class TrialComponentSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created the trial component.
        /// </para>
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the component was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the component as displayed. If <c>DisplayName</c> isn't specified, <c>TrialComponentName</c>
        /// is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the component ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who last modified the component.
        /// </para>
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the component was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the component started.
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
        /// The status of the component. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InProgress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Completed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TrialComponentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrialComponentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TrialComponentArn { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentArn property is set.
        /// </summary>
        internal bool IsSetTrialComponentArn() => this.TrialComponentArn != null;

        /// <summary>
        /// Gets and sets the property TrialComponentName. 
        /// <para>
        /// The name of the trial component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string TrialComponentName { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentName property is set.
        /// </summary>
        internal bool IsSetTrialComponentName() => this.TrialComponentName != null;

        /// <summary>
        /// Gets and sets the property TrialComponentSource.
        /// </summary>
        public TrialComponentSource TrialComponentSource { get; set; }

        /// <summary>
        /// Checks to see if the TrialComponentSource property is set.
        /// </summary>
        internal bool IsSetTrialComponentSource() => this.TrialComponentSource != null;
    }
}
