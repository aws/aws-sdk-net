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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Specifies whether previous query results are reused, and if so, their maximum age.
    /// </summary>
    public partial class ResultReuseByAgeConfiguration
    {
        private bool? _enabled;
        private int? _maxAgeInMinutes;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// True if previous query results can be reused when the query is run; otherwise, false.
        /// The default is false.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAgeInMinutes. 
        /// <para>
        /// Specifies, in minutes, the maximum age of a previous query result that Athena should
        /// consider for reuse. The default is 60.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10080)]
        public int? MaxAgeInMinutes
        {
            get { return this._maxAgeInMinutes; }
            set { this._maxAgeInMinutes = value; }
        }

        // Check to see if MaxAgeInMinutes property is set
        internal bool IsSetMaxAgeInMinutes()
        {
            return this._maxAgeInMinutes.HasValue; 
        }

    }
}