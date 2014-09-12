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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Configuration of the script to run during a bootstrap action.
    /// </summary>
    public partial class ScriptBootstrapActionConfig
    {
        private List<string> _args = new List<string>();
        private string _path;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ScriptBootstrapActionConfig() { }

        /// <summary>
        /// Instantiates ScriptBootstrapActionConfig with the parameterized properties
        /// </summary>
        /// <param name="path">Location of the script to run during a bootstrap action. Can be either a location in Amazon   S3 or on a local file system.</param>
        /// <param name="args">A list of command line arguments to pass to the bootstrap action script.</param>
        public ScriptBootstrapActionConfig(string path, List<string> args)
        {
            _path = path;
            _args = args;
        }

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// A list of command line arguments to pass to the bootstrap action script.
        /// </para>
        /// </summary>
        public List<string> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && this._args.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Location of the script to run during a bootstrap action. Can be either a location
        /// in Amazon         S3 or on a local file system.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}