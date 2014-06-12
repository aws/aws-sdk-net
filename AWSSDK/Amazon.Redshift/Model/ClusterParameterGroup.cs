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
    /// Describes a parameter group.
    /// </summary>
    public partial class ClusterParameterGroup
    {
        private string _description;
        private string _parameterGroupFamily;
        private string _parameterGroupName;


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///         The description of the parameter group.        
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
        public ClusterParameterGroup WithDescription(string description)
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
        /// Gets and sets the property ParameterGroupFamily. 
        /// <para>
        ///         The name of the cluster parameter group family that        this cluster parameter
        /// group is compatible with.        
        /// </para>
        /// </summary>
        public string ParameterGroupFamily
        {
            get { return this._parameterGroupFamily; }
            set { this._parameterGroupFamily = value; }
        }


        /// <summary>
        /// Sets the ParameterGroupFamily property
        /// </summary>
        /// <param name="parameterGroupFamily">The value to set for the ParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterParameterGroup WithParameterGroupFamily(string parameterGroupFamily)
        {
            this._parameterGroupFamily = parameterGroupFamily;
            return this;
        }

        // Check to see if ParameterGroupFamily property is set
        internal bool IsSetParameterGroupFamily()
        {
            return this._parameterGroupFamily != null;
        }


        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        ///         The name of the cluster parameter group.        
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }


        /// <summary>
        /// Sets the ParameterGroupName property
        /// </summary>
        /// <param name="parameterGroupName">The value to set for the ParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterParameterGroup WithParameterGroupName(string parameterGroupName)
        {
            this._parameterGroupName = parameterGroupName;
            return this;
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

    }
}