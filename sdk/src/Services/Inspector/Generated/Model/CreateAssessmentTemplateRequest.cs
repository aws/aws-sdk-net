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
    /// Container for the parameters to the CreateAssessmentTemplate operation.
    /// Creates an assessment template for the assessment target that is specified by the
    /// ARN of the assessment target. If the <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_slr.html">service-linked
    /// role</a> isn’t already registered, this action also creates and registers a service-linked
    /// role to grant Amazon Inspector access to AWS Services needed to perform security assessments.
    /// </summary>
    public partial class CreateAssessmentTemplateRequest : AmazonInspectorRequest
    {
        private string _assessmentTargetArn;
        private string _assessmentTemplateName;
        private int? _durationInSeconds;
        private List<string> _rulesPackageArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Attribute> _userAttributesForFindings = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;

        /// <summary>
        /// Gets and sets the property AssessmentTargetArn. 
        /// <para>
        /// The ARN that specifies the assessment target for which you want to create the assessment
        /// template.
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
        /// Gets and sets the property AssessmentTemplateName. 
        /// <para>
        /// The user-defined name that identifies the assessment template that you want to create.
        /// You can create several assessment templates for an assessment target. The names of
        /// the assessment templates that correspond to a particular assessment target must be
        /// unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string AssessmentTemplateName
        {
            get { return this._assessmentTemplateName; }
            set { this._assessmentTemplateName = value; }
        }

        // Check to see if AssessmentTemplateName property is set
        internal bool IsSetAssessmentTemplateName()
        {
            return this._assessmentTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The duration of the assessment run in seconds.
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
        /// Gets and sets the property RulesPackageArns. 
        /// <para>
        /// The ARNs that specify the rules packages that you want to attach to the assessment
        /// template.
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
        /// The user-defined attributes that are assigned to every finding that is generated by
        /// the assessment run that uses this assessment template. An attribute is a key and value
        /// pair (an <a>Attribute</a> object). Within an assessment template, each key must be
        /// unique.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
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