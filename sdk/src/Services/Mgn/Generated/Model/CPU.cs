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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Source server CPU information.
    /// </summary>
    public partial class CPU
    {
        private long? _cores;
        private string _modelName;

        /// <summary>
        /// Gets and sets the property Cores. 
        /// <para>
        /// The number of CPU cores on the source server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Cores
        {
            get { return this._cores; }
            set { this._cores = value; }
        }

        // Check to see if Cores property is set
        internal bool IsSetCores()
        {
            return this._cores.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The source server's CPU model name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

    }
}