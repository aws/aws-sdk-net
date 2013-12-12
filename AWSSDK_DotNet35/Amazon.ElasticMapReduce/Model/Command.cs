/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>An entity describing an executable that runs on a cluster.</para>
    /// </summary>
    public class Command
    {
        
        private string name;
        private string scriptPath;
        private List<string> args = new List<string>();


        /// <summary>
        /// The name of the command.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// The Amazon S3 location of the command script.
        ///  
        /// </summary>
        public string ScriptPath
        {
            get { return this.scriptPath; }
            set { this.scriptPath = value; }
        }

        // Check to see if ScriptPath property is set
        internal bool IsSetScriptPath()
        {
            return this.scriptPath != null;
        }

        /// <summary>
        /// Arguments for Amazon EMR to pass to the command for execution.
        ///  
        /// </summary>
        public List<string> Args
        {
            get { return this.args; }
            set { this.args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this.args.Count > 0;
        }
    }
}
