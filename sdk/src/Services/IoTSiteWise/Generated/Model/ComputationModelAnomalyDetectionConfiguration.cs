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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains the configuration of the type of anomaly detection computation model.
    /// </summary>
    public partial class ComputationModelAnomalyDetectionConfiguration
    {
        private string _inputProperties;
        private string _resultProperty;

        /// <summary>
        /// Gets and sets the property InputProperties. 
        /// <para>
        /// Define the variable name associated with input properties, with the following format
        /// <c>${VariableName}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=67)]
        public string InputProperties
        {
            get { return this._inputProperties; }
            set { this._inputProperties = value; }
        }

        // Check to see if InputProperties property is set
        internal bool IsSetInputProperties()
        {
            return this._inputProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ResultProperty. 
        /// <para>
        /// Define the variable name associated with the result property, and the following format
        /// <c>${VariableName}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=67)]
        public string ResultProperty
        {
            get { return this._resultProperty; }
            set { this._resultProperty = value; }
        }

        // Check to see if ResultProperty property is set
        internal bool IsSetResultProperty()
        {
            return this._resultProperty != null;
        }

    }
}