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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SelectionCriteria
    {
        private string _delimiter;
        private int? _maxDepth;
        private double? _minStorageBytesPercentage;

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// A container for the delimiter of the selection criteria being used.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public string Delimiter
        {
            get { return this._delimiter; }
            set { this._delimiter = value; }
        }

        // Check to see if Delimiter property is set
        internal bool IsSetDelimiter()
        {
            return this._delimiter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxDepth. 
        /// <para>
        /// The max depth of the selection criteria
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? MaxDepth
        {
            get { return this._maxDepth; }
            set { this._maxDepth = value; }
        }

        // Check to see if MaxDepth property is set
        internal bool IsSetMaxDepth()
        {
            return this._maxDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinStorageBytesPercentage. 
        /// <para>
        /// The minimum number of storage bytes percentage whose metrics will be selected.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must choose a value greater than or equal to <c>1.0</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=100)]
        public double? MinStorageBytesPercentage
        {
            get { return this._minStorageBytesPercentage; }
            set { this._minStorageBytesPercentage = value; }
        }

        // Check to see if MinStorageBytesPercentage property is set
        internal bool IsSetMinStorageBytesPercentage()
        {
            return this._minStorageBytesPercentage.HasValue; 
        }

    }
}