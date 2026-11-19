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
    /// The resolved value of an external source that is used by the conditions in an evaluation
    /// form.
    /// </summary>
    public partial class EvaluationResolvedSource
    {
        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The external source, such as contact data, evaluation metadata, form metadata, or
        /// AI metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationFormItemEnablementSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of resolving the source. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The source has not been resolved yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOLVED</c> - The source has been resolved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The source could not be resolved.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationItemResolutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The resolved values of the source. Present when <c>Status</c> is <c>RESOLVED</c>.
        /// Contains one value for a single-valued source, any number of values for a multi-valued
        /// source, and no values when the source is not present on the contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<EvaluationFormItemEnablementSourceValue> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationFormItemEnablementSourceValue>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
