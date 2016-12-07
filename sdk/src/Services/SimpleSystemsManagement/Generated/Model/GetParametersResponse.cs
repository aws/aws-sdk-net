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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetParameters operation.
    /// </summary>
    public partial class GetParametersResponse : AmazonWebServiceResponse
    {
        private List<string> _invalidParameters = new List<string>();
        private List<Parameter> _parameters = new List<Parameter>();

        /// <summary>
        /// Gets and sets the property InvalidParameters. 
        /// <para>
        /// A list of parameters that are not formatted correctly or do not run when executed.
        /// </para>
        /// </summary>
        public List<string> InvalidParameters
        {
            get { return this._invalidParameters; }
            set { this._invalidParameters = value; }
        }

        // Check to see if InvalidParameters property is set
        internal bool IsSetInvalidParameters()
        {
            return this._invalidParameters != null && this._invalidParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameters used by the AWS account.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}