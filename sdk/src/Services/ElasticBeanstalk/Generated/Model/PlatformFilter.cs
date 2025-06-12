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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes criteria to restrict the results when listing platform versions.
    /// 
    ///  
    /// <para>
    /// The filter is evaluated as follows: <c>Type Operator Values[1]</c> 
    /// </para>
    /// </summary>
    public partial class PlatformFilter
    {
        private string _operator;
        private string _type;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to apply to the <c>Type</c> with each of the <c>Values</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>=</c> | <c>!=</c> | <c>&lt;</c> | <c>&lt;=</c> | <c>&gt;</c> | <c>&gt;=</c>
        /// | <c>contains</c> | <c>begins_with</c> | <c>ends_with</c> 
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
        /// Valid values: <c>PlatformName</c> | <c>PlatformVersion</c> | <c>PlatformStatus</c>
        /// | <c>PlatformBranchName</c> | <c>PlatformLifecycleState</c> | <c>PlatformOwner</c>
        /// | <c>SupportedTier</c> | <c>SupportedAddon</c> | <c>ProgrammingLanguageName</c> |
        /// <c>OperatingSystemName</c> 
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
        ///  <c>PlatformStatus</c>: <c>Creating</c> | <c>Failed</c> | <c>Ready</c> | <c>Deleting</c>
        /// | <c>Deleted</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PlatformLifecycleState</c>: <c>recommended</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SupportedTier</c>: <c>WebServer/Standard</c> | <c>Worker/SQS/HTTP</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SupportedAddon</c>: <c>Log/S3</c> | <c>Monitoring/Healthd</c> | <c>WorkerDaemon/SQSD</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}