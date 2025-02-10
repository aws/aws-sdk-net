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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Describes an individual setting that controls some aspect of ElastiCache behavior.
    /// </summary>
    public partial class Parameter
    {
        private string _allowedValues;
        private ChangeType _changeType;
        private string _dataType;
        private string _description;
        private bool? _isModifiable;
        private string _minimumEngineVersion;
        private string _parameterName;
        private string _parameterValue;
        private string _source;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Parameter() { }

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The valid range of values for the parameter.
        /// </para>
        /// </summary>
        public string AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Indicates whether a change to the parameter is applied immediately or requires a reboot
        /// for the change to be applied. You can force a reboot or wait until the next maintenance
        /// window's reboot. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.Rebooting.html">Rebooting
        /// a Cluster</a>.
        /// </para>
        /// </summary>
        public ChangeType ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The valid data type for the parameter.
        /// </para>
        /// </summary>
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the parameter.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// Indicates whether (<c>true</c>) or not (<c>false</c>) the parameter can be modified.
        /// Some parameters have security or operational implications that prevent them from being
        /// changed.
        /// </para>
        /// </summary>
        public bool? IsModifiable
        {
            get { return this._isModifiable; }
            set { this._isModifiable = value; }
        }

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this._isModifiable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The earliest cache engine version to which the parameter can apply.
        /// </para>
        /// </summary>
        public string MinimumEngineVersion
        {
            get { return this._minimumEngineVersion; }
            set { this._minimumEngineVersion = value; }
        }

        // Check to see if MinimumEngineVersion property is set
        internal bool IsSetMinimumEngineVersion()
        {
            return this._minimumEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        /// The value of the parameter.
        /// </para>
        /// </summary>
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the parameter.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}