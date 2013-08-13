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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// <para>The Parameter data type.</para>
    /// </summary>
    public class Parameter
    {
        
        private string parameterKey;
        private string parameterValue;

        /// <summary>
        /// The key associated with the parameter.
        ///  
        /// </summary>
        public string ParameterKey
        {
            get { return this.parameterKey; }
            set { this.parameterKey = value; }
        }

        /// <summary>
        /// Sets the ParameterKey property
        /// </summary>
        /// <param name="parameterKey">The value to set for the ParameterKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithParameterKey(string parameterKey)
        {
            this.parameterKey = parameterKey;
            return this;
        }
            

        // Check to see if ParameterKey property is set
        internal bool IsSetParameterKey()
        {
            return this.parameterKey != null;
        }

        /// <summary>
        /// The value associated with the parameter.
        ///  
        /// </summary>
        public string ParameterValue
        {
            get { return this.parameterValue; }
            set { this.parameterValue = value; }
        }

        /// <summary>
        /// Sets the ParameterValue property
        /// </summary>
        /// <param name="parameterValue">The value to set for the ParameterValue property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Parameter WithParameterValue(string parameterValue)
        {
            this.parameterValue = parameterValue;
            return this;
        }
            

        // Check to see if ParameterValue property is set
        internal bool IsSetParameterValue()
        {
            return this.parameterValue != null;
        }
    }
}
