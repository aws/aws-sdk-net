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

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScriptBootstrapActionConfig WithArgs(params string[] args)
        {
            foreach (var element in args)
            {
                this._args.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="args">The values to add to the Args collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScriptBootstrapActionConfig WithArgs(IEnumerable<string> args)
        {
            foreach (var element in args)
            {
                this._args.Add(element);
            }
            return this;
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


        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScriptBootstrapActionConfig WithPath(string path)
        {
            this._path = path;
            return this;
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}