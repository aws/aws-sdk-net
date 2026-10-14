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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines a hyperparameter to be used by an algorithm.
    /// </summary>
    public partial class HyperParameterSpecification
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for this hyperparameter. If a default value is specified, a hyperparameter
        /// cannot be required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Indicates whether this hyperparameter is required.
        /// </para>
        /// </summary>
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Checks to see if the IsRequired property is set.
        /// </summary>
        internal bool IsSetIsRequired() => this.IsRequired.HasValue;

        /// <summary>
        /// Gets and sets the property IsTunable. 
        /// <para>
        /// Indicates whether this hyperparameter is tunable in a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public bool? IsTunable { get; set; }

        /// <summary>
        /// Checks to see if the IsTunable property is set.
        /// </summary>
        internal bool IsSetIsTunable() => this.IsTunable.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this hyperparameter. The name must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The allowed range for this hyperparameter.
        /// </para>
        /// </summary>
        public ParameterRange Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this hyperparameter. The valid types are <c>Integer</c>, <c>Continuous</c>,
        /// <c>Categorical</c>, and <c>FreeText</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParameterType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
