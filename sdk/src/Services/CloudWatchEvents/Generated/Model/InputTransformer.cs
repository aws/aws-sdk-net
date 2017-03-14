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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Contains the parameters needed for you to provide custom input to a target based on
    /// one or more pieces of data extracted from the event.
    /// </summary>
    public partial class InputTransformer
    {
        private Dictionary<string, string> _inputPathsMap = new Dictionary<string, string>();
        private string _inputTemplate;

        /// <summary>
        /// Gets and sets the property InputPathsMap. 
        /// <para>
        /// Map of JSON paths to be extracted from the event. These are key-value pairs, where
        /// each value is a JSON path.
        /// </para>
        /// </summary>
        public Dictionary<string, string> InputPathsMap
        {
            get { return this._inputPathsMap; }
            set { this._inputPathsMap = value; }
        }

        // Check to see if InputPathsMap property is set
        internal bool IsSetInputPathsMap()
        {
            return this._inputPathsMap != null && this._inputPathsMap.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputTemplate. 
        /// <para>
        /// Input template where you can use the values of the keys from <code>InputPathsMap</code>
        /// to customize the data sent to the target.
        /// </para>
        /// </summary>
        public string InputTemplate
        {
            get { return this._inputTemplate; }
            set { this._inputTemplate = value; }
        }

        // Check to see if InputTemplate property is set
        internal bool IsSetInputTemplate()
        {
            return this._inputTemplate != null;
        }

    }
}