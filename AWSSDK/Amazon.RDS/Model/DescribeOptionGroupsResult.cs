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
    /// <para> List of option groups. </para>
    /// </summary>
    public class DescribeOptionGroupsResult
    {
        
        private List<OptionGroup> optionGroupsList = new List<OptionGroup>();
        private string marker;

        /// <summary>
        /// List of option groups.
        ///  
        /// </summary>
        public List<OptionGroup> OptionGroupsList
        {
            get { return this.optionGroupsList; }
            set { this.optionGroupsList = value; }
        }
        /// <summary>
        /// Adds elements to the OptionGroupsList collection
        /// </summary>
        /// <param name="optionGroupsList">The values to add to the OptionGroupsList collection </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupsResult WithOptionGroupsList(params OptionGroup[] optionGroupsList)
        {
            foreach (OptionGroup element in optionGroupsList)
            {
                this.optionGroupsList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the OptionGroupsList collection
        /// </summary>
        /// <param name="optionGroupsList">The values to add to the OptionGroupsList collection </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupsResult WithOptionGroupsList(IEnumerable<OptionGroup> optionGroupsList)
        {
            foreach (OptionGroup element in optionGroupsList)
            {
                this.optionGroupsList.Add(element);
            }

            return this;
        }

        // Check to see if OptionGroupsList property is set
        internal bool IsSetOptionGroupsList()
        {
            return this.optionGroupsList.Count > 0;
        }

        /// <summary>
        /// An optional pagination token provided by a previous request. If this parameter is specified, the response includes only records beyond the
        /// marker, up to the value specified by <c>MaxRecords</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
