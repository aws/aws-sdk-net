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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Operation
    {
        private string _equation;
        private string _name;
        private OutputType _outputType;

        /// <summary>
        /// Gets and sets the property Equation.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Equation
        {
            get { return this._equation; }
            set { this._equation = value; }
        }

        // Check to see if Equation property is set
        internal bool IsSetEquation()
        {
            return this._equation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OutputType. 
        /// <para>
        /// The type of the operation.
        /// </para>
        /// </summary>
        public OutputType OutputType
        {
            get { return this._outputType; }
            set { this._outputType = value; }
        }

        // Check to see if OutputType property is set
        internal bool IsSetOutputType()
        {
            return this._outputType != null;
        }

    }
}