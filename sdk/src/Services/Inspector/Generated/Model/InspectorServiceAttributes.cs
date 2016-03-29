/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used in the <a>Finding</a> data type.
    /// </summary>
    public partial class InspectorServiceAttributes
    {
        private string _assessmentRunArn;
        private string _rulesPackageArn;
        private int? _schemaVersion;

        /// <summary>
        /// Gets and sets the property AssessmentRunArn. 
        /// <para>
        /// The ARN of the assessment run during which the fidning is generated.
        /// </para>
        /// </summary>
        public string AssessmentRunArn
        {
            get { return this._assessmentRunArn; }
            set { this._assessmentRunArn = value; }
        }

        // Check to see if AssessmentRunArn property is set
        internal bool IsSetAssessmentRunArn()
        {
            return this._assessmentRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArn. 
        /// <para>
        /// The ARN of the rules package used to generate the finding.
        /// </para>
        /// </summary>
        public string RulesPackageArn
        {
            get { return this._rulesPackageArn; }
            set { this._rulesPackageArn = value; }
        }

        // Check to see if RulesPackageArn property is set
        internal bool IsSetRulesPackageArn()
        {
            return this._rulesPackageArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The schema version of this data type.
        /// </para>
        /// </summary>
        public int SchemaVersion
        {
            get { return this._schemaVersion.GetValueOrDefault(); }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion.HasValue; 
        }

    }
}