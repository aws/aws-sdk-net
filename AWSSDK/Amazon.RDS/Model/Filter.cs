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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Filter
    {
        
        private string filterName;
        private List<string> filterValue = new List<string>();

        /// <summary>
        /// This parameter is not currently supported.
        ///  
        /// </summary>
        public string FilterName
        {
            get { return this.filterName; }
            set { this.filterName = value; }
        }

        /// <summary>
        /// Sets the FilterName property
        /// </summary>
        /// <param name="filterName">The value to set for the FilterName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Filter WithFilterName(string filterName)
        {
            this.filterName = filterName;
            return this;
        }
            

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this.filterName != null;
        }

        /// <summary>
        /// This parameter is not currently supported.
        ///  
        /// </summary>
        public List<string> FilterValue
        {
            get { return this.filterValue; }
            set { this.filterValue = value; }
        }
        /// <summary>
        /// Adds elements to the FilterValue collection
        /// </summary>
        /// <param name="filterValue">The values to add to the FilterValue collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Filter WithFilterValue(params string[] filterValue)
        {
            foreach (string element in filterValue)
            {
                this.filterValue.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the FilterValue collection
        /// </summary>
        /// <param name="filterValue">The values to add to the FilterValue collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Filter WithFilterValue(IEnumerable<string> filterValue)
        {
            foreach (string element in filterValue)
            {
                this.filterValue.Add(element);
            }

            return this;
        }

        // Check to see if FilterValue property is set
        internal bool IsSetFilterValue()
        {
            return this.filterValue.Count > 0;
        }
    }
}
