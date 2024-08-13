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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information about a logger
    /// </summary>
    public partial class Logger
    {
        private LoggerComponent _component;
        private string _id;
        private LoggerLevel _level;
        private int? _space;
        private LoggerType _type;

        /// <summary>
        /// Gets and sets the property Component. The component that will be subject to logging.
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggerComponent Component
        {
            get { return this._component; }
            set { this._component = value; }
        }

        // Check to see if Component property is set
        internal bool IsSetComponent()
        {
            return this._component != null;
        }

        /// <summary>
        /// Gets and sets the property Id. A descriptive or arbitrary ID for the logger. This
        /// value must be unique within the logger definition version. Max length is 128 characters
        /// with pattern ''[a-zA-Z0-9:_-]+''.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Level. The level of the logs.
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggerLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

        /// <summary>
        /// Gets and sets the property Space. The amount of file space, in KB, to use if the local
        /// file system is used for logging purposes.
        /// </summary>
        public int? Space
        {
            get { return this._space; }
            set { this._space = value; }
        }

        // Check to see if Space property is set
        internal bool IsSetSpace()
        {
            return this._space.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. The type of log output which will be used.
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}