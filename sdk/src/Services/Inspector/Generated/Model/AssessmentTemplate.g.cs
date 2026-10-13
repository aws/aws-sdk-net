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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Amazon Inspector assessment template. This data type
    /// is used as the response element in the <a>DescribeAssessmentTemplates</a> action.
    /// </summary>
    public partial class AssessmentTemplate
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the assessment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssessmentRunCount. 
        /// <para>
        /// The number of existing assessment runs associated with this assessment template. This
        /// value can be zero or a positive integer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? AssessmentRunCount { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentRunCount property is set.
        /// </summary>
        internal bool IsSetAssessmentRunCount() => this.AssessmentRunCount.HasValue;

        /// <summary>
        /// Gets and sets the property AssessmentTargetArn. 
        /// <para>
        /// The ARN of the assessment target that corresponds to this assessment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string AssessmentTargetArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentTargetArn property is set.
        /// </summary>
        internal bool IsSetAssessmentTargetArn() => this.AssessmentTargetArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the assessment template is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration in seconds specified for this assessment template. The default value
        /// is 3600 seconds (one hour). The maximum value is 86400 seconds (one day).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 180, Max = 86400)]
        public int? DurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationInSeconds property is set.
        /// </summary>
        internal bool IsSetDurationInSeconds() => this.DurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property LastAssessmentRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the most recent assessment run associated with this
        /// assessment template. This value exists only when the value of assessmentRunCount is
        /// greaterpa than zero.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string LastAssessmentRunArn { get; set; }

        /// <summary>
        /// Checks to see if the LastAssessmentRunArn property is set.
        /// </summary>
        internal bool IsSetLastAssessmentRunArn() => this.LastAssessmentRunArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the assessment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// The rules packages that are specified for this assessment template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<string> RulesPackageArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RulesPackageArns property is set.
        /// </summary>
        internal bool IsSetRulesPackageArns() => this.RulesPackageArns != null && (this.RulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserAttributesForFindings. 
        /// <para>
        /// The user-defined attributes that are assigned to every generated finding from the
        /// assessment run that uses this assessment template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public List<Attribute> UserAttributesForFindings { get; set; } = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Checks to see if the UserAttributesForFindings property is set.
        /// </summary>
        internal bool IsSetUserAttributesForFindings() => this.UserAttributesForFindings != null && (this.UserAttributesForFindings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
