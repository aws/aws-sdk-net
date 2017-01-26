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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the PublishSchema operation.
    /// Publishes a development schema with a version. If description and attributes are specified,
    /// PublishSchema overrides the development schema description and attributes. If not,
    /// the development schema description and attributes are used.
    /// </summary>
    public partial class PublishSchemaRequest : AmazonCloudDirectoryRequest
    {
        private string _developmentSchemaArn;
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property DevelopmentSchemaArn. 
        /// <para>
        /// ARN associated with the development schema. For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        public string DevelopmentSchemaArn
        {
            get { return this._developmentSchemaArn; }
            set { this._developmentSchemaArn = value; }
        }

        // Check to see if DevelopmentSchemaArn property is set
        internal bool IsSetDevelopmentSchemaArn()
        {
            return this._developmentSchemaArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// New name under which the schema will be published. If this is not provided, the development
        /// schema is considered.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version under which the schema will be published.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}