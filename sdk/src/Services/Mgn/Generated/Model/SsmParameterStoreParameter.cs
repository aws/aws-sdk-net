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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// AWS Systems Manager Parameter Store parameter.
    /// </summary>
    public partial class SsmParameterStoreParameter
    {
        private string _parameterName;
        private SsmParameterStoreParameterType _parameterType;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// AWS Systems Manager Parameter Store parameter name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
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

        /// <summary>
        /// Gets and sets the property ParameterType. 
        /// <para>
        /// AWS Systems Manager Parameter Store parameter type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SsmParameterStoreParameterType ParameterType
        {
            get { return this._parameterType; }
            set { this._parameterType = value; }
        }

        // Check to see if ParameterType property is set
        internal bool IsSetParameterType()
        {
            return this._parameterType != null;
        }

    }
}