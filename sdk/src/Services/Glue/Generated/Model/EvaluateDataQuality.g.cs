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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies your data quality evaluation criteria.
    /// </summary>
    public partial class EvaluateDataQuality
    {
        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The inputs of your data quality evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> Inputs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Inputs property is set.
        /// </summary>
        internal bool IsSetInputs() => this.Inputs != null && (this.Inputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data quality evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// The output of your data quality evaluation.
        /// </para>
        /// </summary>
        public DQTransformOutput Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property PublishingOptions. 
        /// <para>
        /// Options to configure how your results are published.
        /// </para>
        /// </summary>
        public DQResultsPublishingOptions PublishingOptions { get; set; }

        /// <summary>
        /// Checks to see if the PublishingOptions property is set.
        /// </summary>
        internal bool IsSetPublishingOptions() => this.PublishingOptions != null;

        /// <summary>
        /// Gets and sets the property Ruleset. 
        /// <para>
        /// The ruleset for your data quality evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 65536)]
        public string Ruleset { get; set; }

        /// <summary>
        /// Checks to see if the Ruleset property is set.
        /// </summary>
        internal bool IsSetRuleset() => this.Ruleset != null;

        /// <summary>
        /// Gets and sets the property StopJobOnFailureOptions. 
        /// <para>
        /// Options to configure how your job will stop if your data quality evaluation fails.
        /// </para>
        /// </summary>
        public DQStopJobOnFailureOptions StopJobOnFailureOptions { get; set; }

        /// <summary>
        /// Checks to see if the StopJobOnFailureOptions property is set.
        /// </summary>
        internal bool IsSetStopJobOnFailureOptions() => this.StopJobOnFailureOptions != null;
    }
}
