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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The FireLens configuration for the container. This is used to specify and configure
    /// a log router for container logs.
    /// </summary>
    public partial class FirelensConfiguration
    {
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private FirelensConfigurationType _type;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options to use when configuring the log router. This field is optional and can
        /// be used to add additional metadata, such as the task, task definition, cluster, and
        /// container instance details to the log event. If specified, the syntax to use is <code>"options":{"enable-ecs-log-metadata":"true|false"}</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The log router to use. The valid values are <code>fluentd</code> or <code>fluentbit</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirelensConfigurationType Type
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