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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the PublishSchema operation.
    /// Publishes a development schema with a major version and a recommended minor version.
    /// </summary>
    public partial class PublishSchemaRequest : AmazonCloudDirectoryRequest
    {
        private string _developmentSchemaArn;
        private string _minorVersion;
        private string _name;
        private string _version;

        /// <summary>
        /// Gets and sets the property DevelopmentSchemaArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is associated with the development schema. For
        /// more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// The minor version under which the schema will be published. This parameter is recommended.
        /// Schemas have both a major and minor version associated with them.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string MinorVersion
        {
            get { return this._minorVersion; }
            set { this._minorVersion = value; }
        }

        // Check to see if MinorVersion property is set
        internal bool IsSetMinorVersion()
        {
            return this._minorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name under which the schema will be published. If this is not provided, the
        /// development schema is considered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// The major version under which the schema will be published. Schemas have both a major
        /// and minor version associated with them.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
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