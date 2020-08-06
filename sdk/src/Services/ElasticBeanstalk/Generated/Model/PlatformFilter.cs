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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes criteria to restrict the results when listing platform versions.
    /// 
    ///  
    /// <para>
    /// The filter is evaluated as follows: <code>Type Operator Values[1]</code> 
    /// </para>
    /// </summary>
    public partial class PlatformFilter
    {
        private string _operator;
        private string _type;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to apply to the <code>Type</code> with each of the <code>Values</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>=</code> | <code>!=</code> | <code>&lt;</code> | <code>&lt;=</code>
        /// | <code>&gt;</code> | <code>&gt;=</code> | <code>contains</code> | <code>begins_with</code>
        /// | <code>ends_with</code> 
        /// </para>
        /// </summary>
        public string Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The platform version attribute to which the filter values are applied.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>PlatformName</code> | <code>PlatformVersion</code> | <code>PlatformStatus</code>
        /// | <code>PlatformBranchName</code> | <code>PlatformLifecycleState</code> | <code>PlatformOwner</code>
        /// | <code>SupportedTier</code> | <code>SupportedAddon</code> | <code>ProgrammingLanguageName</code>
        /// | <code>OperatingSystemName</code> 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The list of values applied to the filtering platform version attribute. Only one value
        /// is supported for all current operators.
        /// </para>
        ///  
        /// <para>
        /// The following list shows valid filter values for some filter attributes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PlatformStatus</code>: <code>Creating</code> | <code>Failed</code> | <code>Ready</code>
        /// | <code>Deleting</code> | <code>Deleted</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PlatformLifecycleState</code>: <code>recommended</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SupportedTier</code>: <code>WebServer/Standard</code> | <code>Worker/SQS/HTTP</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SupportedAddon</code>: <code>Log/S3</code> | <code>Monitoring/Healthd</code>
        /// | <code>WorkerDaemon/SQSD</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}