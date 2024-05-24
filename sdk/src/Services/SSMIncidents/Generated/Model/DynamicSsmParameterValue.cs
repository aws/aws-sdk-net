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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The dynamic SSM parameter value.
    /// </summary>
    public partial class DynamicSsmParameterValue
    {
        private VariableType _variable;

        /// <summary>
        /// Gets and sets the property Variable. 
        /// <para>
        /// Variable dynamic parameters. A parameter value is determined when an incident is created.
        /// </para>
        /// </summary>
        public VariableType Variable
        {
            get { return this._variable; }
            set { this._variable = value; }
        }

        // Check to see if Variable property is set
        internal bool IsSetVariable()
        {
            return this._variable != null;
        }

    }
}