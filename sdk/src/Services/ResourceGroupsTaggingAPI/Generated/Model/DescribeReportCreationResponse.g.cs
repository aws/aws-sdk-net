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

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// This is the response object from the DescribeReportCreation operation.
    /// </summary>
    public partial class DescribeReportCreationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Details of the common errors that all operations return.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// The path to the Amazon S3 bucket where the report was stored on creation.
        /// </para>
        /// </summary>
        public string S3Location { get; set; }

        /// <summary>
        /// Checks to see if the S3Location property is set.
        /// </summary>
        internal bool IsSetS3Location() => this.S3Location != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time that the report was started. 
        /// </para>
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Reports the status of the operation.
        /// </para>
        ///  
        /// <para>
        /// The operation status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RUNNING</c> - Report creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - Report creation is complete. You can open the report from the
        /// Amazon S3 bucket that you specified when you ran <c>StartReportCreation</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Report creation timed out or the Amazon S3 bucket is not accessible.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO REPORT</c> - No report was generated in the last 90 days.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
