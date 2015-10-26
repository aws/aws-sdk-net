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
    /// Describes the name of an SSM document.
    /// </summary>
    public partial class DocumentIdentifier
    {
        private string _name;
        private List<string> _platformTypes = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DocumentIdentifier() { }

        /// <summary>
        /// Instantiates DocumentIdentifier with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the SSM document.</param>
        public DocumentIdentifier(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSM document.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PlatformTypes. The operating system platform.
        /// </summary>
        public List<string> PlatformTypes
        {
            get { return this._platformTypes; }
            set { this._platformTypes = value; }
        }

        // Check to see if PlatformTypes property is set
        internal bool IsSetPlatformTypes()
        {
            return this._platformTypes != null && this._platformTypes.Count > 0; 
        }

    }
}