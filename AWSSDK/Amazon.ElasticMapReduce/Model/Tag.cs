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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A key/value pair containing user-defined metadata that you can associate with an Amazon
    /// EMR resource. Tags make it easier to associate clusters in various ways, such as grouping
    /// clu\sters to track your Amazon EMR resource allocation costs.                    
    ///                                                                                  
    ///                                         For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
    /// Amazon EMR Resources</a>.
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;


        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A user-defined key, which is the minimum required information for a valid tag.   
        ///                                                                                  
        ///                            For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
        /// Amazon EMR Resources</a>.                                  
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }


        /// <summary>
        /// Sets the Key property
        /// </summary>
        /// <param name="key">The value to set for the Key property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Tag WithKey(string key)
        {
            this._key = key;
            return this;
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }


        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A user-defined value, which is optional in a tag.                                
        ///                                                                                  
        ///                            For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/DeveloperGuide/emr-plan-tags.html">Tagging
        /// Amazon EMR Resources</a>.                                  
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }


        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">The value to set for the Value property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Tag WithValue(string value)
        {
            this._value = value;
            return this;
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}