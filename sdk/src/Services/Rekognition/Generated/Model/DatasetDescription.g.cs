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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// A description for a dataset. For more information, see <a>DescribeDataset</a>.
    /// 
    ///  
    /// <para>
    /// The status fields <c>Status</c>, <c>StatusMessage</c>, and <c>StatusMessageCode</c>
    /// reflect the last operation on the dataset. 
    /// </para>
    /// </summary>
    public partial class DatasetDescription
    {
        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        ///  The Unix timestamp for the time and date that the dataset was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetStats. 
        /// <para>
        ///  The status message code for the dataset. 
        /// </para>
        /// </summary>
        public DatasetStats DatasetStats { get; set; }

        /// <summary>
        /// Checks to see if the DatasetStats property is set.
        /// </summary>
        internal bool IsSetDatasetStats() => this.DatasetStats != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        ///  The Unix timestamp for the date and time that the dataset was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the dataset. 
        /// </para>
        /// </summary>
        public DatasetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  The status message for the dataset. 
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StatusMessageCode. 
        /// <para>
        ///  The status message code for the dataset operation. If a service error occurs, try
        /// the API call again later. If a client error occurs, check the input parameters to
        /// the dataset API call that failed. 
        /// </para>
        /// </summary>
        public DatasetStatusMessageCode StatusMessageCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessageCode property is set.
        /// </summary>
        internal bool IsSetStatusMessageCode() => this.StatusMessageCode != null;
    }
}
