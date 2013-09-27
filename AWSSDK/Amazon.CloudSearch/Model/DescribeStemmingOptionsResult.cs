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
    /// <para>A response message that contains the stemming options for a search domain.</para>
    /// </summary>
    public class DescribeStemmingOptionsResult  
    {
        
        private StemmingOptionsStatus stems;

        /// <summary>
        /// The stemming options configured for this search domain and the current status of those options.
        ///  
        /// </summary>
        public StemmingOptionsStatus Stems
        {
            get { return this.stems; }
            set { this.stems = value; }
        }

        /// <summary>
        /// Sets the Stems property
        /// </summary>
        /// <param name="stems">The value to set for the Stems property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeStemmingOptionsResult WithStems(StemmingOptionsStatus stems)
        {
            this.stems = stems;
            return this;
        }
            

        // Check to see if Stems property is set
        internal bool IsSetStems()
        {
            return this.stems != null;       
        }
    }
}
