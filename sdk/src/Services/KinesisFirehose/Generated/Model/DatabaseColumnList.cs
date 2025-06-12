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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The structure used to configure the list of column patterns in source database endpoint
    /// for Firehose to read from. 
    /// 
    ///  
    /// <para>
    /// Amazon Data Firehose is in preview release and is subject to change.
    /// </para>
    /// </summary>
    public partial class DatabaseColumnList
    {
        private List<string> _exclude = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _include = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        ///  The list of column patterns in source database to be excluded for Firehose to read
        /// from. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Exclude
        {
            get { return this._exclude; }
            set { this._exclude = value; }
        }

        // Check to see if Exclude property is set
        internal bool IsSetExclude()
        {
            return this._exclude != null && (this._exclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        ///  The list of column patterns in source database to be included for Firehose to read
        /// from. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && (this._include.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}