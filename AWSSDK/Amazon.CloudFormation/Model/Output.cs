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
    /// <para>The Output data type.</para>
    /// </summary>
    public class Output
    {
        
        private string outputKey;
        private string outputValue;
        private string description;

        /// <summary>
        /// The key associated with the output.
        ///  
        /// </summary>
        public string OutputKey
        {
            get { return this.outputKey; }
            set { this.outputKey = value; }
        }

        /// <summary>
        /// Sets the OutputKey property
        /// </summary>
        /// <param name="outputKey">The value to set for the OutputKey property </param>
        /// <returns>this instance</returns>
        public Output WithOutputKey(string outputKey)
        {
            this.outputKey = outputKey;
            return this;
        }
            

        // Check to see if OutputKey property is set
        internal bool IsSetOutputKey()
        {
            return this.outputKey != null;
        }

        /// <summary>
        /// The value associated with the output.
        ///  
        /// </summary>
        public string OutputValue
        {
            get { return this.outputValue; }
            set { this.outputValue = value; }
        }

        /// <summary>
        /// Sets the OutputValue property
        /// </summary>
        /// <param name="outputValue">The value to set for the OutputValue property </param>
        /// <returns>this instance</returns>
        public Output WithOutputValue(string outputValue)
        {
            this.outputValue = outputValue;
            return this;
        }
            

        // Check to see if OutputValue property is set
        internal bool IsSetOutputValue()
        {
            return this.outputValue != null;
        }

        /// <summary>
        /// User defined description associated with the output.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public Output WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
