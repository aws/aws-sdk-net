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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A response message that contains the status of an updated default search field.</para>
    /// </summary>
    public class UpdateDefaultSearchFieldResult  
    {
        
        private DefaultSearchFieldStatus defaultSearchField;

        /// <summary>
        /// The value of the <c>DefaultSearchField</c> configured for this search domain and its current status.
        ///  
        /// </summary>
        public DefaultSearchFieldStatus DefaultSearchField
        {
            get { return this.defaultSearchField; }
            set { this.defaultSearchField = value; }
        }

        /// <summary>
        /// Sets the DefaultSearchField property
        /// </summary>
        /// <param name="defaultSearchField">The value to set for the DefaultSearchField property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateDefaultSearchFieldResult WithDefaultSearchField(DefaultSearchFieldStatus defaultSearchField)
        {
            this.defaultSearchField = defaultSearchField;
            return this;
        }
            

        // Check to see if DefaultSearchField property is set
        internal bool IsSetDefaultSearchField()
        {
            return this.defaultSearchField != null;       
        }
    }
}
