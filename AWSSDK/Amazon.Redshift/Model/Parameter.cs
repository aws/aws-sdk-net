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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a parameter in a cluster parameter group.
    /// </summary>
    public partial class Parameter
    {
        private string _allowedValues;
        private string _dataType;
        private string _description;
        private bool? _isModifiable;
        private string _minimumEngineVersion;
        private string _parameterName;
        private string _parameterValue;
        private string _source;


        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        ///         The valid range of values for the parameter.        
        /// </para>
        /// </summary>
        public string AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }


        /// <summary>
        /// Sets the AllowedValues property
        /// </summary>
        /// <param name="allowedValues">The value to set for the AllowedValues property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithAllowedValues(string allowedValues)
        {
            this._allowedValues = allowedValues;
            return this;
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null;
        }


        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        ///             The data type of the parameter.        
        /// </para>
        /// </summary>
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }


        /// <summary>
        /// Sets the DataType property
        /// </summary>
        /// <param name="dataType">The value to set for the DataType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithDataType(string dataType)
        {
            this._dataType = dataType;
            return this;
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///         A description of the parameter.        
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property IsModifiable. 
        /// <para>
        ///             If <code>true</code>, the parameter can be modified.            Some parameters
        /// have security or operational implications            that prevent them from being
        /// changed.        
        /// </para>
        /// </summary>
        public bool IsModifiable
        {
            get { return this._isModifiable.GetValueOrDefault(); }
            set { this._isModifiable = value; }
        }


        /// <summary>
        /// Sets the IsModifiable property
        /// </summary>
        /// <param name="isModifiable">The value to set for the IsModifiable property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithIsModifiable(bool isModifiable)
        {
            this._isModifiable = isModifiable;
            return this;
        }

        // Check to see if IsModifiable property is set
        internal bool IsSetIsModifiable()
        {
            return this._isModifiable.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        ///     The earliest engine version to which the parameter can apply.    
        /// </para>
        /// </summary>
        public string MinimumEngineVersion
        {
            get { return this._minimumEngineVersion; }
            set { this._minimumEngineVersion = value; }
        }


        /// <summary>
        /// Sets the MinimumEngineVersion property
        /// </summary>
        /// <param name="minimumEngineVersion">The value to set for the MinimumEngineVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithMinimumEngineVersion(string minimumEngineVersion)
        {
            this._minimumEngineVersion = minimumEngineVersion;
            return this;
        }

        // Check to see if MinimumEngineVersion property is set
        internal bool IsSetMinimumEngineVersion()
        {
            return this._minimumEngineVersion != null;
        }


        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        ///         The name of the parameter.        
        /// </para>
        /// </summary>
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }


        /// <summary>
        /// Sets the ParameterName property
        /// </summary>
        /// <param name="parameterName">The value to set for the ParameterName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithParameterName(string parameterName)
        {
            this._parameterName = parameterName;
            return this;
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
        }


        /// <summary>
        /// Gets and sets the property ParameterValue. 
        /// <para>
        ///         The value of the parameter.        
        /// </para>
        /// </summary>
        public string ParameterValue
        {
            get { return this._parameterValue; }
            set { this._parameterValue = value; }
        }


        /// <summary>
        /// Sets the ParameterValue property
        /// </summary>
        /// <param name="parameterValue">The value to set for the ParameterValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithParameterValue(string parameterValue)
        {
            this._parameterValue = parameterValue;
            return this;
        }

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this._parameterValue != null;
        }


        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        ///         The source of the parameter value, such as "engine-default" or "user".   
        ///     
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }


        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">The value to set for the Source property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithSource(string source)
        {
            this._source = source;
            return this;
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}