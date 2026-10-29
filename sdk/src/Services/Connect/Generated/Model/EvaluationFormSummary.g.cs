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
    public partial class EvaluationFormSummary
    {
        /// <summary>
        /// Gets and sets the property ActiveVersion. 
        /// <para>
        /// The version of the active evaluation form version.
        /// </para>
        /// </summary>
        public int? ActiveVersion { get; set; }

        /// <summary>
        /// Checks to see if the ActiveVersion property is set.
        /// </summary>
        internal bool IsSetActiveVersion() => this.ActiveVersion.HasValue;

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
        /// Gets and sets the property LastActivatedBy. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the user who last activated the evaluation form.
        /// </para>
        /// </summary>
        public string LastActivatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastActivatedBy property is set.
        /// </summary>
        internal bool IsSetLastActivatedBy() => this.LastActivatedBy != null;

        /// <summary>
        /// Gets and sets the property LastActivatedTime. 
        /// <para>
        /// The timestamp for when the evaluation form was last activated.
        /// </para>
        /// </summary>
        public DateTime? LastActivatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastActivatedTime property is set.
        /// </summary>
        internal bool IsSetLastActivatedTime() => this.LastActivatedTime.HasValue;

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
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The version number of the latest evaluation form version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
