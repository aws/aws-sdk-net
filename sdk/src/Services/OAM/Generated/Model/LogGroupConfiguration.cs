/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.OAM.Model
{
    /// <summary>
    /// This structure contains the <c>Filter</c> parameter which you can use to specify which
    /// log groups are to share log events from this source account to the monitoring account.
    /// </summary>
    public partial class LogGroupConfiguration
    {
        private string _filter;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Use this field to specify which log groups are to share their log events with the
        /// monitoring account. Use the term <c>LogGroupName</c> and one or more of the following
        /// operands. Use single quotation marks (') around log group names. The matching of log
        /// group names is case sensitive. Each filter has a limit of five conditional operands.
        /// Conditional operands are <c>AND</c> and <c>OR</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>=</c> and <c>!=</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AND</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LIKE</c> and <c>NOT LIKE</c>. These can be used only as prefix searches. Include
        /// a <c>%</c> at the end of the string that you want to search for and include.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN</c> and <c>NOT IN</c>, using parentheses <c>( )</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LogGroupName IN ('This-Log-Group', 'Other-Log-Group')</c> includes only the log
        /// groups with names <c>This-Log-Group</c> and <c>Other-Log-Group</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LogGroupName NOT IN ('Private-Log-Group', 'Private-Log-Group-2')</c> includes
        /// all log groups except the log groups with names <c>Private-Log-Group</c> and <c>Private-Log-Group-2</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LogGroupName LIKE 'aws/lambda/%' OR LogGroupName LIKE 'AWSLogs%'</c> includes
        /// all log groups that have names that start with <c>aws/lambda/</c> or <c>AWSLogs</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you are updating a link that uses filters, you can specify <c>*</c> as the only
        /// value for the <c>filter</c> parameter to delete the filter and share all log groups
        /// with the monitoring account.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

    }
}