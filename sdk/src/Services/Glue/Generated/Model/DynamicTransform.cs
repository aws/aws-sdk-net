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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the set of parameters needed to perform the dynamic transform.
    /// </summary>
    public partial class DynamicTransform
    {
        private string _functionName;
        private List<string> _inputs = new List<string>();
        private string _name;
        private List<TransformConfigParameter> _parameters = new List<TransformConfigParameter>();
        private string _path;
        private string _transformName;
        private string _version;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// Specifies the name of the function of the dynamic transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Specifies the inputs for the dynamic transform that are required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && this._inputs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the dynamic transform.
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Specifies the parameters of the dynamic transform.
        /// </para>
        /// </summary>
        public List<TransformConfigParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Specifies the path of the dynamic transform source and config files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property TransformName. 
        /// <para>
        /// Specifies the name of the dynamic transform as it appears in the Glue Studio visual
        /// editor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransformName
        {
            get { return this._transformName; }
            set { this._transformName = value; }
        }

        // Check to see if TransformName property is set
        internal bool IsSetTransformName()
        {
            return this._transformName != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// This field is not used and will be deprecated in future release.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}