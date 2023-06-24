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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The configurations for the Hive job driver.
    /// </summary>
    public partial class Hive
    {
        private string _initQueryFile;
        private string _parameters;
        private string _query;

        /// <summary>
        /// Gets and sets the property InitQueryFile. 
        /// <para>
        /// The query file for the Hive job run.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string InitQueryFile
        {
            get { return this._initQueryFile; }
            set { this._initQueryFile = value; }
        }

        // Check to see if InitQueryFile property is set
        internal bool IsSetInitQueryFile()
        {
            return this._initQueryFile != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the Hive job run.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=102400)]
        public string Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query for the Hive job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10280)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

    }
}