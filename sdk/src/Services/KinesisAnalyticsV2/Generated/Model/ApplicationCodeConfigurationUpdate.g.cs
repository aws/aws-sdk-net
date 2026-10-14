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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CodeContentTypeUpdate. 
        /// <para>
        /// Describes updates to the code content type.
        /// </para>
        /// </summary>
        public CodeContentType CodeContentTypeUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CodeContentTypeUpdate property is set.
        /// </summary>
        internal bool IsSetCodeContentTypeUpdate() => this.CodeContentTypeUpdate != null;

        /// <summary>
        /// Gets and sets the property CodeContentUpdate. 
        /// <para>
        /// Describes updates to the code content of an application.
        /// </para>
        /// </summary>
        public CodeContentUpdate CodeContentUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CodeContentUpdate property is set.
        /// </summary>
        internal bool IsSetCodeContentUpdate() => this.CodeContentUpdate != null;
    }
}
