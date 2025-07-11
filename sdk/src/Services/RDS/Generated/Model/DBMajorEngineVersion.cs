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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the operation <c>DescribeDBMajorEngineVersions</c>.
    /// </summary>
    public partial class DBMajorEngineVersion
    {
        private string _engine;
        private string _majorEngineVersion;
        private List<SupportedEngineLifecycle> _supportedEngineLifecycles = AWSConfigs.InitializeCollections ? new List<SupportedEngineLifecycle>() : null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// The major version number of the database engine.
        /// </para>
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this._majorEngineVersion; }
            set { this._majorEngineVersion = value; }
        }

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this._majorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedEngineLifecycles. 
        /// <para>
        /// A list of the lifecycles supported by this engine for the <c>DescribeDBMajorEngineVersions</c>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SupportedEngineLifecycle> SupportedEngineLifecycles
        {
            get { return this._supportedEngineLifecycles; }
            set { this._supportedEngineLifecycles = value; }
        }

        // Check to see if SupportedEngineLifecycles property is set
        internal bool IsSetSupportedEngineLifecycles()
        {
            return this._supportedEngineLifecycles != null && (this._supportedEngineLifecycles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}