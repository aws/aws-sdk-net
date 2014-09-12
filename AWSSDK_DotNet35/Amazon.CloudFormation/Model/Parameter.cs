/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The Parameter data type.
    /// </summary>
    public partial class Parameter
    {
        private string _parameterKey;
        private string _parameterValue;
        private bool? _usePreviousValue;

        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The key associated with the parameter.
        /// </para>
        /// </summary>
        public string ParameterKey
        {
            get { return this._parameterKey; }
            set { this._parameterKey = value; }
        }

        // Check to see if ParameterKey property is set
        internal bool IsSetParameterKey()
        {
            return this._parameterKey != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The value associated with the parameter.
        /// </para>
        /// </summary>
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }

        /// <summary>
        /// Gets and sets the property UsePreviousValue. 
        /// <para>
        /// During a stack update, use the existing parameter value that is being used for the
        /// stack.
        /// </para>
        /// </summary>
        public bool UsePreviousValue
        {
            get { return this._usePreviousValue.GetValueOrDefault(); }
            set { this._usePreviousValue = value; }
        }

        // Check to see if UsePreviousValue property is set
        internal bool IsSetUsePreviousValue()
        {
            return this._usePreviousValue.HasValue; 
        }

    }
}