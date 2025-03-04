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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The ID for the rule type, which is made up of the combined values for category, owner,
    /// provider, and version. For more information about conditions, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/stage-conditions.html">Stage
    /// conditions</a>. For more information about rules, see the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/rule-reference.html">CodePipeline
    /// rule reference</a>.
    /// </summary>
    public partial class RuleTypeId
    {
        private RuleCategory _category;
        private RuleOwner _owner;
        private string _provider;
        private string _version;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// A category defines what kind of rule can be run in the stage, and constrains the provider
        /// type for the rule. The valid category is <c>Rule</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The creator of the rule being called. The valid value for the <c>Owner</c> field in
        /// the rule category is <c>AWS</c>. 
        /// </para>
        /// </summary>
        public RuleOwner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The rule provider, such as the <c>DeploymentWindow</c> rule. For a list of rule provider
        /// names, see the rules listed in the <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/rule-reference.html">CodePipeline
        /// rule reference</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=35)]
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A string that describes the rule version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}