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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Details about a teacher model used for model customization.
    /// </summary>
    public partial class TeacherModelConfig
    {
        private int? _maxResponseLengthForInference;
        private string _teacherModelIdentifier;

        /// <summary>
        /// Gets and sets the property MaxResponseLengthForInference. 
        /// <para>
        /// The maximum number of tokens requested when the customization job invokes the teacher
        /// model.
        /// </para>
        /// </summary>
        public int? MaxResponseLengthForInference
        {
            get { return this._maxResponseLengthForInference; }
            set { this._maxResponseLengthForInference = value; }
        }

        // Check to see if MaxResponseLengthForInference property is set
        internal bool IsSetMaxResponseLengthForInference()
        {
            return this._maxResponseLengthForInference.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TeacherModelIdentifier. 
        /// <para>
        /// The identifier of the teacher model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TeacherModelIdentifier
        {
            get { return this._teacherModelIdentifier; }
            set { this._teacherModelIdentifier = value; }
        }

        // Check to see if TeacherModelIdentifier property is set
        internal bool IsSetTeacherModelIdentifier()
        {
            return this._teacherModelIdentifier != null;
        }

    }
}