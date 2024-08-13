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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Options for the <c>GetTemplateSummary</c> API action.
    /// </summary>
    public partial class TemplateSummaryConfig
    {
        private bool? _treatUnrecognizedResourceTypesAsWarnings;

        /// <summary>
        /// Gets and sets the property TreatUnrecognizedResourceTypesAsWarnings. 
        /// <para>
        /// If set to <c>True</c>, any unrecognized resource types generate warnings and not an
        /// error. Any unrecognized resource types are returned in the <c>Warnings</c> output
        /// parameter.
        /// </para>
        /// </summary>
        public bool? TreatUnrecognizedResourceTypesAsWarnings
        {
            get { return this._treatUnrecognizedResourceTypesAsWarnings; }
            set { this._treatUnrecognizedResourceTypesAsWarnings = value; }
        }

        // Check to see if TreatUnrecognizedResourceTypesAsWarnings property is set
        internal bool IsSetTreatUnrecognizedResourceTypesAsWarnings()
        {
            return this._treatUnrecognizedResourceTypesAsWarnings.HasValue; 
        }

    }
}