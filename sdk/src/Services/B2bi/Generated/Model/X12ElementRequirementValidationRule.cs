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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Defines a validation rule that modifies the requirement status of a specific X12 element
    /// within a segment. This rule allows you to make optional elements mandatory or mandatory
    /// elements optional, providing flexibility to accommodate different trading partner
    /// requirements and business rules. The rule targets a specific element position within
    /// a segment and sets its requirement status to either OPTIONAL or MANDATORY.
    /// </summary>
    public partial class X12ElementRequirementValidationRule
    {
        private string _elementPosition;
        private ElementRequirement _requirement;

        /// <summary>
        /// Gets and sets the property ElementPosition. 
        /// <para>
        /// Specifies the position of the element within an X12 segment for which the requirement
        /// status will be modified. The format follows the pattern of segment identifier followed
        /// by element position (e.g., "ST-01" for the first element of the ST segment).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ElementPosition
        {
            get { return this._elementPosition; }
            set { this._elementPosition = value; }
        }

        // Check to see if ElementPosition property is set
        internal bool IsSetElementPosition()
        {
            return this._elementPosition != null;
        }

        /// <summary>
        /// Gets and sets the property Requirement. 
        /// <para>
        /// Specifies the requirement status for the element at the specified position. Valid
        /// values are OPTIONAL (the element may be omitted) or MANDATORY (the element must be
        /// present).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ElementRequirement Requirement
        {
            get { return this._requirement; }
            set { this._requirement = value; }
        }

        // Check to see if Requirement property is set
        internal bool IsSetRequirement()
        {
            return this._requirement != null;
        }

    }
}