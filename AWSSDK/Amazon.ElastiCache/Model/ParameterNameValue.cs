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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para> A name and value pair used to update the value of a Parameter. </para>
    /// </summary>
    public class ParameterNameValue
    {
        
        private string parameterName;
        private string parameterValue;

        /// <summary>
        /// Specifies the name of the parameter.
        ///  
        /// </summary>
        public string ParameterName
        {
            get { return this.parameterName; }
            set { this.parameterName = value; }
        }

        /// <summary>
        /// Sets the ParameterName property
        /// </summary>
        /// <param name="parameterName">The value to set for the ParameterName property </param>
        /// <returns>this instance</returns>
        public ParameterNameValue WithParameterName(string parameterName)
        {
            this.parameterName = parameterName;
            return this;
        }
            

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this.parameterName != null;
        }

        /// <summary>
        /// Specifies the value of the parameter.
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
        public ParameterNameValue WithParameterValue(string parameterValue)
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
