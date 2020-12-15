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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains the status of a component in the AWS IoT Greengrass service.
    /// </summary>
    public partial class CloudComponentStatus
    {
        private CloudComponentState _componentState;
        private Dictionary<string, string> _errors = new Dictionary<string, string>();
        private string _message;

        /// <summary>
        /// Gets and sets the property ComponentState. 
        /// <para>
        /// The state of the component.
        /// </para>
        /// </summary>
        public CloudComponentState ComponentState
        {
            get { return this._componentState; }
            set { this._componentState = value; }
        }

        // Check to see if ComponentState property is set
        internal bool IsSetComponentState()
        {
            return this._componentState != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A dictionary of errors that communicate why the component is in an error state. For
        /// example, if AWS IoT Greengrass can't access an artifact for the component, then <code>errors</code>
        /// contains the artifact's URI as a key, and the error message as the value for that
        /// key.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that communicates details, such as errors, about the status of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}