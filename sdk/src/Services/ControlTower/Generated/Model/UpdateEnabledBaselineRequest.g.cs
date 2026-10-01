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

namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnabledBaseline operation. Updates an <c>EnabledBaseline</c>
    /// resource's applied parameters or version. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
    /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
    /// </summary>
    public partial class UpdateEnabledBaselineRequest : AmazonControlTowerRequest
    {
        /// <summary>
        /// Gets and sets the property BaselineVersion. 
        /// <para>
        /// Specifies the new <c>Baseline</c> version, to which the <c>EnabledBaseline</c> should
        /// be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string BaselineVersion { get; set; }

        /// <summary>
        /// Checks to see if the BaselineVersion property is set.
        /// </summary>
        internal bool IsSetBaselineVersion() => this.BaselineVersion != null;

        /// <summary>
        /// Gets and sets the property EnabledBaselineIdentifier. 
        /// <para>
        /// Specifies the <c>EnabledBaseline</c> resource to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EnabledBaselineIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnabledBaselineIdentifier property is set.
        /// </summary>
        internal bool IsSetEnabledBaselineIdentifier() => this.EnabledBaselineIdentifier != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Parameters to apply when making an update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnabledBaselineParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<EnabledBaselineParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
