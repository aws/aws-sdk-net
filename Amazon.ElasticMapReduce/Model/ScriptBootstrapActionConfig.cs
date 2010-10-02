/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Configuration of the script to run during a bootstrap action.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class ScriptBootstrapActionConfig
    {
        private string pathField;
        private List<string> argsField;

        /// <summary>
        /// Gets and sets the Path property.
        /// Location of the script to run during a bootstrap action.
        /// </summary>
        [XmlElementAttribute(ElementName = "Path")]
        public string Path
        {
            get { return this.pathField; }
            set { this.pathField = value; }
        }

        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">Location of the script to run during a bootstrap action.</param>
        /// <returns>this instance</returns>
        public ScriptBootstrapActionConfig WithPath(string path)
        {
            this.pathField = path;
            return this;
        }

        /// <summary>
        /// Checks if Path property is set
        /// </summary>
        /// <returns>true if Path property is set</returns>
        public bool IsSetPath()
        {
            return this.pathField != null;
        }

        /// <summary>
        /// Gets and sets the Args property.
        /// A list of command line arguments to pass to the bootstrap action script.
        /// </summary>
        [XmlElementAttribute(ElementName = "Args")]
        public List<string> Args
        {
            get
            {
                if (this.argsField == null)
                {
                    this.argsField = new List<string>();
                }
                return this.argsField;
            }
            set { this.argsField = value; }
        }

        /// <summary>
        /// Sets the Args property
        /// </summary>
        /// <param name="list">A list of command line arguments to pass to the bootstrap action script.</param>
        /// <returns>this instance</returns>
        public ScriptBootstrapActionConfig WithArgs(params string[] list)
        {
            foreach (string item in list)
            {
                Args.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Args property is set
        /// </summary>
        /// <returns>true if Args property is set</returns>
        public bool IsSetArgs()
        {
            return (Args.Count > 0);
        }

    }
}
