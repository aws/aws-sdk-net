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
    /// Configuration of a bootstrap action.
    /// </summary>
    public partial class BootstrapActionConfig
    {
        private string _name;
        private ScriptBootstrapActionConfig _scriptBootstrapAction;


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bootstrap action.
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
        public BootstrapActionConfig WithName(string name)
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
        /// Gets and sets the property ScriptBootstrapAction. 
        /// <para>
        /// The script run by the bootstrap action.
        /// </para>
        /// </summary>
        public ScriptBootstrapActionConfig ScriptBootstrapAction
        {
            get { return this._scriptBootstrapAction; }
            set { this._scriptBootstrapAction = value; }
        }


        /// <summary>
        /// Sets the ScriptBootstrapAction property
        /// </summary>
        /// <param name="scriptBootstrapAction">The value to set for the ScriptBootstrapAction property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BootstrapActionConfig WithScriptBootstrapAction(ScriptBootstrapActionConfig scriptBootstrapAction)
        {
            this._scriptBootstrapAction = scriptBootstrapAction;
            return this;
        }

        // Check to see if ScriptBootstrapAction property is set
        internal bool IsSetScriptBootstrapAction()
        {
            return this._scriptBootstrapAction != null;
        }

    }
}