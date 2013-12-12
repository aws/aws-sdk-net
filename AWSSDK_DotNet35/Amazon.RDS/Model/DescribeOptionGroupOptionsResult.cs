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
using Amazon.Runtime;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> </para>
    /// </summary>
    public partial class DescribeOptionGroupOptionsResult : AmazonWebServiceResponse
    {
        
        private List<OptionGroupOption> optionGroupOptions = new List<OptionGroupOption>();
        private string marker;


        /// <summary>
        /// List of available option group options.
        ///  
        /// </summary>
        public List<OptionGroupOption> OptionGroupOptions
        {
            get { return this.optionGroupOptions; }
            set { this.optionGroupOptions = value; }
        }

        // Check to see if OptionGroupOptions property is set
        internal bool IsSetOptionGroupOptions()
        {
            return this.optionGroupOptions.Count > 0;
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

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
