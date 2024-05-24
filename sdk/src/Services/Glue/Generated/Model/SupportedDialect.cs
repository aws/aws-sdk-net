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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure specifying the dialect and dialect version used by the query engine.
    /// </summary>
    public partial class SupportedDialect
    {
        private ViewDialect _dialect;
        private string _dialectVersion;

        /// <summary>
        /// Gets and sets the property Dialect. 
        /// <para>
        /// The dialect of the query engine.
        /// </para>
        /// </summary>
        public ViewDialect Dialect
        {
            get { return this._dialect; }
            set { this._dialect = value; }
        }

        // Check to see if Dialect property is set
        internal bool IsSetDialect()
        {
            return this._dialect != null;
        }

        /// <summary>
        /// Gets and sets the property DialectVersion. 
        /// <para>
        /// The version of the dialect of the query engine. For example, 3.0.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DialectVersion
        {
            get { return this._dialectVersion; }
            set { this._dialectVersion = value; }
        }

        // Check to see if DialectVersion property is set
        internal bool IsSetDialectVersion()
        {
            return this._dialectVersion != null;
        }

    }
}