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

/*
 * Do not modify this file. This file is generated from the rds-2013-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeOptionGroupOptionsResult : AmazonWebServiceResponse
    {
        private string _marker;
        private List<OptionGroupOption> _optionGroupOptions = new List<OptionGroupOption>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <code>MaxRecords</code>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property OptionGroupOptions.
        /// </summary>
        public List<OptionGroupOption> OptionGroupOptions
        {
            get { return this._optionGroupOptions; }
            set { this._optionGroupOptions = value; }
        }

        // Check to see if OptionGroupOptions property is set
        internal bool IsSetOptionGroupOptions()
        {
            return this._optionGroupOptions != null && this._optionGroupOptions.Count > 0; 
        }

    }
}