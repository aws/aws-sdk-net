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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UnlabelParameterVersion operation.
    /// Remove a label or labels from a parameter.
    /// </summary>
    public partial class UnlabelParameterVersionRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _labels = new List<string>();
        private string _name;
        private long? _parameterVersion;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// One or more labels to delete from the specified parameter version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && this._labels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The parameter name of which you want to delete one or more labels.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property ParameterVersion. 
        /// <para>
        /// The specific version of the parameter which you want to delete one or more labels
        /// from. If it is not present, the call will fail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long ParameterVersion
        {
            get { return this._parameterVersion.GetValueOrDefault(); }
            set { this._parameterVersion = value; }
        }

        // Check to see if ParameterVersion property is set
        internal bool IsSetParameterVersion()
        {
            return this._parameterVersion.HasValue; 
        }

    }
}