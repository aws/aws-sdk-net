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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Details about an antenna demod decode <c>Config</c> used in a contact.
    /// </summary>
    public partial class AntennaDemodDecodeDetails
    {
        private string _outputNode;

        /// <summary>
        /// Gets and sets the property OutputNode. 
        /// <para>
        /// Name of an antenna demod decode output node used in a contact.
        /// </para>
        /// </summary>
        public string OutputNode
        {
            get { return this._outputNode; }
            set { this._outputNode = value; }
        }

        // Check to see if OutputNode property is set
        internal bool IsSetOutputNode()
        {
            return this._outputNode != null;
        }

    }
}