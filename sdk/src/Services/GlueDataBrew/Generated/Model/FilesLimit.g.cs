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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents a limit imposed on number of Amazon S3 files that should be selected for
    /// a dataset from a connected Amazon S3 path.
    /// </summary>
    public partial class FilesLimit
    {
        /// <summary>
        /// Gets and sets the property MaxFiles. 
        /// <para>
        /// The number of Amazon S3 files to select.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? MaxFiles { get; set; }

        /// <summary>
        /// Checks to see if the MaxFiles property is set.
        /// </summary>
        internal bool IsSetMaxFiles() => this.MaxFiles.HasValue;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// A criteria to use for Amazon S3 files sorting before their selection. By default uses
        /// DESCENDING order, i.e. most recent files are selected first. Another possible value
        /// is ASCENDING.
        /// </para>
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order != null;

        /// <summary>
        /// Gets and sets the property OrderedBy. 
        /// <para>
        /// A criteria to use for Amazon S3 files sorting before their selection. By default uses
        /// LAST_MODIFIED_DATE as a sorting criteria. Currently it's the only allowed value.
        /// </para>
        /// </summary>
        public OrderedBy OrderedBy { get; set; }

        /// <summary>
        /// Checks to see if the OrderedBy property is set.
        /// </summary>
        internal bool IsSetOrderedBy() => this.OrderedBy != null;
    }
}
