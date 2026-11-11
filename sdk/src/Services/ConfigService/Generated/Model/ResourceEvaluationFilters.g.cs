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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns details of a resource evaluation based on the selected filter.
    /// </summary>
    public partial class ResourceEvaluationFilters
    {
        /// <summary>
        /// Gets and sets the property EvaluationContextIdentifier. 
        /// <para>
        /// Filters evaluations for a given infrastructure deployment. For example: CFN Stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string EvaluationContextIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContextIdentifier property is set.
        /// </summary>
        internal bool IsSetEvaluationContextIdentifier() => this.EvaluationContextIdentifier != null;

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// Filters all resource evaluations results based on an evaluation mode.
        /// </para>
        ///  <important> 
        /// <para>
        /// Currently, <c>DECTECTIVE</c> is not supported as a valid value. Ignore other documentation
        /// stating otherwise.
        /// </para>
        ///  </important>
        /// </summary>
        public EvaluationMode EvaluationMode { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMode property is set.
        /// </summary>
        internal bool IsSetEvaluationMode() => this.EvaluationMode != null;

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// Returns a <c>TimeWindow</c> object.
        /// </para>
        /// </summary>
        public TimeWindow TimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the TimeWindow property is set.
        /// </summary>
        internal bool IsSetTimeWindow() => this.TimeWindow != null;
    }
}
