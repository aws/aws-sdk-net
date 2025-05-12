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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private string _defaultValue;
        private string _description;
        private bool? _isRequired;
        private bool? _isTunable;
        private string _name;
        private ParameterRange _range;
        private ParameterType _type;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for this hyperparameter. If a default value is specified, a hyperparameter
        /// cannot be required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2500)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Indicates whether this hyperparameter is required.
        /// </para>
        /// </summary>
        public bool? IsRequired
        {
            get { return this._isRequired; }
            set { this._isRequired = value; }
        }

        // Check to see if IsRequired property is set
        internal bool IsSetIsRequired()
        {
            return this._isRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsTunable. 
        /// <para>
        /// Indicates whether this hyperparameter is tunable in a hyperparameter tuning job.
        /// </para>
        /// </summary>
        public bool? IsTunable
        {
            get { return this._isTunable; }
            set { this._isTunable = value; }
        }

        // Check to see if IsTunable property is set
        internal bool IsSetIsTunable()
        {
            return this._isTunable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this hyperparameter. The name must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The allowed range for this hyperparameter.
        /// </para>
        /// </summary>
        public ParameterRange Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this hyperparameter. The valid types are <c>Integer</c>, <c>Continuous</c>,
        /// <c>Categorical</c>, and <c>FreeText</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParameterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}