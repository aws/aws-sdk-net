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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Amazon Security Lake can collect logs and events from third-party custom sources.
    /// </summary>
    public partial class CustomLogSourceResource
    {
        private CustomLogSourceAttributes _attributes;
        private CustomLogSourceProvider _provider;
        private string _sourceName;
        private string _sourceVersion;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of a third-party custom source.
        /// </para>
        /// </summary>
        public CustomLogSourceAttributes Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The details of the log provider for a third-party custom source.
        /// </para>
        /// </summary>
        public CustomLogSourceProvider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name for a third-party custom source. This must be a Regionally unique value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The version for a third-party custom source. This must be a Regionally unique value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

    }
}