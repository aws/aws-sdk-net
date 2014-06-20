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
    /// An entity describing an executable that runs on a cluster.
    /// </summary>
    public partial class Command
    {
        private List<string> _args = new List<string>();
        private string _name;
        private string _scriptPath;


        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// Arguments for Amazon EMR to pass to the command for execution.
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
        public Command WithArgs(params string[] args)
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
        public Command WithArgs(IEnumerable<string> args)
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the command.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithName(string name)
        {
            this._name = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }


        /// <summary>
        /// Gets and sets the property ScriptPath. 
        /// <para>
        /// The Amazon S3 location of the command script.
        /// </para>
        /// </summary>
        public string ScriptPath
        {
            get { return this._scriptPath; }
            set { this._scriptPath = value; }
        }


        /// <summary>
        /// Sets the ScriptPath property
        /// </summary>
        /// <param name="scriptPath">The value to set for the ScriptPath property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithScriptPath(string scriptPath)
        {
            this._scriptPath = scriptPath;
            return this;
        }

        // Check to see if ScriptPath property is set
        internal bool IsSetScriptPath()
        {
            return this._scriptPath != null;
        }

    }
}