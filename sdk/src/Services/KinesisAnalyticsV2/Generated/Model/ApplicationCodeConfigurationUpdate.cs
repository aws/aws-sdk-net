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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes code configuration updates for an application. This is supported for a Managed
    /// Service for Apache Flink application or a SQL-based Kinesis Data Analytics application.
    /// </summary>
    public partial class ApplicationCodeConfigurationUpdate
    {
        private CodeContentType _codeContentTypeUpdate;
        private CodeContentUpdate _codeContentUpdate;

        /// <summary>
        /// Gets and sets the property CodeContentTypeUpdate. 
        /// <para>
        /// Describes updates to the code content type.
        /// </para>
        /// </summary>
        public CodeContentType CodeContentTypeUpdate
        {
            get { return this._codeContentTypeUpdate; }
            set { this._codeContentTypeUpdate = value; }
        }

        // Check to see if CodeContentTypeUpdate property is set
        internal bool IsSetCodeContentTypeUpdate()
        {
            return this._codeContentTypeUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property CodeContentUpdate. 
        /// <para>
        /// Describes updates to the code content of an application.
        /// </para>
        /// </summary>
        public CodeContentUpdate CodeContentUpdate
        {
            get { return this._codeContentUpdate; }
            set { this._codeContentUpdate = value; }
        }

        // Check to see if CodeContentUpdate property is set
        internal bool IsSetCodeContentUpdate()
        {
            return this._codeContentUpdate != null;
        }

    }
}