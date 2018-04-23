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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterThing operation.
    /// Provisions a thing.
    /// </summary>
    public partial class RegisterThingRequest : AmazonIoTRequest
    {
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for provisioning a thing. See <a href="http://docs.aws.amazon.com/iot/latest/developerguide/programmatic-provisioning.html">Programmatic
        /// Provisioning</a> for more information.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
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
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The provisioning template. See <a href="http://docs.aws.amazon.com/iot/latest/developerguide/programmatic-provisioning.html">Programmatic
        /// Provisioning</a> for more information.
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

    }
}