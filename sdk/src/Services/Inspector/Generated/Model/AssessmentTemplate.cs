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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
        private string _arn;
        private int? _assessmentRunCount;
        private string _assessmentTargetArn;
        private DateTime? _createdAt;
        private int? _durationInSeconds;
        private string _lastAssessmentRunArn;
        private string _name;
        private List<string> _rulesPackageArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Attribute> _userAttributesForFindings = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the assessment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentRunCount. 
        /// <para>
        /// The number of existing assessment runs associated with this assessment template. This
        /// value can be zero or a positive integer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? AssessmentRunCount
        {
            get { return this._assessmentRunCount; }
            set { this._assessmentRunCount = value; }
        }

        // Check to see if AssessmentRunCount property is set
        internal bool IsSetAssessmentRunCount()
        {
            return this._assessmentRunCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssessmentTargetArn. 
        /// <para>
        /// The ARN of the assessment target that corresponds to this assessment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string AssessmentTargetArn
        {
            get { return this._assessmentTargetArn; }
            set { this._assessmentTargetArn = value; }
        }

        // Check to see if AssessmentTargetArn property is set
        internal bool IsSetAssessmentTargetArn()
        {
            return this._assessmentTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the assessment template is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration in seconds specified for this assessment template. The default value
        /// is 3600 seconds (one hour). The maximum value is 86400 seconds (one day).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=180, Max=86400)]
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAssessmentRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the most recent assessment run associated with this
        /// assessment template. This value exists only when the value of assessmentRunCount is
        /// greaterpa than zero.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string LastAssessmentRunArn
        {
            get { return this._lastAssessmentRunArn; }
            set { this._lastAssessmentRunArn = value; }
        }

        // Check to see if LastAssessmentRunArn property is set
        internal bool IsSetLastAssessmentRunArn()
        {
            return this._lastAssessmentRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the assessment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// The rules packages that are specified for this assessment template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<string> RulesPackageArns
        {
            get { return this._rulesPackageArns; }
            set { this._rulesPackageArns = value; }
        }

        // Check to see if RulesPackageArns property is set
        internal bool IsSetRulesPackageArns()
        {
            return this._rulesPackageArns != null && (this._rulesPackageArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserAttributesForFindings. 
        /// <para>
        /// The user-defined attributes that are assigned to every generated finding from the
        /// assessment run that uses this assessment template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<Attribute> UserAttributesForFindings
        {
            get { return this._userAttributesForFindings; }
            set { this._userAttributesForFindings = value; }
        }

        // Check to see if UserAttributesForFindings property is set
        internal bool IsSetUserAttributesForFindings()
        {
            return this._userAttributesForFindings != null && (this._userAttributesForFindings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}