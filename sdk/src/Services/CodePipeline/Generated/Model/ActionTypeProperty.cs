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
    /// Represents information about each property specified in the action configuration,
    /// such as the description and key name that display for the customer using the action
    /// type.
    /// </summary>
    public partial class ActionTypeProperty
    {
        private string _description;
        private bool? _key;
        private string _name;
        private bool? _noEcho;
        private bool? _optional;
        private bool? _queryable;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the property that is displayed to users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// The property name that is displayed to users.
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
        /// Gets and sets the property NoEcho. 
        /// <para>
        /// Whether to omit the field value entered by the customer in the log. If <c>true</c>,
        /// the value is not saved in CloudTrail logs for the action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? NoEcho
        {
            get { return this._noEcho; }
            set { this._noEcho = value; }
        }

        // Check to see if NoEcho property is set
        internal bool IsSetNoEcho()
        {
            return this._noEcho.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Optional. 
        /// <para>
        /// Whether the configuration property is an optional value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Optional
        {
            get { return this._optional; }
            set { this._optional = value; }
        }

        // Check to see if Optional property is set
        internal bool IsSetOptional()
        {
            return this._optional.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Queryable. 
        /// <para>
        /// Indicates that the property is used with polling. An action type can have up to one
        /// queryable property. If it has one, that property must be both required and not secret.
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

    }
}