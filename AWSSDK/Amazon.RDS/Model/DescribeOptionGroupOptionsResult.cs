/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> </para>
    /// </summary>
    public class DescribeOptionGroupOptionsResult  
    {
        
        private List<OptionGroupOption> optionGroupOptions = new List<OptionGroupOption>();
        private string marker;

        /// <summary>
        /// List of available options.
        ///  
        /// </summary>
        public List<OptionGroupOption> OptionGroupOptions
        {
            get { return this.optionGroupOptions; }
            set { this.optionGroupOptions = value; }
        }
        /// <summary>
        /// Adds elements to the OptionGroupOptions collection
        /// </summary>
        /// <param name="optionGroupOptions">The values to add to the OptionGroupOptions collection </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupOptionsResult WithOptionGroupOptions(params OptionGroupOption[] optionGroupOptions)
        {
            foreach (OptionGroupOption element in optionGroupOptions)
            {
                this.optionGroupOptions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the OptionGroupOptions collection
        /// </summary>
        /// <param name="optionGroupOptions">The values to add to the OptionGroupOptions collection </param>
        /// <returns>this instance</returns>
        public DescribeOptionGroupOptionsResult WithOptionGroupOptions(IEnumerable<OptionGroupOption> optionGroupOptions)
        {
            foreach (OptionGroupOption element in optionGroupOptions)
            {
                this.optionGroupOptions.Add(element);
            }

            return this;
        }

        // Check to see if OptionGroupOptions property is set
        internal bool IsSetOptionGroupOptions()
        {
            return this.optionGroupOptions.Count > 0;       
        }
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
        public DescribeOptionGroupOptionsResult WithMarker(string marker)
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
