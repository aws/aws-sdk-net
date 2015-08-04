/*
 * Copyright 2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Filter criteria that allows for event notification filtering based on an S3 Object's key name.
    /// </summary>
    public class S3KeyFilter
    {
        private List<FilterRule> filterRules;

        /// <summary>
        /// Gets and sets the filterRules property.
        /// These are the filter rules for this filter.
        /// </summary>
        public List<FilterRule> FilterRules
        {
            get
            {
                if (this.filterRules == null)
                    this.filterRules = new List<FilterRule>();

                return this.filterRules;
            }
            set { this.filterRules = value; }
        }

        // Check to see if FilterRules property is set
        internal bool IsSetFilterRules()
        {
            return this.filterRules != null && this.filterRules.Count > 0;
        }

    }
}
