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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkGroup operation.
    /// Creates a workgroup with the specified name.
    /// </summary>
    public partial class CreateWorkGroupRequest : AmazonAthenaRequest
    {
        private WorkGroupConfiguration _configuration;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration for the workgroup, which includes the location in Amazon S3 where
        /// query results are stored, the encryption configuration, if any, used for encrypting
        /// query results, whether the Amazon CloudWatch Metrics are enabled for the workgroup,
        /// the limit for the amount of bytes scanned (cutoff) per query, if it is specified,
        /// and whether workgroup's settings (specified with EnforceWorkGroupConfiguration) in
        /// the WorkGroupConfiguration override client-side settings. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
        /// </para>
        /// </summary>
        public WorkGroupConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The workgroup description.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The workgroup name.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}