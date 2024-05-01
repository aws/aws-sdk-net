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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Configuration of a bootstrap action.
    /// </summary>
    public partial class BootstrapActionConfig
    {
        private string _name;
        private ScriptBootstrapActionConfig _scriptBootstrapAction;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public BootstrapActionConfig() { }

        /// <summary>
        /// Instantiates BootstrapActionConfig with the parameterized properties
        /// </summary>
        /// <param name="name">The name of the bootstrap action.</param>
        /// <param name="scriptBootstrapAction">The script run by the bootstrap action.</param>
        public BootstrapActionConfig(string name, ScriptBootstrapActionConfig scriptBootstrapAction)
        {
            _name = name;
            _scriptBootstrapAction = scriptBootstrapAction;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bootstrap action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptBootstrapAction. 
        /// <para>
        /// The script run by the bootstrap action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScriptBootstrapActionConfig ScriptBootstrapAction
        {
            get { return this._scriptBootstrapAction; }
            set { this._scriptBootstrapAction = value; }
        }

        // Check to see if ScriptBootstrapAction property is set
        internal bool IsSetScriptBootstrapAction()
        {
            return this._scriptBootstrapAction != null;
        }

    }
}