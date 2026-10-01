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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Component. The component that will be subject to logging.
        /// </summary>
        [AWSProperty(Required = true)]
        public LoggerComponent Component { get; set; }

        /// <summary>
        /// Checks to see if the Component property is set.
        /// </summary>
        internal bool IsSetComponent() => this.Component != null;

        /// <summary>
        /// Gets and sets the property Id. A descriptive or arbitrary ID for the logger. This
        /// value must be unique within the logger definition version. Max length is 128 characters
        /// with pattern ''[a-zA-Z0-9:_-]+''.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Level. The level of the logs.
        /// </summary>
        [AWSProperty(Required = true)]
        public LoggerLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property Space. The amount of file space, in KB, to use if the local
        /// file system is used for logging purposes.
        /// </summary>
        public int? Space { get; set; }

        /// <summary>
        /// Checks to see if the Space property is set.
        /// </summary>
        internal bool IsSetSpace() => this.Space.HasValue;

        /// <summary>
        /// Gets and sets the property Type. The type of log output which will be used.
        /// </summary>
        [AWSProperty(Required = true)]
        public LoggerType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
