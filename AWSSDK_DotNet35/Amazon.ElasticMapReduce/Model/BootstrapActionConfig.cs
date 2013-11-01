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
    /// <para>Configuration of a bootstrap action.</para>
    /// </summary>
    public class BootstrapActionConfig
    {
        
        private string name;
        private ScriptBootstrapActionConfig scriptBootstrapAction;


        /// <summary>
        /// The name of the bootstrap action.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
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
        /// The script run by the bootstrap action.
        ///  
        /// </summary>
        public ScriptBootstrapActionConfig ScriptBootstrapAction
        {
            get { return this.scriptBootstrapAction; }
            set { this.scriptBootstrapAction = value; }
        }

        // Check to see if ScriptBootstrapAction property is set
        internal bool IsSetScriptBootstrapAction()
        {
            return this.scriptBootstrapAction != null;
        }
    }
}
