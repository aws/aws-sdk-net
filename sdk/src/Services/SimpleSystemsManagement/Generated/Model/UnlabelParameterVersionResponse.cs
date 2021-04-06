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
    /// This is the response object from the UnlabelParameterVersion operation.
    /// </summary>
    public partial class UnlabelParameterVersionResponse : AmazonWebServiceResponse
    {
        private List<string> _invalidLabels = new List<string>();
        private List<string> _removedLabels = new List<string>();

        /// <summary>
        /// Gets and sets the property InvalidLabels. 
        /// <para>
        /// The labels that are not attached to the given parameter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> InvalidLabels
        {
            get { return this._invalidLabels; }
            set { this._invalidLabels = value; }
        }

        // Check to see if InvalidLabels property is set
        internal bool IsSetInvalidLabels()
        {
            return this._invalidLabels != null && this._invalidLabels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemovedLabels. 
        /// <para>
        /// A list of all labels deleted from the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> RemovedLabels
        {
            get { return this._removedLabels; }
            set { this._removedLabels = value; }
        }

        // Check to see if RemovedLabels property is set
        internal bool IsSetRemovedLabels()
        {
            return this._removedLabels != null && this._removedLabels.Count > 0; 
        }

    }
}