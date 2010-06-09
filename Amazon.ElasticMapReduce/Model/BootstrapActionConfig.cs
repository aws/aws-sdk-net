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
    ///<summary>
    ///Configuration of a bootstrap action.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class BootstrapActionConfig
    {
        private string nameField;
        private ScriptBootstrapActionConfig scriptBootstrapActionField;

        /// <summary>
        /// Gets and sets the Name property.
        /// The name of the bootstrap action.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The name of the bootstrap action.</param>
        /// <returns>this instance</returns>
        public BootstrapActionConfig WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the ScriptBootstrapAction property.
        /// The script run by the bootstrap action.
        /// </summary>
        [XmlElementAttribute(ElementName = "ScriptBootstrapAction")]
        public ScriptBootstrapActionConfig ScriptBootstrapAction
        {
            get { return this.scriptBootstrapActionField; }
            set { this.scriptBootstrapActionField = value; }
        }

        /// <summary>
        /// Sets the ScriptBootstrapAction property
        /// </summary>
        /// <param name="scriptBootstrapAction">The script run by the bootstrap action.</param>
        /// <returns>this instance</returns>
        public BootstrapActionConfig WithScriptBootstrapAction(ScriptBootstrapActionConfig scriptBootstrapAction)
        {
            this.scriptBootstrapActionField = scriptBootstrapAction;
            return this;
        }

        /// <summary>
        /// Checks if ScriptBootstrapAction property is set
        /// </summary>
        /// <returns>true if ScriptBootstrapAction property is set</returns>
        public bool IsSetScriptBootstrapAction()
        {
            return this.scriptBootstrapActionField != null;
        }

    }
}
