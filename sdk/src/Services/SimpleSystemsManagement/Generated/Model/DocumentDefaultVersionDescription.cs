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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A default version of a document.
    /// </summary>
    public partial class DocumentDefaultVersionDescription
    {
        private string _defaultVersion;
        private string _defaultVersionName;
        private string _name;

        /// <summary>
        /// Gets and sets the property DefaultVersion. 
        /// <para>
        /// The default version of the document.
        /// </para>
        /// </summary>
        public string DefaultVersion
        {
            get { return this._defaultVersion; }
            set { this._defaultVersion = value; }
        }

        // Check to see if DefaultVersion property is set
        internal bool IsSetDefaultVersion()
        {
            return this._defaultVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultVersionName. 
        /// <para>
        /// The default version of the artifact associated with the document.
        /// </para>
        /// </summary>
        public string DefaultVersionName
        {
            get { return this._defaultVersionName; }
            set { this._defaultVersionName = value; }
        }

        // Check to see if DefaultVersionName property is set
        internal bool IsSetDefaultVersionName()
        {
            return this._defaultVersionName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the document.
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