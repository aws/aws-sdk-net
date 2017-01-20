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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes a data processing configuration.
    /// </summary>
    public partial class ProcessingConfiguration
    {
        private bool? _enabled;
        private List<Processor> _processors = new List<Processor>();

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enables or disables data processing.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Processors. 
        /// <para>
        /// The data processors.
        /// </para>
        /// </summary>
        public List<Processor> Processors
        {
            get { return this._processors; }
            set { this._processors = value; }
        }

        // Check to see if Processors property is set
        internal bool IsSetProcessors()
        {
            return this._processors != null && this._processors.Count > 0; 
        }

    }
}