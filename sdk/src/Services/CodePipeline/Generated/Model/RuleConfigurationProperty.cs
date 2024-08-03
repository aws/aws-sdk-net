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
    /// Represents information about a rule configuration property.
    /// </summary>
    public partial class RuleConfigurationProperty
    {
        private string _description;
        private bool? _key;
        private string _name;
        private bool? _queryable;
        private bool? _required;
        private bool? _secret;
        private RuleConfigurationPropertyType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the action configuration property that is displayed to users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=160)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Whether the configuration property is a key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule configuration property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property Queryable. 
        /// <para>
        /// Indicates whether the property can be queried.
        /// </para>
        ///  
        /// <para>
        /// If you create a pipeline with a condition and rule, and that rule contains a queryable
        /// property, the value for that configuration property is subject to other restrictions.
        /// The value must be less than or equal to twenty (20) characters. The value can contain
        /// only alphanumeric characters, underscores, and hyphens.
        /// </para>
        /// </summary>
        public bool? Queryable
        {
            get { return this._queryable; }
            set { this._queryable = value; }
        }

        // Check to see if Queryable property is set
        internal bool IsSetQueryable()
        {
            return this._queryable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Whether the configuration property is a required value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Required
        {
            get { return this._required; }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// Whether the configuration property is secret.
        /// </para>
        ///  
        /// <para>
        /// When updating a pipeline, passing * * * * * without changing any other values of the
        /// action preserves the previous value of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the configuration property.
        /// </para>
        /// </summary>
        public RuleConfigurationPropertyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}