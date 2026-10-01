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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Semantic description of the service a context graph node represents.
    /// </summary>
    public partial class NodeSemantics
    {
        private string _framework;
        private string _kind;
        private string _language;
        private string _purpose;
        private string _repository;

        /// <summary>
        /// Gets and sets the property Framework. 
        /// <para>
        /// The application framework the service is built on.
        /// </para>
        /// </summary>
        public string Framework
        {
            get { return this._framework; }
            set { this._framework = value; }
        }

        // Check to see if Framework property is set
        internal bool IsSetFramework()
        {
            return this._framework != null;
        }

        /// <summary>
        /// Gets and sets the property Kind. 
        /// <para>
        /// The kind of workload the service is.
        /// </para>
        /// </summary>
        public string Kind
        {
            get { return this._kind; }
            set { this._kind = value; }
        }

        // Check to see if Kind property is set
        internal bool IsSetKind()
        {
            return this._kind != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The primary programming language the service is written in.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property Purpose. 
        /// <para>
        /// What the service does.
        /// </para>
        /// </summary>
        public string Purpose
        {
            get { return this._purpose; }
            set { this._purpose = value; }
        }

        // Check to see if Purpose property is set
        internal bool IsSetPurpose()
        {
            return this._purpose != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The source repository the service is built from.
        /// </para>
        /// </summary>
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

    }
}