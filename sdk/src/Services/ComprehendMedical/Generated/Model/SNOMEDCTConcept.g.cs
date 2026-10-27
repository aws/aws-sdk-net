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

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// The SNOMED-CT concepts that the entity could refer to, along with a score indicating
    /// the likelihood of the match.
    /// </summary>
    public partial class SNOMEDCTConcept
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        ///  The numeric ID for the SNOMED-CT concept. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the SNOMED-CT concept. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        ///  The level of confidence Amazon Comprehend Medical has that the entity should be linked
        /// to the identified SNOMED-CT concept. 
        /// </para>
        /// </summary>
        public float? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;
    }
}
