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
    /// Summary information about an evaluation form.
    /// </summary>
    public partial class EvaluationFormVersionSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the evaluation form was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationFormArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the evaluation form resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluationFormArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormArn property is set.
        /// </summary>
        internal bool IsSetEvaluationFormArn() => this.EvaluationFormArn != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EvaluationFormId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormId property is set.
        /// </summary>
        internal bool IsSetEvaluationFormId() => this.EvaluationFormId != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// A version of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EvaluationFormVersion { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormVersion property is set.
        /// </summary>
        internal bool IsSetEvaluationFormVersion() => this.EvaluationFormVersion.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp for when the evaluation form was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Locked. 
        /// <para>
        /// The flag indicating whether the evaluation form is locked for changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Locked { get; set; }

        /// <summary>
        /// Checks to see if the Locked property is set.
        /// </summary>
        internal bool IsSetLocked() => this.Locked.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationFormVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
