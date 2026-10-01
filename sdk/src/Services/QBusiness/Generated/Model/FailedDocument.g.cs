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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A list of documents that could not be removed from an Amazon Q Business index. Each
    /// entry contains an error message that indicates why the document couldn't be removed
    /// from the index.
    /// </summary>
    public partial class FailedDocument
    {
        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the Amazon Q Business data source connector that contains the failed
        /// document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An explanation for why the document couldn't be removed from the index.
        /// </para>
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the document that couldn't be removed from the Amazon Q Business
        /// index.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1825)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
