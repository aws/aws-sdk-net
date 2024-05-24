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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A transform operation that overrides the dataset parameter values that are defined
    /// in another dataset.
    /// </summary>
    public partial class OverrideDatasetParameterOperation
    {
        private NewDefaultValues _newDefaultValues;
        private string _newParameterName;
        private string _parameterName;

        /// <summary>
        /// Gets and sets the property NewDefaultValues. 
        /// <para>
        /// The new default values for the parameter.
        /// </para>
        /// </summary>
        public NewDefaultValues NewDefaultValues
        {
            get { return this._newDefaultValues; }
            set { this._newDefaultValues = value; }
        }

        // Check to see if NewDefaultValues property is set
        internal bool IsSetNewDefaultValues()
        {
            return this._newDefaultValues != null;
        }

        /// <summary>
        /// Gets and sets the property NewParameterName. 
        /// <para>
        /// The new name for the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NewParameterName
        {
            get { return this._newParameterName; }
            set { this._newParameterName = value; }
        }

        // Check to see if NewParameterName property is set
        internal bool IsSetNewParameterName()
        {
            return this._newParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter to be overridden with different values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

    }
}