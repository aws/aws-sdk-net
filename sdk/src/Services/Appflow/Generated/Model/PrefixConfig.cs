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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies elements that Amazon AppFlow includes in the file and folder names in the
    /// flow destination.
    /// </summary>
    public partial class PrefixConfig
    {
        private List<string> _pathPrefixHierarchy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PrefixFormat _prefixFormat;
        private PrefixType _prefixType;

        /// <summary>
        /// Gets and sets the property PathPrefixHierarchy. 
        /// <para>
        /// Specifies whether the destination file path includes either or both of the following
        /// elements:
        /// </para>
        ///  <dl> <dt>EXECUTION_ID</dt> <dd> 
        /// <para>
        /// The ID that Amazon AppFlow assigns to the flow run.
        /// </para>
        ///  </dd> <dt>SCHEMA_VERSION</dt> <dd> 
        /// <para>
        /// The version number of your data schema. Amazon AppFlow assigns this version number.
        /// The version number increases by one when you change any of the following settings
        /// in your flow configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Source-to-destination field mappings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Field data types
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Partition keys
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PathPrefixHierarchy
        {
            get { return this._pathPrefixHierarchy; }
            set { this._pathPrefixHierarchy = value; }
        }

        // Check to see if PathPrefixHierarchy property is set
        internal bool IsSetPathPrefixHierarchy()
        {
            return this._pathPrefixHierarchy != null && (this._pathPrefixHierarchy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrefixFormat. 
        /// <para>
        /// Determines the level of granularity for the date and time that's included in the prefix.
        /// 
        /// </para>
        /// </summary>
        public PrefixFormat PrefixFormat
        {
            get { return this._prefixFormat; }
            set { this._prefixFormat = value; }
        }

        // Check to see if PrefixFormat property is set
        internal bool IsSetPrefixFormat()
        {
            return this._prefixFormat != null;
        }

        /// <summary>
        /// Gets and sets the property PrefixType. 
        /// <para>
        /// Determines the format of the prefix, and whether it applies to the file name, file
        /// path, or both. 
        /// </para>
        /// </summary>
        public PrefixType PrefixType
        {
            get { return this._prefixType; }
            set { this._prefixType = value; }
        }

        // Check to see if PrefixType property is set
        internal bool IsSetPrefixType()
        {
            return this._prefixType != null;
        }

    }
}